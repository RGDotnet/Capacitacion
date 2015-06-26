using System.Collections.Generic;

namespace CapacitacionArmagedon.Ghost_Doc
{
    /// <summary>
    /// 
    /// </summary>
    public struct ArithmeticSum2
    {
        /// <summary>
        /// The somedecimal
        /// </summary>
        private decimal somedecimal;

        /// <summary>
        /// Sums the numbers.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <returns></returns>
        private decimal SumNumbers(decimal a, decimal b)
        {
            somedecimal = a + b;
            return somedecimal;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <author>
    /// Ricardo Gonzalez
    /// </author>
    internal class GhostDocAfter
    {
        /// <summary>
        /// The someboolean
        /// </summary>
        private bool someboolean;

        /// <summary>
        /// The somenumber
        /// </summary>
        private int somenumber;

        /// <summary>
        /// Something
        /// </summary>
        private string something;

        /// <summary>
        /// 
        /// </summary>
        private enum Numbers
        {
            /// <summary>
            /// The one
            /// </summary>
            One,
            /// <summary>
            /// The two
            /// </summary>
            Two,
            /// <summary>
            /// The three
            /// </summary>
            Three,
            /// <summary>
            /// The four
            /// </summary>
            Four,
            /// <summary>
            /// The five
            /// </summary>
            Five
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GhostDocAfter"/> class.
        /// </summary>
        public GhostDocAfter()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GhostDocAfter"/> class.
        /// </summary>
        /// <param name="Properties">The properties.</param>
        public GhostDocAfter(string[] Properties)
        {
        }

        /// <summary>
        /// Gets or sets my property1.
        /// </summary>
        /// <value>
        /// My property1.
        /// </value>
        public string MyProperty1 { get; set; }

        /// <summary>
        /// Gets or sets my property2.
        /// </summary>
        /// <value>
        /// My property2.
        /// </value>
        public string MyProperty2 { get; set; }

        /// <summary>
        /// Gets or sets my property3.
        /// </summary>
        /// <value>
        /// My property3.
        /// </value>
        public string MyProperty3 { get; set; }

        /// <summary>
        /// Gets or sets my property4.
        /// </summary>
        /// <value>
        /// My property4.
        /// </value>
        public string MyProperty4 { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="GhostDocAfter"/> is someboolean.
        /// </summary>
        /// <value>
        ///   <c>true</c> if someboolean; otherwise, <c>false</c>.
        /// </value>
        public bool Someboolean
        {
            get { return someboolean; }
            set { someboolean = value; }
        }

        /// <summary>
        /// Gets or sets the somenumber.
        /// </summary>
        /// <value>
        /// The somenumber.
        /// </value>
        public int Somenumber
        {
            get { return somenumber; }
            set { somenumber = value; }
        }

        /// <summary>
        /// Gets or sets something.
        /// </summary>
        /// <value>
        /// Something.
        /// </value>
        public string Something
        {
            get { return something; }
            set { something = value; }
        }

        /// <summary>
        /// Does the nothing.
        /// </summary>
        public void DoNothing()
        {
        }

        /// <summary>
        /// Returns the dictionary.
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, object> ReturnDictionary()
        {
            return new Dictionary<string, object>();
        }

        /// <summary>
        /// Returns the empty string.
        /// </summary>
        /// <returns></returns>
        public string ReturnEmptyString()
        {
            return string.Empty;
        }

        /// <summary>
        /// Gets some list.
        /// </summary>
        /// <returns></returns>
        internal List<string> GetSomeList()
        {
            return new List<string>();
        }

        /// <summary>
        /// Calculates the order.
        /// </summary>
        /// <param name="letters">The letters.</param>
        /// <param name="numbers">The numbers.</param>
        /// <param name="flag">if set to <c>true</c> [flag].</param>
        /// <param name="somelist">The somelist.</param>
        /// <param name="somedictionary">The somedictionary.</param>
        /// <returns></returns>
        private List<Numbers> CalculateOrder(string letters, int numbers, bool flag, List<string> somelist, Dictionary<int, string> somedictionary)
        {
            return new List<Numbers>();
        }
    }
}