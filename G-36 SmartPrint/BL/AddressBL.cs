using System;
using System.Text.RegularExpressions;

namespace G_36_SmartPrint.BL
{
    internal class AddressBL
    {
        
        public int AddressID { get; set; }
        public string AddressDetail { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string PostalCode { get; private set; }
        public string Country { get; private set; }

        public AddressBL() { }

        public AddressBL(int addressID, string addressDetail, string city, string state, string postalCode, string country)
        {
            AddressID = addressID;
            AddressDetail = addressDetail;
            City = city;
            State = state;
            PostalCode = postalCode;
            Country = country;
        }

        public AddressBL(string addressDetail, string city, string state, string postalCode, string country)
        {
            AddressDetail = addressDetail;
            City = city;
            State = state;
            PostalCode = postalCode;
            Country = country;
        }

        // Setters with validation (optional if needed individually)
        public void SetAddressDetail(string addressDetail)
        {
            AddressDetail = addressDetail;
        }

        public void SetCity(string city)
        {
            City = city;
        }

        public void SetState(string state)
        {
            State = state;
        }

        public void SetPostalCode(string postalCode)
        {
            PostalCode = postalCode;
        }

        public void SetCountry(string country)
        {
            Country = country;
        }

        // Validation
        public bool IsValid(out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(AddressDetail))
            {
                errorMessage = "Address detail cannot be empty.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(City))
            {
                errorMessage = "City cannot be empty.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(State))
            {
                errorMessage = "State cannot be empty.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(PostalCode) || !Regex.IsMatch(PostalCode, @"^\d{4,10}$"))
            {
                errorMessage = "Postal code is invalid.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(Country))
            {
                errorMessage = "Country cannot be empty.";
                return false;
            }

            errorMessage = "";
            return true;
        }

        // Equality check for duplicates
        public bool Equals(AddressBL other)
        {
            if (other == null) return false;

            return string.Equals(AddressDetail?.Trim(), other.AddressDetail?.Trim(), StringComparison.OrdinalIgnoreCase)
                && string.Equals(City?.Trim(), other.City?.Trim(), StringComparison.OrdinalIgnoreCase)
                && string.Equals(State?.Trim(), other.State?.Trim(), StringComparison.OrdinalIgnoreCase)
                && string.Equals(PostalCode?.Trim(), other.PostalCode?.Trim(), StringComparison.OrdinalIgnoreCase)
                && string.Equals(Country?.Trim(), other.Country?.Trim(), StringComparison.OrdinalIgnoreCase);
        }

        // Cloning method
        public AddressBL Clone()
        {
            return new AddressBL
            {
                AddressID = this.AddressID,
                AddressDetail = this.AddressDetail,
                City = this.City,
                State = this.State,
                PostalCode = this.PostalCode,
                Country = this.Country
            };
        }

        // For display/debugging
        public override string ToString()
        {
            return $"{AddressDetail}, {City}, {State}, {PostalCode}, {Country}";
        }
    }
}
