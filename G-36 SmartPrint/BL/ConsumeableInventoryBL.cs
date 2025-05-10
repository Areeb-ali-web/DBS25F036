using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_36_SmartPrint.BL
{
    internal class ConsumeableInventoryBL
    {
        public int Item_id { get; private set; }
        public string Item_name { get; private set; }
        public int currentstock { get; private set; }

        public ConsumeableInventoryBL(int item_id, string item_name, int currentstock)
        {
            Item_id = item_id;
            Item_name = item_name;
            this.currentstock = currentstock;
        }
        public void setItemid(int item_id)
        {
            Item_id = item_id;
        }
        public int getItemid()
        {
            return Item_id;
        }
        public string getItemname() 
        {
            return Item_name;
        }

    }
}
