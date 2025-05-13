using System;

namespace G_36_SmartPrint.BL
{
    internal class LookupBL
    {
        // Properties with encapsulation
        public int LookupID { get; private set; }
        public string LookupType { get; private set; }
        public string LookupValue { get; private set; }

        // Constructors

        public LookupBL() { }

        public LookupBL(int lookupID)
        {
            LookupID = lookupID;
        }

        public LookupBL(int lookupID, string lookupValue)
        {
            LookupID = lookupID;
            LookupValue = lookupValue;
        }

        public LookupBL(string lookupType, string lookupValue)
        {
            LookupType = lookupType;
            LookupValue = lookupValue;
        }

        public LookupBL(int lookupID, string lookupType, string lookupValue)
        {
            LookupID = lookupID;
            LookupType = lookupType;
            LookupValue = lookupValue;
        }

        // Public Methods to update properties if needed
        public void SetLookupID(int id)
        {
            LookupID = id;
        }

        public void SetLookupType(string type)
        {
            LookupType = type;
        }

        public void SetLookupValue(string value)
        {
            LookupValue = value;
        }
    }
}
