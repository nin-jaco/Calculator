// ***********************************************************************
// Assembly         : Orderwise.Calculator.Service
// Author           : Jaco
// Created          : 03-08-2016
//
// Last Modified By : Jaco
// Last Modified On : 03-09-2016
// ***********************************************************************
// <copyright file="CalculatorService.cs" company="">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using Orderwise.Calculator.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CalculationLogic = Orderwise.Calculator.Domain.ExceptionLayer.CalculationLogic;

namespace Orderwise.Calculator.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    /// <summary>
    /// Class CalculatorService.
    /// </summary>
    /// <seealso cref="Orderwise.Calculator.Service.ICalculatorService" />
    public class CalculatorService : ICalculatorService
    {
        #region Properties
        /// <summary>
        /// Gets or sets the calculation logic.
        /// </summary>
        /// <value>The calculation logic.</value>
        public CalculationLogic calculationLogic { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="CalculatorService"/> class.
        /// </summary>
        public CalculatorService()
        {
            calculationLogic = new CalculationLogic();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Calculates the value.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <returns>System.String.</returns>
        public string CalculateValue(string expression)
        {
            return calculationLogic.CalculateValue(expression);
        }

        /// <summary>
        /// Gets the square root.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <returns>System.String.</returns>
        public string GetSquareRoot(string expression)
        {
            return calculationLogic.GetSquareRoot(expression);
        }
        #endregion
    }
}
