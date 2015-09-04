using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nSpire.HelloWorld
{
    

    /// <summary>
    /// Some comments. 
    /// </summary>
    public class HelloWorld
    {
        private string name = "nSpire Health";

        /// <summary>
        /// Initializes a new instance of the <see cref="HelloWorld"/> class.
        /// </summary>
        public HelloWorld()
        {
            Console.WriteLine("Hello ", this.name);
        }
    }
}
