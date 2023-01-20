using Common;
using Repo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class UserDataB : IUserDataB
    {
        public readonly IUserData iuserData;
        public UserDataB(IUserData iuserData)
        {
            this.iuserData = iuserData;
        }
        public DataEntity DataDetails(DataModel dataModel)
        {
            try
            {
                return iuserData.DataDetails(dataModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
