using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercisesNov10th
{
    class Home
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _address;       
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public Home(string name, string address)
        {
            _name = name;
            _address = address;

        }


    }
}
