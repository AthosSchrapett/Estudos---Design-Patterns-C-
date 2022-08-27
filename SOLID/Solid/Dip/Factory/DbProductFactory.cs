using Dip.Model;
using System.Configuration;

namespace Dip.Factory
{
    public class DbProductFactory
    {
        public static IDbProduct Create()
        {
            if (ConfigurationManager.AppSettings["DB"] == "SQLSERVER")
            {
                return new SQLServerProduct();
            }
            else
            {
                return new MongoDbProduct();
            }
        }
    }
}
