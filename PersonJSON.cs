using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication9F
{
    class PersonJSON : IPersonDAO
    {
        static List<Person> list = new List<Person>();
        public PersonJSON()
        {
        }
        public void Create(Person p)
        {
            string s = ", {\"ID\": " + p.ID.ToString() + ", \"FirstName\": " + p.FName + ", \"LastName\": " + p.LName + ", \"Age\": " + p.Age.ToString() + "}";
            StreamWriter sw = File.AppendText(@"D:\ort\code\PersonDAO\Formats\Person.json");
            sw.Write(s);
            sw.Close();
        }

        public void Delete(Person p)
        {
            List<Person> list = Read();
            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i].ID == p.ID)
                {
                    list.RemoveAt(i);
                    break;
                }
            }
            SaveToFile(list);
        }

        public List<Person> Read()
        {
            List<Person> list = new List<Person>();
            string st = File.ReadAllLines(@"D:\ort\code\PersonDAO\Formats\Person.json")[0];
            char[] sep = new char[] { '{', '}' };
            string[] substrings = st.Split(sep);
            string pattern = "\"ID\":" + @"\s?" + @"(\d+)" + ", \"FirstName\":" + @"\s?" + @"(\w+)" + ", \"LastName\":" + @"\s?" + @"(\w+)" + ", \"Age\":" + @"\s?" + @"(\d+)";
            foreach (string sss in substrings)
            {
                Person newItem = new Person();
                foreach (Match m in Regex.Matches(sss, pattern))
                {
                    newItem.ID = Int32.Parse(m.Groups[1].Value);
                    newItem.FName = m.Groups[2].Value;
                    newItem.LName = m.Groups[3].Value;
                    newItem.Age = Int32.Parse(m.Groups[4].Value);
                    list.Add(newItem);
                }
            }
            return list;
        }

        public void Update(Person p)
        {
            List<Person> list = Read();
            bool flag = false;
            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i].ID == p.ID)
                {
                    list[i].FName = p.FName;
                    list[i].LName = p.LName;
                    list[i].Age = p.Age;
                    flag = true;
                    break;
                }
            }

            if (flag)
                SaveToFile(list);
            else
                Create(p);
        }
        private void SaveToFile(List<Person> list)
        {
            string str = "";
            foreach(Person p in list)
            {
                str += ", {\"ID\": " + p.ID.ToString() + ", \"FirstName\": " + p.FName + ", \"LastName\": " + p.LName + ", \"Age\": " + p.Age.ToString() + "}";
            }
            File.WriteAllText(@"D:\ort\code\PersonDAO\Formats\Person.json", str);

        }
    }
}
