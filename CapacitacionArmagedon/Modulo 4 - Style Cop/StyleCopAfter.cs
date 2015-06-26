//-----------------------------------------------------------------------
// <copyright file="StyleCopAfter.cs" company="Chanchuyo.com">
// 2015(c) Chanchuyo.com
// </copyright>
//-----------------------------------------------------------------------

namespace CapacitacionArmagedon.StyleCop
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Demonstration class for StyleCop
    /// </summary>
    /// <author>Ricardo Gonzalez</author>
    internal class StyleCopAfter
    {
        /// <summary>
        /// The a boolean
        /// </summary>
        private bool aboolean;

        /// <summary>
        /// The a number
        /// </summary>
        private int anumber;

        /// <summary>
        /// Some thing
        /// </summary>
        private string something;

        /// <summary>
        /// Initializes a new instance of the <see cref="StyleCopAfter"/> class.
        /// </summary>
        public StyleCopAfter()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StyleCopAfter"/> class.
        /// </summary>
        /// <param name="properties">The properties.</param>
        public StyleCopAfter(string[] properties)
        {
        }

        /// <summary>
        /// Demonstration enumerator for StyleCop
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
        /// Gets or sets a value indicating whether this <see cref="StyleCopAfter"/> is a boolean.
        /// </summary>
        /// <value><c>true</c> if a boolean; otherwise, <c>false</c>.</value>
        public bool Flag
        {
            get { return this.aboolean; }
            set { this.aboolean = value; }
        }

        /// <summary>
        /// Gets or sets my property1.
        /// </summary>
        /// <value>My property1.</value>
        public string MyProperty1 { get; set; }

        /// <summary>
        /// Gets or sets my property2.
        /// </summary>
        /// <value>My property2.</value>
        public string MyProperty2 { get; set; }

        /// <summary>
        /// Gets or sets my property3.
        /// </summary>
        /// <value>My property3.</value>
        public string MyProperty3 { get; set; }

        /// <summary>
        /// Gets or sets my property4.
        /// </summary>
        /// <value>My property4.</value>
        public string MyProperty4 { get; set; }

        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed.")]

        /// <summary>
        /// Gets or sets the somenumber.
        /// </summary>
        /// <value>The somenumber.</value>
        public int Somenumber
        {
            get { return this.anumber; }
            set { this.anumber = value; }
        }

        /// <summary>
        /// Gets or sets something.
        /// </summary>
        /// <value>Some thing.</value>
        public string Something
        {
            get { return this.something; }
            set { this.something = value; }
        }

        /// <summary>
        /// Does the nothing.
        /// </summary>
        public void DoNothing()
        {
            // TODO: place logic here
        }

        /// <summary>
        /// Returns the dictionary.
        /// </summary>
        /// <returns>Dictionary demonstration</returns>
        public Dictionary<string, object> ReturnDictionary()
        {
            return new Dictionary<string, object>();
        }

        /// <summary>
        /// Returns the empty string.
        /// </summary>
        /// <returns>Empty string</returns>
        public string ReturnEmptyString()
        {
            return string.Empty;
        }

        /// <summary>
        /// Gets some list.
        /// </summary>
        /// <returns>List of strings</returns>
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
        /// <param name="list">The some list.</param>
        /// <param name="dictionary">The some dictionary.</param>
        /// <returns>A list of numbers</returns>
        private List<Numbers> CalculateOrder(string letters, int numbers, bool flag, List<string> list, Dictionary<int, string> dictionary)
        {
            if (flag)
            {
                numbers = 0;
            }

            return new List<Numbers>();
        }
    }
}