// ***********************************************************************
// Assembly         : Orderwise.Calculator.Common
// Author           : Jaco
// Created          : 03-08-2016
//
// Last Modified By : Jaco
// Last Modified On : 03-09-2016
// ***********************************************************************
// <copyright file="CalculationType.cs" company="">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orderwise.Calculator.Common.Enums
{
    /// <summary>
    /// Enum CalculationType
    /// </summary>
    public enum CalculationType
    {
        /// <summary>
        /// The multiply
        /// </summary>
        [Description("*")]
        Multiply = 0,
        /// <summary>
        /// The divide
        /// </summary>
        [Description("/")]
        Divide = 1,
        /// <summary>
        /// The subtract
        /// </summary>
        [Description("-")]
        Subtract = 2,
        /// <summary>
        /// The add
        /// </summary>
        [Description("+")]
        Add = 3,
        /// <summary>
        /// The root
        /// </summary>
        [Description("√")]
        Root = 4,
        /// <summary>
        /// The percent
        /// </summary>
        [Description("%")]
        Percent = 5
    }
}
