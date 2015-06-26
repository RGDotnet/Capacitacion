using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitacionArmagedon.StyleCop
{
    class StyleCopBefore
    {
        private bool someboolean;

        private int somenumber;

        private string something;

        private enum Numbers
        {
            One,
            Two,
            Three,
            Four,
            Five
        }

        public StyleCopBefore()
        {
        }

        public StyleCopBefore(string[] Properties)
        {
        }

        public string MyProperty1 { get; set; }

        public string MyProperty2 { get; set; }

        public string MyProperty3 { get; set; }

        public string MyProperty4 { get; set; }

        public bool Someboolean
        {
            get { return someboolean; }
            set { someboolean = value; }
        }

        public int Somenumber
        {
            get { return somenumber; }
            set { somenumber = value; }
        }

        public string Something
        {
            get { return something; }
            set { something = value; }
        }

        public void DoNothing()
        {
            //TODO: place logic here
        }


        public Dictionary<string, object> ReturnDictionary()
        {
            return new Dictionary<string, object>();
        }

        public string ReturnEmptyString()
        {
            return string.Empty;
        }

        internal List<string> GetSomeList()
        {
            return new List<string>();
        }


        private List<Numbers> CalculateOrder(string letters, int numbers, bool flag, List<string> somelist, Dictionary<int, string> somedictionary)
        {
            if (flag)
                numbers = 0;


            return new List<Numbers>();
        }
    }
}
