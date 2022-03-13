using AppTruyen.Models;
using AppTruyen.Systems;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTruyen.Controllers
{
    public class Account
    {
        private static Account instance;
        public static Account Instance
        {
            get { if (instance == null) instance = new Account(); return instance; }
            private set { instance = value; }
        }

        private Account() { }

        public bool Login(string username, string password)
        {

            string query = "SELECT *FROM taikhoan WHERE user_name = @UserName AND pass_word = @PASS";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });

            if (result.Rows.Count > 0)
                GetDataFromAccount(result);

            return result.Rows.Count > 0;
        }

        private void GetDataFromAccount(DataTable data)
        {
            foreach (DataRow row in data.Rows)
            {
                Genarel.ID      = (int)row["id"];
                Genarel.USER    = row["user_name"].ToString();
            }
        }
    }
}
