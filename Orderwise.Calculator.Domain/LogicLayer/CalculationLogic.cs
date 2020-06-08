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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NCalc.Domain;
using NCalc;

namespace Orderwise.Calculator.Domain.Logic
{
    /// <summary>
    /// Class CalculationLogic.
    /// </summary>
    public class CalculationLogic 
    {
        /// <summary>
        /// Calculates the value.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <returns>System.String.</returns>
        public string CalculateValue (string expression)
        {
            expression = expression.Contains(",") ? expression.Replace(",", ".") : expression;
            var calculatedValue = GetNCalcValue(expression);
            return calculatedValue.Contains(".") ? calculatedValue.Replace(".", ",") : calculatedValue;
        }

        public string GetSquareRoot(string expression)
        {
            expression = expression.Contains(",") ? expression.Replace(",", ".") : expression;
            expression = expression.Replace("√", "");
            expression = string.Format(@"Sqrt({0})", expression);
            var calculatedValue = GetNCalcValue(expression);
            return calculatedValue.Contains(".") ? calculatedValue.Replace(".", ",") : calculatedValue;
        }

        private string GetNCalcValue(string expression)
        {
            Expression exp = new Expression(expression);
            return exp.Evaluate().ToString();
        }
    }
}
