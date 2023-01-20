using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repo
{
    public class UserData : IUserData
    {
        private readonly DataContext dataContext;
        public UserData(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public static DataEntity dataEntity = new DataEntity();
        public DataEntity DataDetails(DataModel DataModel)
        {
            try
            {
                //DataEntity dataEntity = new DataEntity();
                dataEntity.Id = DataModel.Id;
                dataEntity.Name = DataModel.Name;
                dataEntity.WebsiteName = DataModel.WebsiteName;
                dataEntity.UserId = DataModel.UserId;
                dataEntity.Password = DataModel.Password;
                dataEntity.Mobile = DataModel.Mobile;

                dataContext.DataTable.Add(dataEntity);

                int result = dataContext.SaveChanges();

                if (result != 0)
                {
                    return dataEntity;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
