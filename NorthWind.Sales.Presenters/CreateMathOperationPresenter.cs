using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Sales.Presenters
{
    public class CreateMathOperationPresenter : ICreateMathOperationPresenter
    {
        public string Value { get; private set; }

        public ValueTask Handle(string value)
        {
            Value = value;
            return ValueTask.CompletedTask;
        }
    }
}
