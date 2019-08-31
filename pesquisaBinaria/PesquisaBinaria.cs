using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pesquisaBinaria
{
    class PesquisaBinaria
    {

        private int _eachOp;

        public int eachOp {
            get { return _eachOp; }
            set { _eachOp = value; }
        }


        public string binarySearchName(int min, int max, string name, Eleitor [] eleitores)
        {
            int mid = (min + max) / 2;
            eachOp++;
            if (min > max) {
                return "-1";
            }
            if (name.Equals(eleitores[mid].name))
            {
               
               
                return eleitores[mid].ToString();
            }
            if (name.CompareTo(eleitores[mid].name) > 0)
            {
               
                
                return binarySearchName(mid - 1, max, name, eleitores);
            }
            if (name.CompareTo(eleitores[mid].name) < 0)
            {
              
                
                return binarySearchName(min, mid + 1, name, eleitores);
            }
            return "-1";
        }

        public string seqSearch ( Eleitor [] eleitores, string name) {
         
            for (int i = 0; i < eleitores.Length; i++)
            {
                eachOp++;
                if (name.Equals(eleitores[i].name))
                {
                    return eleitores[i].ToString();
                }
            }

            return "";
        }


    }
}
