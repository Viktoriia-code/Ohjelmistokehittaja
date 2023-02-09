using System.Globalization;
using System.IO;

namespace Harjoitus14
{
    public partial class DiaryForm : Form
    {
        public DiaryForm()
        {
            InitializeComponent();
            string teksti = File.ReadAllText("C:\\Users\\Viktoriia\\repos\\Ohjelmistokehittaja\\GraafiTehtavat\\Harjoitus14\\dairynotes.txt");
            NoteTB.Text = teksti;
        }

        private void SaveBT_Click(object sender, EventArgs e)
        {
            string teksti = File.ReadAllText(@"C:\Users\Viktoriia\repos\Ohjelmistokehittaja\GraafiTehtavat\Harjoitus14\dairynotes.txt");
            teksti = NoteTB.Text;
            teksti += " ~ " + DateTime.Now.ToString("dd.MM.yyyy HH:mm", CultureInfo.CreateSpecificCulture("en-US"));
            TextWriter text = new StreamWriter("C:\\Users\\Viktoriia\\repos\\Ohjelmistokehittaja\\GraafiTehtavat\\Harjoitus14\\dairynotes.txt");
            text.WriteLine(teksti);
            text.Close();
            Application.Exit();
        }
    }
}