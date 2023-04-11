namespace GC_Lab
{
  public class Program
  {
    static async Task Main(string[] args)
    {
      var per = new Person("Anton","Zgirski",26,"Minsk");

      var asj = new AsyncJSon();

      await asj.WriteToFile(per);
      await asj.ReadToFile();                  
    }
  }
}