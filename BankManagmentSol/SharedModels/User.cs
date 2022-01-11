using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    class User
    {
        public User()
        {
            UserID = 0;
            LogInID = 0;
            UserName = "";
            Password = "";
            PersonID = 0;
            LocationID = 0;
            AccountHolderType = 0;
            IsManual = 0;
            EmailAddress = "";
            ContactNo = "";
        }

        public int UserID { get; set; }
        public int LogInID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int PersonID { get; set; }
        public int LocationID { get; set; }
        public int AccountHolderType { get; set; }
        public int IsManual { get; set; }
        public string EmailAddress { get; set; }
        public string ContactNo { get; set; }

    }
}
