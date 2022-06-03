using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrensib.OC.CorrectUse
{
    class XmlLog2
    {
        public bool Log(string value)
        {
            //işlemler işlemler 
            return true;
        }
    }

    class DbLog2
    {
        public bool Log(string value)
        {
            //işlemler işlemler 
            return true;
        }
    }

    class Logger2
    {
        private readonly XmlLog _xmlLog;
        private readonly DbLog _dbLog;

        public Logger2(XmlLog xmlLog, DbLog dbLog)
        {
            _xmlLog = xmlLog;
            _dbLog = dbLog;
        }

        public void Log(LogType type, string value)
        {
            switch (type)
            {
                case LogType.Xml:
                    _xmlLog.Log(value);
                    break;
                case LogType.Db:
                    _dbLog.Log(value);
                    break;
            }

        }
    }
}
