namespace G_36_SmartPrint.I
{
    internal interface UserI
    {
        void UserLogin();
        void UserSignin();

        bool IsValidEmail(string email);

        // Password Validation

        bool IsValidPassword(string password);


        // Name Validation: At least 2 words
        bool IsValidName(string name);
    }
}
