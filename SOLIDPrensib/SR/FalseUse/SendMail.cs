using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrensib.SR.FalseUse
{
    public class SendMail
    {
        public bool SendMailForX(string input, string mailAdress)
        {
            // Kural denetimi talep et
            if (!IsMailAdressValid(mailAdress))
                return false;

            // Formatlama işlemini yap
            return true;
        }

        private bool IsMailAdressValid(string mailAdress)
        {
            // Kural denetimini yap
            return true;
        }
    }
}
