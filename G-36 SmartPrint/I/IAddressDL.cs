using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G_36_SmartPrint.BL;

namespace G_36_SmartPrint.I
{
    internal interface IAddressDL
    {
       
            List<AddressBL> LoadUserAddress(UserBL user);
            bool AddAddressIfNotExists(int userId, AddressBL address);
            int GetAddressIdFromAddress();
           
        
    }
}
