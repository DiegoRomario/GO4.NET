using GO4.NET.Console._2_Structural._3_Composite.ConcreteImplementations;

namespace GO4.NET.Console._2_Structural._3_Composite.Client
{
    public static class ScreenClient
    {

        public static void BuildScreen()
        {
            var btnSave = new Button("btnSave", 12.5656f, 55.969f);
            var btnRefresh = new Button("btnRefresh", 05.54116f, 82.2169f);
            var tab = new Tab("tabMain", 10, 10);
            var form = new Form("frmMain", 0, 0);

            tab.Add(btnSave);
            tab.Add(btnRefresh);
            tab.Show();
            form.Add(tab);
            form.Show();

        }
    }
}
