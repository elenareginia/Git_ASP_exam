using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace SiteNews
{
    public class DataBase
    {
        static SqlConnection sql;
        static MD5 md5Hash = MD5.Create();

        
    }
}