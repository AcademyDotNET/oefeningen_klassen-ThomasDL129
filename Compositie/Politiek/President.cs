using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Politiek
{
    class President : Minister
    {
        private int restJaren = 4;

        public President(string naam) : base(naam)
        {

        }

        public int RestJaren
        {
            get { return restJaren; }
            private set { restJaren = value; }
        }

        public void JaarVerder()
        {
            restJaren--;
        }
    }
}
