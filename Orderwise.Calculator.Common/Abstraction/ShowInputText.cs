using Orderwise.Calculator.Common.Enums;
using Orderwise.Calculator.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orderwise.Calculator.Common.Abstraction
{
    public class ShowInputText
    {
        public virtual string ReturnInputText(double valOne, double valTwo, CalculationType calcType)
        {
            return string.Format(@"{0}{1}{2}", valOne, calcType.ToString(), valTwo);
        }
    }

    public abstract class RecordCalculatorActions : ShowInputText
    {
        public abstract override string ReturnInputText(double valOne, double valTwo, CalculationType calcType);
    }

    public class ShowInputTextPlusResult : RecordCalculatorActions
    {
        public override string ReturnInputText(double valOne, double valTwo, CalculationType calcType)
        {
            return string.Format(@"{0}{1}{2}=", valOne, calcType.ToString(), valTwo) + @"{3}";
        }
    }

    public class ShowInputTextPlusError : RecordCalculatorActions
    {
        public override string ReturnInputText(double valOne, double valTwo, CalculationType calcType)
        {
            return string.Format(@"{0}{1}{2}=Cannot be calculated due to:", valOne, calcType.ToString(), valTwo) +  @"{3}";
        }
    }

    public class DoCalculation
    {
        public string DoCalculationAndReturnString(double valOne, double valTwo, CalculationType calcType)
        {
            var outputText = "";
            var result = "";
            try
            {
                switch (calcType)
                {
                    case CalculationType.Multiply:
                        result = (valOne * valTwo).ToString();
                        break;
                    case CalculationType.Divide:
                        result = (valOne / valTwo).ToString();
                        break;
                    case CalculationType.Subtract:
                        result = (valOne - valTwo).ToString();
                        break;
                    case CalculationType.Add:
                        result = (valOne + valTwo).ToString();
                        break;
                    case CalculationType.Root:
                        result = Math.Sqrt(valOne).ToString();
                        break;
                    case CalculationType.Percent:
                        result = (valOne / 100).ToString();
                        break;
                    default:
                        break;
                }
                ShowInputTextPlusResult text1 = new ShowInputTextPlusResult();
                outputText = string.Format(text1.ReturnInputText(valOne, valTwo, calcType), result);
            }
            catch (Exception ex)
            {
                LogEvent.LogException(ex);
                ShowInputTextPlusError text2 = new ShowInputTextPlusError();
                outputText = string.Format(text2.ReturnInputText(valOne, valTwo, calcType), ex);
            }
            return outputText;
        }
    }
}
