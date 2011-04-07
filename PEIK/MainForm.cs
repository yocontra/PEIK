using System.Windows.Forms;
using PEIK.Util.Crypter;

namespace PEIK
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Text += " v" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            Crypter c = new Crypter("C:/out/test.exe", Configuration.CryptoSRC, "contralol");
            c.Process();
            c.Save("C:/out/out.exe");
        }
    }
}
