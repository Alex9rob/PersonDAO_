using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication9F
{
    class PersonYAML : IPersonDAO
    {
        static List<Person> list = new List<Person>();
        public PersonYAML()
        {
        }
        public void Create(Person p)
        {
            StreamWriter sw = File.AppendText(@"D:\ort\code\PersonDAO\Formats\Person.yaml");
            string s1 = " - Id: " + p.ID.ToString();
            sw.WriteLine(s1);
            string s2 = "  FirstName: " + p.FName;
            sw.WriteLine(s2);
            string s3 = "  LastName: " + p.LName;
            sw.WriteLine(s3);
            string s4 = "  Age: " + p.Age.ToString();
            sw.WriteLine(s4);
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
            string[] lines = File.ReadAllLines(@"D:\ort\code\PersonDAO\Formats\Person.yaml");
            char[] sep = new char[] { ':', ' ' };
            for (int i = 1; i < lines.Length; i += 4)
            {
                Person newItem = new Person();
                string str1 = lines[i].Split(sep)[4];
                newItem.ID = Convert.ToInt32(str1);
                string str2 = lines[i + 1].Split(sep)[4];
                newItem.FName = str2;
                string str3 = lines[i + 2].Split(sep)[4];
                newItem.LName = str3;
                string str4 = lines[i + 3].Split(sep)[4];
                newItem.Age = Convert.ToInt32(str4);
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
            string[] str = new string[list.Count * 4 + 1];
            str[0] = "yaml:";
            for (int i = 0; i < list.Count; i++)
            {
                str[i * 4 + 1] = " - Id: " + list[i].ID.ToString();
                str[i * 4 + 2] = "  FirstName: " + list[i].FName;
                str[i * 4 + 3] = "  LastName: " + list[i].LName;
                str[i * 4 + 4] = "  Age: " + list[i].Age.ToString();
            }
            File.WriteAllLines(@"D:\ort\code\PersonDAO\Formats\Person.yaml", str);
        }
    }
}
