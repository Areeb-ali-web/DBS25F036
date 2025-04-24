using System;

namespace G_36_SmartPrint.BL
{
    internal class AddressBL
    {

        public int AddressID { get; set; }
       

        private string addressDetail;
        
        private string city;

        public string state;
        private string postalCode;

        private string country;
        
        public string getaddressDetail() {
            return this.addressDetail;
        }
        public string getcity() {  return this.city; }
        public string getpostalcode() {  return this.postalCode; }
        public string getcountry() {  return this.country; }

        public void setaddressdetail(string addressdetail)
        {
            this.addressDetail = addressdetail;
        }

        public void setCity(string city)
        {
            this.city = city;
        }
        public void setcountry(string country)
        {
            this.country = country;
        }
        public void setpostalcode(string postalCode)
        {
            this.postalCode = postalCode; 
        }

    

        // Constructor
        public AddressBL( string addressDetail, string city, string state, string postalCode,string country)
        {
            this.addressDetail = addressDetail;
            this.city = city;
            this.postalCode = postalCode;
            this.country = country;
            this.addressDetail = addressDetail;
            this.state = state;
        }

        public AddressBL(int addressID,string addressDetail, string city, string state, string postalCode, string stat, string country)
        {
            this.AddressID = addressID;
            this.addressDetail = addressDetail;
            this.city = city;
            this.postalCode = postalCode;
            this.country = country;
            this.addressDetail = addressDetail;
            state = stat;
        }

        // Parameterless constructor for frameworks like Entity Framework or manual population
        public AddressBL() { }



    }
}
