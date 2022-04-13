using static System.Console;
using GO4.NET.Console._1_Creational._4_Prototype.ConcreteImplementations;

namespace GO4.NET.Console._1_Creational._4_Prototype.Client
{
    public static class FormClient
    {
        public static void GetForm()
        {
            IComponentPrototype button = new ButtonComponent() { Color = "Red", Label = "Ok" };
            IComponentPrototype textBox = button.Clone();
            textBox.Color = "Black";
            textBox.Label = "Any";

            WriteLine($"Original component [{button.Label} - {button.Color}]");
            WriteLine($"Cloned component [{textBox.Label} - {textBox.Color}]");

            button.Action();
            textBox.Action();
        }

    }
}
