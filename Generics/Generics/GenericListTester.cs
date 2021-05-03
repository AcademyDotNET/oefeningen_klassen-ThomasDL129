using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class GenericListTester <T>
    {
        public List<T> GenericList { get; set; }

        public GenericListTester()
        {
            GenericList = new List<T>();
        }

        public void ToonInfo()
        {
            for (int i = 0; i < GenericList.Count; i++)
            {
                Console.WriteLine($"Op plaats {i} staat de waarde {GenericList[i]}");
            }
        }
    }
}
