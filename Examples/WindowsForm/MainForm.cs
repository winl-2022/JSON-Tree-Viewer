using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Windows.Forms;

namespace WindowsForm
{
    [SuppressMessage(
        "Style",
        "IDE1006:Naming Styles",
        Justification = "allow event handler method name begin with lower-caption letter",
        Scope = "class",
        Target = "WindowsForm.MainForm")]
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void loadJsonButton_1_Click(object sender, EventArgs e) => LoadJson("Data\\Example 01.json");
        private void loadJsonButton_2_Click(object sender, EventArgs e) => LoadJson("Data\\Example 02.json");


        private void LoadJson(string file)
        {
            try
            {
                var json = File.ReadAllText(file);
                jsonTreeView.ShowJson(json);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Fail to show JSON. " + exc);
            }
        }
    }
}
