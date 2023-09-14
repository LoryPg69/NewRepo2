using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioBankomat
{
    public class Account : ContoCorrente  
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string CodiceFiscale { get; set; }


        public Account( string username, string password, double saldo) : base (saldo)
        {
            Username = username;
            Password = password;


        }
    
    }
}

