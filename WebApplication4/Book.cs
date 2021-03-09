using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication4
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Specifications Specifications { get; set; }

        public List<Book> ListarBooks()
        {
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"Base.json");
            var ListaBooks = JsonConvert.DeserializeObject<List<Book>>(json);
           
            return ListaBooks;
        }
    }
}
