using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Lab
{
  [Serializable]
  internal class Person
  {
    public string FName { get; set; }
    public string SName { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }

    public Person(string fname, string name, int age, string adr)
    {
      this.FName = fname;
      this.SName = name;
      this.Age = age;
      this.Address = adr;
    }

    public Person()
    {
    }
  }
}
