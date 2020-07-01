using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    public static class Factory
    {
        public static IDataAccess CreateDataAccess()
        {
            return new DataAccess(CreateHelper());
        }

        public static IHelper CreateHelper()
        {
            return new Helper();
        }

        public static IPasswordEncrypter CreatePasswordEncrypter()
        {
            return new SHA256();
        }
    }
}
