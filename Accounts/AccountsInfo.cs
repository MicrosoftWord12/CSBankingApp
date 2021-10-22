namespace CSBankingApp.Accounts
{
    
    /*
     * Author = Microsft Wrd 
     * Description = Utilities, this class if meant for being extended from a new class
     * 
     */
    public class AccountsInfo
    {
        private string nameF;
        private string nameL;
        private int accountNum;
        private string email;
        private string password;
        private int pinCode;

        public string GetNameF
        {
            get => nameF;
        }

        public string SetNameF
        {
            set => nameF = value;
        }

        public string GetNameL
        {
            get => nameL;
        }

        public string SetNameL
        {
            set => nameL = value;
        }

        public int GetAccountNum
        {
            get => accountNum;
        }

        public int SetAccountNum
        {
            set => accountNum = value;
        }

        public string GetEmail
        {
            get => email;
        }

        public string SetEmail
        {
            set => email = value;
        }

        public string GetPassword
        {
            get => password;
        }

        public string SetPassword
        {
            set => password = value;
        }

        public int GetPinCode
        {
            get => pinCode;
        }

        public int SetPinCode
        {
            set => pinCode = value;
        }
        
    }
}