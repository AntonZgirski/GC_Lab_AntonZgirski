using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Threading.Tasks;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace GC_Lab
{
  internal class AsyncJSon
  {        
    public async Task WriteToFile(Person person)
    {
      
      using (FileStream fs = new FileStream("person.json", FileMode.Create, FileAccess.Write, FileShare.None))
      {
        await JsonSerializer.SerializeAsync<Person>(fs, person);        
      }
    }

    public async Task ReadToFile()
    {      
      using(FileStream fs = new FileStream("person.json", FileMode.Open, FileAccess.Read, FileShare.None))
      {
        var per = await JsonSerializer.DeserializeAsync<Person>(fs);        
      }
    }
  }
}
