using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTruyen.DTO
{
    public class DTO_Chapter
    {
        private int idChapter;
        private string numChapter;
        private string nameChapter;
        private int wordLength;

        public int IdChapter { get => idChapter; set => idChapter = value; }
        public string NumChapter { get => numChapter; set => numChapter = value; }
        public string NameChapter { get => nameChapter; set => nameChapter = value; }
        public int WordLength { get => wordLength; set => wordLength = value; }


        public DTO_Chapter(int id, string num, string name, int lengt)
        {
            this.IdChapter = id;
            this.NumChapter = num;
            this.NameChapter = name;
            this.wordLength = lengt;
        }

        public DTO_Chapter(DataRow row)
        {
            this.IdChapter = (int)row["id"];
            this.NumChapter = "Chương " + row["num_chap"];
            this.NameChapter = row["title"].ToString();
            this.WordLength = (int)row["length_word"];
        }
    }
}
