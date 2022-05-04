using static System.Console;

namespace GO4.NET.Console._2_Structural._7_Proxy.ConcreteImplementations
{
    public class Image : IGraphic
    {
        public void Draw()
        {
            WriteLine("*******");
            WriteLine(" *   * ");
            WriteLine("  ***  ");
            WriteLine("*******");
        }

        public void Load()
        {
            WriteLine("Loading image... ");
            Thread.Sleep(500);
            WriteLine("... Image loaded");
        }

        public string Size()
        {
            return "500X500";
        }

        public void Store()
        {
            WriteLine("Storing image... ");
            Thread.Sleep(500);
            WriteLine("... Image Stored");
        }
    }
}
