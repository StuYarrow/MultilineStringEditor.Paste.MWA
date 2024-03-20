using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;

namespace MultilineTextEditor.Paste.MWA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.propertyGrid1.SelectedObject = this.MyInstance;
        }

        public MyObject MyInstance { get; } = new();

        public class MyObject
        {
            [Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
            public string MyString { get; set; } = "MyObject.MyString has a default value.";
        }
    }
}
