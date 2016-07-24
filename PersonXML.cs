using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication9F
{
    class PersonXML : IPersonDAO
    {
        public PersonXML()
        {
        }
        public void Create(Person p)
        {
            SaveToFileNoLast(Read());

            string[] sLines = File.ReadAllLines(@"D:\ort\code\PersonDAO\Formats\Person.xml");
            string lastStr = sLines[sLines.Length - 1];
            StreamWriter sw = File.AppendText(@"D:\ort\code\PersonDAO\Formats\Person.xml");
            sw.WriteLine("  <Person>");
            string s1 = "    <Id>" + p.ID.ToString() + "</Id>";
            sw.WriteLine(s1);
            string s2 = "    <FirstName>" + p.FName + "</FirstName>";
            sw.WriteLine(s2);
            string s3 = "    <LastName>" + p.LName + "</LastName>";
            sw.WriteLine(s3);
            string s4 = "    <Age>" + p.Age.ToString() + "</Age>";
            sw.WriteLine(s4);
            sw.WriteLine("  </Person>");
            sw.WriteLine("</Persons>");
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
            string[] lines = File.ReadAllLines(@"D:\ort\code\PersonDAO\Formats\Person.xml");
            string pattern = @"\s?<\w+>\s?(\w+)\s?</\w+>\s?";
            
            for (int i = 3; i < lines.Length; i += 6)
            {
                Person newItem = new Person();
                foreach (Match m in Regex.Matches(lines[i], pattern))
                {
                    newItem.ID = Int32.Parse(m.Groups[1].Value);
                }
                foreach (Match m in Regex.Matches(lines[i + 1], pattern))
                {
                    newItem.FName = m.Groups[1].Value;
                }
                foreach (Match m in Regex.Matches(lines[i + 2], pattern))
                {
                    newItem.LName = m.Groups[1].Value;
                }
                foreach (Match m in Regex.Matches(lines[i + 3], pattern))
                {
                    newItem.Age = Int32.Parse(m.Groups[1].Value);
                }
                Console.WriteLine(newItem.ID);
                Console.WriteLine(newItem.FName);
                Console.WriteLine(newItem.LName);
                Console.WriteLine(newItem.Age);
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
            string[] str = new string[list.Count*6+3];
            str[0] = "<?xml version=\"1.0\" encoding=\"utf - 8\"?>:";
            str[1] = "<Persons>";
            for (int i = 0; i < list.Count; i++)
            {
                str[i * 6 + 2] = "  <Person>";
                str[i * 6 + 3] = "    <Id>" + list[i].ID.ToString() + "</ID>";
                str[i * 6 + 4] = "    <Firstname>" + list[i].FName + "</Firstname>";
                str[i * 6 + 5] = "    <LastName>" + list[i].LName + "</LastName>";
                str[i * 6 + 6] = "    <Age>" + list[i].Age.ToString() + "</Age>";
                str[i * 6 + 7] = "  </Person>";
            }
             str[list.Count * 6 + 2] = "</Persons>";
            File.WriteAllLines(@"D:\ort\code\PersonDAO\Formats\Person.xml", str);
        }
        private void SaveToFileNoLast(List<Person> list)
        {
            string[] str = new string[list.Count * 6 + 2];
            str[0] = "<?xml version=\"1.0\" encoding=\"utf - 8\"?>:";
            str[1] = "<Persons>";
            for (int i = 0; i < list.Count; i++)
            {
                str[i * 6 + 2] = "  <Person>";
                str[i * 6 + 3] = "    <Id>" + list[i].ID.ToString() + "</ID>";
                str[i * 6 + 4] = "    <Firstname>" + list[i].FName + "</Firstname>";
                str[i * 6 + 5] = "    <LastName>" + list[i].LName + "</LastName>";
                str[i * 6 + 6] = "    <Age>" + list[i].Age.ToString() + "</Age>";
                str[i * 6 + 7] = "  </Person>";
            }
            File.WriteAllLines(@"D:\ort\code\PersonDAO\Formats\Person.xml", str);
        }
    }
}
