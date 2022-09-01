using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SOLID_example
{

    public class JsonMenuLoader : IMenuLoader
    {
        public List<Product> LoadMenu()
        {
            var text = File.ReadAllText(@"./menu.json");
            return JsonSerializer.Deserialize<List<Product>>(text);
        }
    }
}
