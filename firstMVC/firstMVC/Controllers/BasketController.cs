using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using firstMVC.DAOs;
using firstMVC.Helpers;
using firstMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;

namespace firstMVC.Controllers
{
    public class BasketController : Controller
    {
        #region DAO Konstruktor
        public BasketController(BasketDAO d)
        {
            dao = d;
        }

        BasketDAO dao;
        #endregion


        #region INDEX
        /// <summary>
        /// Zobrazí košík
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            //nadpis dle db
            ViewBag.title = dao.DBType();

            // Zobrazení košiku s načtenými daty
            List<BasketModel> itemsList = dao.AllProductsInBasket(1);

            return View(itemsList);
        } 
        #endregion 
        
        #region ADD

        /// <summary>
        /// Zobrazí formulář pro vložení nového zboží
        /// </summary>
        /// <returns>stránku s formulářem na přidání zboží</returns>
        public IActionResult Add()
        {
            //TODO: 1. AJAX - LIVE ZOBRAZENÍ CENY/KS A CENY_CELKEM PŘI VOLBĚ V DRROPDOWN LISTU

            //dropdown list 
            ViewBag.productList = dao.AllProductTypes();

            // zobrazení view na přidání zboží
            return View();
        }

        /// <summary>
        /// Přidání nového zboží do košíku
        /// </summary>
        /// <param name="newItem"></param>
        /// <returns></returns>
        [HttpPost] //viz. nastavení v html form
        public ActionResult Add(BasketModel newItem)
        {

            //!!! kontrola vyjímek zde (uživatelská chyba) !!!

            //validace (?bůh ví co to dělá?)
            if (!ModelState.IsValid)
            {
                return View(newItem);
            }

            // vložení nové položky do košíku
            dao.AddProduct(newItem);

            // Návrat do košíku
            return RedirectToAction("Index");
        }
        
        #endregion
         
        #region DELETE
        /// <summary>
        /// Otevře potvrzení zda skutečně chcete smazat
        /// </summary>
        /// <param name="id">id položky ke smazání</param>
        /// <returns></returns>
        public IActionResult Delete(int id)
        {

            //Ověření existence záznamu v DB
            if (!dao.ExistProduct(id))
            {
                return NotFound();
            }

            // pro přenos id zabaleno do BasketModelu (možná zbytečně překombinovaný)
            BasketModel item = dao.SelectItem(id);

            return View(item);
        }

        /// <summary>
        /// Smaže záznam v DB, dle zadané ID
        /// </summary>
        /// <param name="item">BasketModel s id položky ke smazání</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Delete(BasketModel item)
        {
            // smaže položku z košíku
            dao.DeleteItem(item.ID);

            // návrat do košíku
            return RedirectToAction("Index");
        }
        #endregion
         
        #region EDIT
        /// <summary>
        /// Otevře view pro Edit
        /// </summary>
        /// <param name="id">id editované položky</param>
        /// <returns></returns>
        public IActionResult Edit(int id)
        {
            //TODO: 1. vypsání detailů o editovaném zboží v pohledu [DONE]
            //      2. AJAX - live náhled celkové ceny již při psaní počtu kusů
            BasketModel item = dao.SelectItem(id);

            return View(item); //vykresluje stránku dle vložených dat
        }

        /// <summary>
        /// Mění počet kusů daného zboží v košíku
        /// </summary>
        /// <param name="item">BasketModel pro přenos zadaných dat</param>
        /// <returns></returns>
        [HttpPost] //viz. nastavení v html form
        public ActionResult Edit(BasketModel item) //načítá data ze stránky k provedení akce
        {
            dao.EditCount(item.ID, item.Ks);

            return RedirectToAction("Index");
        }
        #endregion        
    } 
} 