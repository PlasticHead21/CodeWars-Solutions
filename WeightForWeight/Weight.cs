using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightForWeight
{
    public class Weight
    {
        private string svalue;

        public string Svalue
        {
            get { return svalue; }
            set
            {
                int temp;
                if(!String.IsNullOrWhiteSpace(value) && Int32.TryParse(value, out temp))
                svalue = value;
            }
        }
        public int Digit { get; set; }
    }
}
