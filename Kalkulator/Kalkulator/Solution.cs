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
        BuildingElements bld = new BuildingElements();
        List<string> _elementsList = new List<string>();
        public List<string> ElementsList { get => _elementsList; set => _elementsList = value; }
        public double Result { get => _result; set => _result = value; }

        public Solution(List<string> elemntsList)
        {
            this._elementsList = elemntsList;
        }


        //zmienic na switch
        public void MathFunction()
        {
            for (int i = 0; i < _elementsList.Count; i++)
            {
                if (_elementsList[i] == "+")
                {
                    _result = Convert.ToDouble(_elementsList[i - 1]) + Convert.ToDouble(_elementsList[i + 1]);
                    _elementsList[i + 1] = _result.ToString();
                }

                else if(_elementsList[i] == "-")
                {
                    _result = Convert.ToDouble(_elementsList[i - 1]) - Convert.ToDouble(_elementsList[i + 1]);
                    _elementsList[i + 1] = _result.ToString();
                }

                else if (_elementsList[i] =="*")
                {
                    _result = Convert.ToDouble(_elementsList[i - 1]) * Convert.ToDouble(_elementsList[i + 1]);
                    _elementsList[i + 1] = _result.ToString();
                }

                else if (_elementsList[i] == "/")
                {
                    _result = Convert.ToDouble(_elementsList[i - 1]) / Convert.ToDouble(_elementsList[i + 1]);
                    _elementsList[i + 1] = _result.ToString();
                }
              
            }

        }

    }
}
