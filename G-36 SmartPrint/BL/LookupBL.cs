using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_36_SmartPrint.BL
{
    internal class LookupBL
    {
        private int LookupID;
        private string LookupType;
        private string LookupValue;

        public LookupBL(int lookupID, string lookupType, string lookupValue)
        {
            LookupID = lookupID;
            LookupType = lookupType;
            LookupValue = lookupValue;
        }
        public LookupBL() { }

        public LookupBL(string lookupType,string lookupValue) { this.LookupType= lookupType; this.LookupValue= lookupValue; }

        public void setLookupId(int lookupID) { this.LookupID = lookupID; }
        public void setLookupType(string type) {  this.LookupType = type; }
        public void setLookupValue(string value) { this.LookupValue = value; }

        public int getLookupID() { return LookupID; }
        public string getLookupType() { return LookupType; }
        public string getLookupValue() { return LookupValue; }
    }
}
