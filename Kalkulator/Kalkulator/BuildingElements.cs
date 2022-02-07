using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    public class BuildingElements
    {
        private StringBuilder _temp = new StringBuilder();
        private List<string> _elementsList = new List<string>();


        public List<string> ElementsList { get => _elementsList; set => _elementsList = value; }
        public StringBuilder Temp { get => _temp; set => _temp = value; }

        public void SingleElement(char a)
        {
            if (a != '=' && a != '+' && a != '-' && a != '*' && a != '/' && a != 'C')
            {
                _temp.Append(a);
            }

            else if (a == 'C')
            {
                _temp.Clear();
                _elementsList.Clear();
            }

            else 
            {
                if (_temp.Length > 0)
                {
                    _elementsList.Add(_temp.ToString());
                }

                _elementsList.Add(a.ToString());
                _temp.Clear();
            }
        }

        public void Equals(double result)
        {
            _elementsList.Clear();
            _elementsList.Add(result.ToString());
        }




    }

}
