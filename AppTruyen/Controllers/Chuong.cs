using AppTruyen.DTO;
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
    public class Chuong
    {
        private static Chuong instance;
        public static Chuong Instance
        {
            get { if (instance == null) instance = new Chuong(); return instance; }
            private set { instance = value; }
        }

        private Chuong() { }

        public List<DTO_Chapter> LoadData(int id_truyen)
        {
            string query = "SELECT id, title, num_chap, length_word FROM chuong where  id_truyen = " + id_truyen + " order by num_chap desc";

            List<DTO_Chapter> tablelist = new List<DTO_Chapter>();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DTO_Chapter tb = new DTO_Chapter(item);
                tablelist.Add(tb);
            }

            return tablelist;
        }

        public DataTable GetChapter(int id)
        {
            string query = "SELECT id, title, content, num_chap, length_word FROM chuong where  id = " + id;
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int UpdateData(int id, string content, int wordcount)
        {
            string query = "UPDATE chuong SET content = @content , length_word = @length_word where id = @id";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { Genarel.SaveContent(content), wordcount, id });
        }

        public int GetTotalWordCount(int id)
        {
            string query = "SELECT SUM(length_word) AS 'tong' FROM chuong WHERE id_truyen = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            int result = 0;
            foreach (DataRow row in data.Rows)
            {
                result = Int32.Parse(row.ItemArray[0].ToString());
                
                //break;
            }

            return result;
        }

        public int GetNumChap(int id_truyen)
        {
            string query = "SELECT num_chap FROM chuong where  id_truyen = " + id_truyen + " order by num_chap desc";
            DataTable data =  DataProvider.Instance.ExecuteQuery(query);
            int result = 0;

            foreach (DataRow row in data.Rows)
            {
                result = (int)row["num_chap"];
                break;
            }

            return result + 1;
        }

        public int AddChapter(int numchap, string title, string title_u, int id_truyen)
        {
            string query = "INSERT INTO chuong(title, title_u, content, num_chap, date_post, id_truyen, lock_chap) VALUES( @title , @title_u , @content , @num_chap , NOW() , @id_truyen , 0 )";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { title, title_u, "", numchap, id_truyen });
        }

        public int GetIdNewChapter(int id_truyen)
        {
            string query = "SELECT id FROM chuong where  id_truyen = " + id_truyen + " order by id desc";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            int result = 0;

            foreach (DataRow row in data.Rows)
            {
                result = (int)row["id"];
                break;
            }

            return result;
        }

        public int UpdateTitle(string title, string title_u, int id_chuong)
        {
            string query = "UPDATE chuong SET title = @title , title_u = @title_u where id = @id";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { title, title_u, id_chuong });
        }

        public DataTable GetNextChapter(int id_truyen, int numchap)
        {
            string query = "SELECT id, title, content, num_chap FROM chuong where id_truyen = " + id_truyen + " AND num_chap = " + numchap;
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetPrevChapter(int id_truyen, int numchap)
        {
            string query = "SELECT id, title, content, num_chap FROM chuong where id_truyen = " + id_truyen + " AND num_chap = " + numchap;
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public string GetNameStory(int id)
        {
            string query = "SELECT title FROM truyen where  id = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            string result = "";

            foreach (DataRow row in data.Rows)
            {
                result = row["title"].ToString();
                break;
            }

            return result;
        }
    }
}
