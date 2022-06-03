using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrensib.SR.FalseUse
{
    class XmlLog
    {
        public bool Log(string value)
        {
            //işlemler işlemler 
            return true;
        }
    }

    class Logger
    {
        private readonly XmlLog _xmlLog = new XmlLog();

        public void Log(string value)
        {
            _xmlLog.Log(value);
        }

    }
}
