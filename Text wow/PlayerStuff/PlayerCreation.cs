namespace Text_wow.PlayerStuff
{
    internal class PlayerCreation
    {
        private string _accountName { get; set; }
        private string _accountPassword { get; set; }


        public PlayerCreation(string accname, string accpassword)
        {
            _accountName = accname;
            _accountPassword = accpassword;
        }

        public void CreateAccount()
        {


            Console.Write("Ange ett konto namn: ");

            _accountName = Console.ReadLine();
            Console.Write("Ange ett konto lösenord: ");

            while (true)
            {
                _accountPassword = Console.ReadLine();
                if (_accountPassword.Length < 8)
                {
                    Console.WriteLine("Lösenordet måste vara minst 8 tecken långt. Försök igen.");
                    continue;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine($"Ditt konto har skapats! Ditt konto namn är {_accountName} " +
                $"och ditt konto lösenord är {_accountPassword}");

            Console.ReadKey();
            Console.Clear();
        }
    }

}