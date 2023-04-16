using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTracker.Models
{
    public class TestSteps : Dictionary<int, String>
    {
        public string RepresentAsText
        {
            get
            {
                string result = "";
                for (int i=1; i <= this.Count; i++)
                {
                    result += this[i].ToString() + "\n";
                }
                return result;
            }
        }
    }
}
