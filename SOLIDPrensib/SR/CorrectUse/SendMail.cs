using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrensib.SR.CorrectUse
{
    public class MailAdressValidator
    {
        public bool IsMailAdressValid(string input)
        {
            // Kural denetimini yap
            return true;
        }
    }
    public class Printer
    {
        private MailAdressValidator _validator = new MailAdressValidator();

        public bool SendMailForX(string input, string mailAdress)
        {
            // Kural denetimini _validator nesnesine yaptır
            if (!_validator.IsMailAdressValid(mailAdress))
                return false;

            // Formatlama işlemini yap
            return true;
        }
    }
}

