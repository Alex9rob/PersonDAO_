using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System.Xml.Linq;
//using MongoDB.Driver.Builders;


namespace WindowsFormsApplication9F
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            //MongoClient client = new MongoClient();
            //var server = client.GetServer();
            //var db = server.GetDatabase("LibraryDB");
            //var collection = db.GetCollection<BookStore>("BookStore");
            /*
            Person p = new Person();
            p.ID = 457;
            p.FName = "Александр";
            p.LName = "Пушкин";
            p.Age = 37;
            Person c = new Person();
            c.ID = 657;
            c.FName = "Антон";
            c.LName = "Чехов";
            c.Age = 50;

            var connectionString = "mongodb://localhost:27017/?connectTimeoutMS=30000";
            var server = new MongoClient(connectionString);
            var db = server.GetDatabase("Persons");
            var collection = db.GetCollection<PersonDAO>("TableOfPersons");
            collection.add(p);
            */
            /*   Console.WriteLine("Connect...");

               MongoSever mongo = MongoServer.Create();
               mongo.Connect();

               Console.WriteLine("Connected");
               Console.WriteLine();

               var db = mongo.GetDatabase("tutorial");

               using (mongo.RequestStart(db))
               {
                   var collection = db.GetCollection<BsonDocument>("books");

                   BsonDocument book = new BsonDocument()
                       .Add("_id", BsonValue.Create(BsonType.ObjectId))
                       .Add("author", "Ernest Hemingway")
                       .Add("title", "For Whom the Bell Tolls");

                   collection.Insert(book);

                   var query = new QueryDocument("author", "Ernest Hemingway");

                   foreach (BsonDocument item in collection.Find(query))
                   {
                       BsonElement author = item.GetElement("author");
                       BsonElement title = item.GetElement("title");

                       Console.WriteLine("Author: {0}, Title: {1}", author.Value, title.Value); 
   ´ 
                       foreach (BsonElement element in item.Elements)
                       {
                           Console.WriteLine("Name: {0}, Value: {1}", element.Name, element.Value);
                       }
                   }
               }

               Console.WriteLine();
               Console.Read();

               mongo.Disconnect();

            */
        }
    }
}
