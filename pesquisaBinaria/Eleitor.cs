using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pesquisaBinaria
{
    class Eleitor
    {
        private string _name;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _gender;

        public string gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        private string _registrationNum;

        public string registrationNum
        {
            get { return _registrationNum; }
            set { _registrationNum = value; }
        }

        private int _zone;

        public int zone
        {
            get { return _zone; }
            set { _zone = value; }
        }

        private int _section;

        public int section
        {
            get { return _section; }
            set { _section = value; }
        }

        public string ToString()
        {
            return name + "-" + gender + "-" + registrationNum + "-" + section.ToString() + "-" + zone.ToString();
        }

    }
}
