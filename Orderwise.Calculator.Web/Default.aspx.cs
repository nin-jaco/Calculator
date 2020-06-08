// ***********************************************************************
// Assembly         : Orderwise.Calculator.Web
// Author           : Jaco
// Created          : 03-08-2016
//
// Last Modified By : Jaco
// Last Modified On : 03-09-2016
// ***********************************************************************
// <copyright file="Default.aspx.cs" company="">
//     Copyright ©  2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using Orderwise.Calculator.Web.CalculatorServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Orderwise.Calculator.Web
{
    /// <summary>
    /// Class Default1.
    /// </summary>
    /// <seealso cref="System.Web.UI.Page" />
    public partial class Default1 : System.Web.UI.Page
    {
        #region Properties  
        /// <summary>
        /// Gets or sets a value indicating whether this instance can append text.
        /// </summary>
        /// <value><c>true</c> if this instance can append text; otherwise, <c>false</c>.</value>
        public static bool CanAppendText { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance can append command.
        /// </summary>
        /// <value><c>true</c> if this instance can append command; otherwise, <c>false</c>.</value>
        public static bool CanAppendCommand { get; set; }
        /// <summary>
        /// Gets or sets the object in memory.
        /// </summary>
        /// <value>The object in memory.</value>
        public static string ObjectInMemory { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance can trim last.
        /// </summary>
        /// <value><c>true</c> if this instance can trim last; otherwise, <c>false</c>.</value>
        public static bool CanTrimLast { get; set; }
        #endregion

        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CanAppendText = false;
                CanAppendCommand = false;
                CanTrimLast = true;
                ObjectInMemory = "";
                tbResult.Text = "0";
            }
        }

        /// <summary>
        /// Handles the Click event of the Btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void Btn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (CanAppendText)
            {
                tbResult.Text += button.Text.ToString();                
            }
            else
            {
                tbResult.Text = button.Text.ToString();
                CanAppendText = true;
            }
            CanAppendCommand = true;
            CanTrimLast = true;
        }

        /// <summary>
        /// Handles the Click event of the Result control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void Result_Click(object sender, EventArgs e)
        {
            using (var service = new CalculatorServiceClient())
            {
                tbResult.Text = service.CalculateValue(tbResult.Text);
            }
            CanAppendText = false;
            CanAppendCommand = true;
            CanTrimLast = false;
        }

        /// <summary>
        /// Handles the Click event of the Cancel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void Cancel_Click(object sender, EventArgs e)
        {
            tbResult.Text = "0";
            CanAppendText = false;
            CanAppendCommand = false;
        }

        /// <summary>
        /// Handles the Click event of the Command control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void Command_Click(object sender, EventArgs e)
        {
            if (CanAppendCommand && tbResult.Text.IndexOfAny("+-*/".ToCharArray()) == -1)
            {
                Button button = (Button)sender;
                tbResult.Text += button.Text.ToString();
                CanAppendCommand = false;
                CanAppendText = true;
                CanTrimLast = true;
            }         
        }

        /// <summary>
        /// Handles the Click event of the SpecialCharacters control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void SpecialCharacters_Click(object sender, EventArgs e)
        {
            if (tbResult.Text.IndexOfAny(",".ToCharArray()) == -1)
            {
                Button button = (Button)sender;
                tbResult.Text += button.Text.ToString();
                CanAppendCommand = false;
                CanAppendText = true;
            } 
        }

        /// <summary>
        /// Handles the Click event of the SquareRoot control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void SquareRoot_Click(object sender, EventArgs e)
        {
            using (var service = new CalculatorServiceClient())
            {
                tbResult.Text = service.GetSquareRoot(tbResult.Text);
            }
            CanAppendText = false;
            CanAppendCommand = true;
        }

        /// <summary>
        /// Handles the Click event of the TrimLastCharacter control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void TrimLastCharacter_Click(object sender, EventArgs e)
        {
            if (CanTrimLast && tbResult.Text.Length > 1)
            {
                tbResult.Text = tbResult.Text.Remove(tbResult.Text.Length - 1);
            }
        }

        /// <summary>
        /// Handles the Click event of the AddObjectToMemory control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void AddObjectToMemory_Click(object sender, EventArgs e)
        {
            ObjectInMemory = tbResult.Text;
        }

        //todo: Memory ReCall and clear
    }
}