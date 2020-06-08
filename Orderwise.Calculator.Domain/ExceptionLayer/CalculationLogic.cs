// ***********************************************************************
// Assembly         : Orderwise.Calculator.Domain
// Author           : Jaco
// Created          : 03-08-2016
//
// Last Modified By : Jaco
// Last Modified On : 03-08-2016
// ***********************************************************************
// <copyright file="CalculationLogic.cs" company="">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using Orderwise.Calculator.Common.Enums;
using Orderwise.Calculator.Common.Utilities;
using Orderwise.Calculator.Domain.InterfaceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orderwise.Calculator.Domain.ExceptionLayer
{
    /// <summary>
    /// Class CalculationLogic.
    /// </summary>
    public class CalculationLogic : ICalculationLogic
    {
        public Logic.CalculationLogic calculationLogic {get; set;}
        
        public CalculationLogic()
        {
            calculationLogic = new Logic.CalculationLogic();
        }
        
        /// <summary>
        /// Calculates the value.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <returns>System.String.</returns>
        public string CalculateValue(string expression)
        {
            try
            {
                return calculationLogic.CalculateValue(expression);
            }
            catch (Exception ex)
            {
                LogEvent.LogException(ex);
                return "Error";
            }
        }

        public string GetSquareRoot(string expression)
        {
            try
            {
                return calculationLogic.GetSquareRoot(expression);
            }
            catch (Exception ex)
            {
                LogEvent.LogException(ex);
                return "Error";
            }
        }
    }
}
