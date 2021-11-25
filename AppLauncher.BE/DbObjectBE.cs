using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLauncher.BE
{
    public class DbObjectBE
    {
        public string Owner { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            string res = string.Empty;

            res = "(" + this.Owner + ", " + this.Type + ", " + this.Name + ")";
            return res;
        }

        public bool Equals(DbObjectBE other)
        {
            bool res = false;
            if (other != null)
            {
                res = (this.Name.CompareTo(other.Name) == 0 &&
                       this.Owner.CompareTo(other.Owner) == 0 &&
                       this.Type.CompareTo(other.Type) == 0);
            }
            return res;

        }
    }
}
