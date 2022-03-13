using AppTruyen.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTruyen.Controllers
{
    public class Infomation
    {
        private static Infomation instance;
        public static Infomation Instance
        {
            get { if (instance == null) instance = new Infomation(); return instance; }
            private set { instance = value; }
        }

        private Infomation() { }

        public double getSizeDB()
        {
            string query = "SELECT table_schema AS 'Database', SUM(data_length + index_length) / 1024 / 1024 AS 'size' FROM information_schema.TABLES";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            float total = 0;
            foreach (DataRow item in data.Rows)
            {
                total = float.Parse(item["size"].ToString());
            }
            
            return Math.Round(total, 2);
        }

        public string sizeDB()
        {
            string query = "SELECT table_schema AS 'Database', SUM(data_length + index_length) / 1024 / 1024 AS 'size' FROM information_schema.TABLES";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            float total = 0;
            foreach (DataRow item in data.Rows)
            {
                total = float.Parse(item["size"].ToString());
            }

            //5m = 100%
            //1m = ?
            //5m? = 1
            //? = 1/5m

            //total = (total / 5)*100;

            return (int)total + "MiB";
        }
    }
}
