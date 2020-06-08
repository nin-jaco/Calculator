using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orderwise.Calculator.Domain.InterfaceLayer
{
    public interface ICalculationLogic
    {
        Orderwise.Calculator.Domain.Logic.CalculationLogic calculationLogic { get; set; }
        string CalculateValue(string expression);
        string GetSquareRoot(string expression);
    }
}
