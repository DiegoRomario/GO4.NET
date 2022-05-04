using GO4.NET.Console._2_Structural._7_Proxy.ConcreteImplementations;
using static System.Console;
namespace GO4.NET.Console._2_Structural._7_Proxy.Client
{
    internal class DocumentClient
    {
        public IGraphic Graphic { get; set; }

        public void Print()
        {
            Graphic = new ImageProxy();
            WriteLine("Here is the document");
            WriteLine($"The size of the image is: {Graphic.Size()}");
            WriteLine("The image is:");
            Graphic.Draw();
            WriteLine($"The size of the image is: {Graphic.Size()}");
        }
    }
}
