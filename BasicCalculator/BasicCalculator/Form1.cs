using System;
using System.Linq;
using System.Windows.Forms;

namespace BasicCalculator
{
    /// <summary>
    /// A basic Calculator
    /// </summary>


    public partial class Form1 : Form
    {
        #region Constructor
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Clearing methods

        /// <summary>
        /// clear the user input text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void CEButton_Click(object sender, EventArgs e)
        {
            //clear the text from the user input text box
            this.UserIntputText.Text = string.Empty;

            // Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// delete character to the right of the selector and back focus to user input box on current position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //delete the text after the selected position
            DeleteTextValue();

            //focus the user input text
            FocusInputText();
        }

        #endregion

        #region operator methods

        /// <summary>
        /// Add the "/" character to the text at currently selection position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void PercentButton_Click(object sender, EventArgs e)
        {
            //Insert the value to the user input text box at the currently selection position
            InsertTextValue("/");

            //focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Add the "*" character to the text at currently selection position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void TimesButton_Click(object sender, EventArgs e)
        {
            //Insert the value to the user input text box at the currently selection position
            InsertTextValue("*");

            //focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Add the "-" character to the text at currently selection position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void MinusButton_Click(object sender, EventArgs e)
        {
            //Insert the value to the user input text box at the currently selection position
            InsertTextValue("-");

            //focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Add the "+" character to the text at currently selection position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void PlusButton_Click(object sender, EventArgs e)
        {
            //Insert the value to the user input text box at the currently selection position
            InsertTextValue("+");

            //focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Calculates the given equation and outputs the answer to the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnterButton_Click(object sender, EventArgs e)
        {
            //Calculate the equation in user input text box(in progress)
            CalculateEquation();

            //focus the user input text
            FocusInputText();
        }



        #endregion

        #region Number methods

        /// <summary>
        /// Add the "." character to the text at currently selection position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void DotButton_Click(object sender, EventArgs e)
        {
            //Insert the value to the user input text box at the currently selection position
            InsertTextValue(".");

            //focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Add the "0" character to the text at currently selection position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void ZeroButton_Click(object sender, EventArgs e)
        {
            //Insert the value to the user input text box at the currently selection position
            InsertTextValue("0");

            //focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Add the "1" character to the text at currently selection position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void OneButton_Click(object sender, EventArgs e)
        {
            //Insert the value to the user input text box at the currently selection position
            InsertTextValue("1");

            //focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Add the "2" character to the text at currently selection position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void TwoButton_Click(object sender, EventArgs e)
        {
            //Insert the value to the user input text box at the currently selection position
            InsertTextValue("2");

            //focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Add the "3" character to the text at currently selection position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void ThreeButton_Click(object sender, EventArgs e)
        {
            //Insert the value to the user input text box at the currently selection position
            InsertTextValue("3");

            //focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Add the "4" character to the text at currently selection position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void FourButton_Click(object sender, EventArgs e)
        {
            //Insert the value to the user input text box at the currently selection position
            InsertTextValue("4");

            //focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Add the "5" character to the text at currently selection position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void FiveButton_Click(object sender, EventArgs e)
        {
            //Insert the value to the user input text box at the currently selection position
            InsertTextValue("5");

            //focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Add the "6" character to the text at currently selection position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void SixButton_Click(object sender, EventArgs e)
        {
            //Insert the value to the user input text box at the currently selection position
            InsertTextValue("6");

            //focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Add the "7" character to the text at currently selection position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void SevenButton_Click(object sender, EventArgs e)
        {
            //Insert the value to the user input text box at the currently selection position
            InsertTextValue("7");

            //focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Add the "8" character to the text at currently selection position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void EightButton_Click(object sender, EventArgs e)
        {
            //Insert the value to the user input text box at the currently selection position
            InsertTextValue("8");

            //focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Add the "9" character to the text at currently selection position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void NineButton_Click(object sender, EventArgs e)
        {
            //Insert the value to the user input text box at the currently selection position
            InsertTextValue("9");

            //focus the user input text
            FocusInputText();
        }

        #endregion

        /// <summary>
        /// Calculates the given equation and outputs the answer to the user label
        /// </summary>
        private void CalculateEquation()
        {

            

            // 3. recursive functions
            // 4. switch statements

            this.CalculationResultText.Text = ParseOperation();

            //focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Parses the user equation and calculates the result
        /// </summary>
        /// <returns></returns>
        private string ParseOperation()
        {
            try
            {
                // Gets the users equation input
                var input = this.UserIntputText.Text;

                // Remove all spaces
                input = input.Replace(" ", "");

                // Create top-level operation
                var Operation = new Operation();
                var leftSide = true;


                // Loop through each character of the input
                // starting from to left, working to the right
                for (int i = 0; i < input.Length; i++)
                {
                    // TODO: Handle order priorty
                    //       4 + 5 * 2
                    //       It should calculate  5* 2 first, then 4 + result (so 4 + 10) 

                    // Check if the current character is a number
                    if ("0123456789.".Any(c => input[i] == c))
                    {
                        if (leftSide)
                            Operation.LeftSide = AddNumberPart(Operation.LeftSide, input[i]);
                    }

                }
                

                return string.Empty;    
            }
            catch(Exception e)
            {
                return $"invalid equation. {e.Message}";
            }
        }

        /// <summary>
        /// Attempts to add a new character to current number, checking for valid characters as it goes
        /// </summary>
        /// <param name="currentNumber"> The current number string </param>
        /// <param name="newCharacter"> The new character to append to the string </param>
        /// <returns></returns>
        private string AddNumberPart(string currentNumber, char newCharacter)
        {
            //Check if there is already a . in the number
            if (newCharacter.Equals(".") && currentNumber.Contains("."))
                throw new InvalidOperationException($"Number {currentNumber} already contains a . and another cannot be added");

            return currentNumber + newCharacter;

        }

                #region private helpers

        /// <summary>
        /// Focuses the user input text box
        /// </summary>
        private void FocusInputText()
        {
            this.UserIntputText.Focus();
        }

        /// <summary>
        /// Insert the text on the selected place 
        /// </summary>
        /// <param name="v">inserdted symbol</param>
        private void InsertTextValue(string v)
        {
            //remember selection start
            var selectionStart = this.UserIntputText.SelectionStart;

            //set new text
            this.UserIntputText.Text = this.UserIntputText.Text.Insert(this.UserIntputText.SelectionStart, v);

            //restore the selectionStart
            this.UserIntputText.SelectionStart = selectionStart + v.Length;

            //set selection leng to zero
            this.UserIntputText.SelectionLength = 0;
        }

        /// <summary>
        /// Delete the character to the right of the selection start of the user input box
        /// </summary>
        /// <param name="v">inserdted symbol</param>
        private void DeleteTextValue()
        {
            //if we dont have a value to odelete, return
            if (this.UserIntputText.TextLength < this.UserIntputText.SelectionStart + 1)
                return;

            //remember selection start
            var selectionStart = this.UserIntputText.SelectionStart;

            //delete the character to the right of the selection

            this.UserIntputText.Text = this.UserIntputText.Text.Remove(this.UserIntputText.SelectionStart, 1);

            //restore the selectionStart
            this.UserIntputText.SelectionStart = selectionStart;

            //set selection leng to zero
            this.UserIntputText.SelectionLength = 0;
        }


                #endregion


    }
}
