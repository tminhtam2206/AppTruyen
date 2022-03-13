using AppTruyen.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTruyen.Controllers
{
    public class Truyen
    {
        private static Truyen instance;
        public static Truyen Instance
        {
            get { if (instance == null) instance = new Truyen(); return instance; }
            private set { instance = value; }
        }

        private Truyen() { }

        public DataTable LoadData()
        {
            string query = "SELECT id, title, author FROM truyen order by date_update desc";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int UpdateDate(int id_truyen)
        {
            string query = "UPDATE truyen SET date_update = NOW()  WHERE id = @id";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id_truyen });

            return result;
        }

        public int GetWordCount(int id)
        {
            string query = "SELECT length_word FROM truyen  WHERE id = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            int result = 0;
            foreach (DataRow row in data.Rows)
            {
                result = Int32.Parse(row.ItemArray[0].ToString());
            }

            return result;
        }

        public void UpdateWordCount(int id)
        {
            int lenghtword = Chuong.Instance.GetTotalWordCount(id);
            string query = "UPDATE truyen SET length_word = @length_word  WHERE id = @id";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { lenghtword, id });
        }

        public void UpdateChapter(int id_truyen)
        {
            string query = "UPDATE truyen SET num_chaps = num_chaps + 1  WHERE id = @id";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id_truyen });
        }

        public void AddTruyen(string title, string title_u, string author)
        {
            string query = "INSERT INTO truyen(title, title_u, img, thumb, author, source, status, type, num_chaps, views, review, de_cu, date_create, date_update, user_post) VALUES ( @title , @title_u , @img , @thumb , @author , @source , @status , @type , @num_chaps , @views , @review , @de_cu , NOW() , NOW() , @user_post )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { title , title_u, "./storage/thien-dao-tich-than.jpg", "./storage/bg-default.jpeg", author , "http://tangkinhcac.atwebpages.com" , "Đang cập nhật" , "Truyện Dịch" , 0 , 0 , "this is review" , 0 , "tuan" });
        }
    }
}
