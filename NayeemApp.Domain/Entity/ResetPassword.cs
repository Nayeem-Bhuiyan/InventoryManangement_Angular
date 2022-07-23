using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NayeemApp.Domain.Entity
{
    public class ResetPassword
    {
        public string Password { get; set; }
        public string UserID { get; set; }
        public string code { get; set; }
    }
}
