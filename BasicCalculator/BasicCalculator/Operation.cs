using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    /// <summary>
    /// Holds information about a single calculator operation
    /// </summary>
    public class Operation
    {

        #region Public properties

        /// <summary>
        /// Left side of the operation
        /// </summary>
        public string LeftSide { get; set; }

        /// <summary>
        /// Right side of the operation
        /// </summary>
        public string RightSide { get; set; }

        /// <summary>
        /// Type of the operation to perform
        /// </summary>
        public OperationType OperationType { get; set; }

        /// <summary>
        /// The inner operation to performed initially before this operation
        /// </summary>
        public Operation InnerOperation { get; set; }



        #endregion

        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public Operation()
        {
            // create empty strings instead of having nulls
            this.LeftSide = string.Empty;
            this.RightSide = string.Empty;
        }

        #endregion


    }
}
