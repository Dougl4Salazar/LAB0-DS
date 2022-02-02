using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAB0DS.Helpers
{
    public class Data
    {
        private static Data _instance;
        public Data Instance
        {
            get { return _instance; }
            set { _instance = value; }
        }

    }
}
