using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication9F
{
    class PersonCSV : IPersonDAO
    {
        static List<Person> list = new List<Person>();
        public PersonCSV()
        {
        }
        public void Create(Person p)
        {
            string s = p.ID.ToString() + "," + p.FName + "," + p.LName + "," + p.Age.ToString();
            StreamWriter sw = File.AppendText(@"D:\ort\code\PersonDAO\Formats\Person.csv");
            sw.WriteLine(s);
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
            string[] lines = File.ReadAllLines(@"D:\ort\code\PersonDAO\Formats\Person.csv", Encoding.UTF8);
            for (int i = 1; i < lines.Length; i++)
            {
                string[] cells = lines[i].Split(',');
                Person newItem = new Person();
                newItem.ID = Convert.ToInt32(cells[0]);
                newItem.FName = cells[1];
                newItem.LName = cells[2];
                newItem.Age = Convert.ToInt32(cells[3]);
                list.Add(newItem);
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
            string[] str = new string[list.Count + 1];
            str[0] = "Id,FirstName,LastName,Age";
            for (int i = 0; i < list.Count; i++)
            {
                str[i + 1] = list[i].ID.ToString() + "," + list[i].FName + "," + list[i].LName + "," + list[i].Age.ToString();
            }
            File.WriteAllLines(@"D:\ort\code\PersonDAO\Formats\Person.csv", str);
        }
    }
}
