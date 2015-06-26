using System.Collections.Generic;

namespace CapacitacionArmagedon.Ghost_Doc
{
    public struct ArithmeticSum
    {
        private decimal somedecimal;

        private decimal SumNumbers(decimal a, decimal b)
        {
            somedecimal = a + b;
            return somedecimal;
        }
    }

    internal class GhostDocBefore
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

        public GhostDocBefore()
        {
        }

        public GhostDocBefore(string[] Properties)
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
            return new List<Numbers>();
        }
    }
}