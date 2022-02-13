using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class Solution
    {
        private double _result;
        List<string> _elementsList = new List<string>();

        public double Result { get => _result; private set => _result = value; }


        public Solution(List<string> elemntsList)
        {
            this._elementsList = elemntsList;
        }


        public void MathFunction()
        {
            for (int i = 0; i < _elementsList.Count; i++)
            {

                switch (_elementsList[i])
                {
                    case "+":
                        _result = Convert.ToDouble(_elementsList[i - 1]) + Convert.ToDouble(_elementsList[i + 1]);
                        _elementsList[i + 1] = _result.ToString();
                        break;

                    case "-":
                        _result = Convert.ToDouble(_elementsList[i - 1]) - Convert.ToDouble(_elementsList[i + 1]);
                        _elementsList[i + 1] = _result.ToString();
                        break;

                    case "*":
                        _result = Convert.ToDouble(_elementsList[i - 1]) * Convert.ToDouble(_elementsList[i + 1]);
                        _elementsList[i + 1] = _result.ToString();
                        break;

                    case "/":
                        _result = Convert.ToDouble(_elementsList[i - 1]) / Convert.ToDouble(_elementsList[i + 1]);
                        _elementsList[i + 1] = _result.ToString();
                        break;

                    case "=":
                       _elementsList.Clear();
                       _elementsList.Add(_result.ToString());
                        break;

                }

            }

        }

    }
}
