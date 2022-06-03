using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrensib.SR.CorrectUse
{
    interface IGet
    {
        void Get(int id);
    }
    interface IBaseApi : IGet
    {
        void Put(int id);
        void Post(int id);
        void Delete(int id);
    }

    public class News : IBaseApi
    {
        public void Put(int id)
        {
            throw new NotImplementedException();
        }

        public void Post(int id)
        {
            throw new NotImplementedException();
        }

        public void Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }

    public class Video : IBaseApi
    {
        public void Put(int id)
        {
            throw new NotImplementedException();
        }

        public void Post(int id)
        {
            throw new NotImplementedException();
        }

        public void Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }

    public class Notification : IGet
    {
        public void Get(int id)
        {
            throw new NotImplementedException();
        }

    }

}

