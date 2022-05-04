
namespace GO4.NET.Console._2_Structural._7_Proxy.ConcreteImplementations
{
    public class ImageProxy : IGraphic
    {
        public Image Image { get; set; }

        public void Draw()
        {
            if (Image == null)
            {
                Load();
            }
            Image.Draw();
        }

        public void Load()
        {
            Image = new Image();
            Image.Load();
        }

        public string Size()
        {
            if (Image == null)
            {
                return "Image not exists";
            }
            return Image.Size();
        }

        public void Store()
        {
            Image.Store();
        }
    }
}
