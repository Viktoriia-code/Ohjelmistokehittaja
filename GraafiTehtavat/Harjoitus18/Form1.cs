using System.Data;

namespace Harjoitus18
{
    public partial class AvainhenkilotForm : Form
    {
        DataTable schoolData = new DataTable();
        DataTable personData = new DataTable();
        DataTable contactData = new DataTable();
        public AvainhenkilotForm()
        {
            InitializeComponent();
        }
        private void AvainhenkilotForm_Load(object sender, EventArgs e)
        {
            getSchoolData();
            SchoolCB.DataSource = schoolData;
            SchoolCB.DisplayMember = "SName";
            getPersonData();
        }

        private void SchoolCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string schoolRef = schoolData.Rows[SchoolCB.SelectedIndex]["SID"].ToString();
            SchoolAddressLB.Text = schoolData.Rows[SchoolCB.SelectedIndex]["SAddress"].ToString();
            SchoolIndexLB.Text = schoolData.Rows[SchoolCB.SelectedIndex]["SIndex"].ToString();
            SchoolCityLB.Text = schoolData.Rows[SchoolCB.SelectedIndex]["SCity"].ToString();
            SchoolPhoneLB.Text = schoolData.Rows[SchoolCB.SelectedIndex]["SPhone"].ToString();

            contactData = personData.Select("SID =" + schoolRef).CopyToDataTable();
            PersonCB.DataSource = contactData;
            PersonCB.DisplayMember = "PName";
        }
        private void PersonCB_TextChanged(object sender, EventArgs e)
        {
            PersonTitleLB.Text = contactData.Rows[PersonCB.SelectedIndex]["PTitle"].ToString();
            PersonDepartmentLB.Text = contactData.Rows[PersonCB.SelectedIndex]["PDepartment"].ToString();
            PersonEmailLB.Text = contactData.Rows[PersonCB.SelectedIndex]["PEmail"].ToString();
            PersonPhoneLB.Text = contactData.Rows[PersonCB.SelectedIndex]["PPhone"].ToString();
        }

        private void getSchoolData()
        {
            schoolData.Columns.Add("SID", typeof(int));
            schoolData.Columns.Add("SName");
            schoolData.Columns.Add("SAddress");
            schoolData.Columns.Add("SIndex");
            schoolData.Columns.Add("SCity");
            schoolData.Columns.Add("SPhone");

            schoolData.Rows.Add(1, "StadinAO", "Hattulantie 2", "00550", "Helsinki", "09 310 8600");
            schoolData.Rows.Add(2, "Omnia", "Armas Launiksen katu 9", "02650", "Espoo", "046 877 1371");
            schoolData.Rows.Add(3, "Varia", "Rälssitie 13", "01530", "Vantaa", "040 182 4668");
            schoolData.Rows.Add(4, "Keuda", "Sibeliuksenväylä 55 A", "04400", "Järvenpää", "09 27 381");
        }

        private void getPersonData()
        {
            personData.Columns.Add("SID", typeof(int));
            personData.Columns.Add("PName");
            personData.Columns.Add("PTitle");
            personData.Columns.Add("PDepartment");
            personData.Columns.Add("PEmail");
            personData.Columns.Add("PPhone");

            personData.Rows.Add(1, "Sirpa Lindroos", "Rehtori", "Kampus 1", "sirpa.lindroos@hel.fi", "050 540 4434");
            personData.Rows.Add(1, "Hanna Laurila", "Rehtori", "Kaupus 2", "hanna.laurila@hel.fi", "040 676 5583");
            personData.Rows.Add(1, "Annele Ranta", "Rehtori", "Kampus 3", "annele.ranta@hel.fi", "040 631 5667");
            personData.Rows.Add(1, "Eeva Sahlman", "Rehtori", "Kampus 4", "eeva.sahlman@hel.fi", "040 336 1017");
            personData.Rows.Add(1, "Marko Aaltonen", "Rehtori", "Kampus 5", "marko.aaltonen@hel.fi", "050 511 8115");
            personData.Rows.Add(2, "Tuula Antola", "Koulutuskuntayhtymän johtaja", "Yleishallinto", "tuula.antola@omnia.fi", "");
            personData.Rows.Add(2, "Tapio Siukonen", "Hallintojohtaja", "Yleishallinto", "tapio.siukonen@omnia.fi", "044 369 6600");
            personData.Rows.Add(2, "Tuukko Soini", "Kehittämisjohtaja", "Yleishallinto", "tuukka.soini@omnia.fi", "046 877 2952");
            personData.Rows.Add(2, "Riikka-Maria Yli-Suomu", "Liiketoimintajohtaja", "Elinvoima- ja työllisyyspalvelut", "riikka-maria.yli-suomu@omnia.fi", "050 348 6544");
            personData.Rows.Add(2, "Maija Aaltola", "Rehtori", "Koulutus- ja opiskelijapalvelut", "maija-aaltola@omnia.fi", "050 384 9354");
            personData.Rows.Add(2, "Kai Iivari", "Talousjohtaja", "Talous ja hankintapalvelut", "kai.iivari@omnia.fi", "0400 306 691");
            personData.Rows.Add(2, "Päivi Korhonen", "Viestintäjohtaja", "Viestintä- ja markkinointipalvelut", "paivi.korhonen@omnia.fi", "040 126 7599");
            personData.Rows.Add(3, "Pekka Tauriainen", "Rehtori", "", "pekka.tauriainen@vantaa.fi", "050 312 4514");
            personData.Rows.Add(3, "Anne Heinonen", "Työelämäpalvelupäällikkö", "", "anne.heinonen@vantaa.fi", "040 524 1242");
            personData.Rows.Add(3, "Tuula Kiistinen", "Yhteisten palveluiden päällikkö", "", "tuula.kiiskinen@vantaa.fi", "040 193 9048");
            personData.Rows.Add(4, "Tiina Halmevuo", "Kuntayhtymän johtaja", "Hallinto- ja johtamispalvelut", "tiina.halmevuo@keuda.fi", "050 336 9709");
            personData.Rows.Add(4, "Anna Mari Leinonen", "Rehtori", "Hallinto", "annamari.leinonen@keuda.fi", "040 174 4523");
            personData.Rows.Add(4, "Anne Vuorinen", "Johtaja", "Yritys- ja elinvoimapalvelut", "anne.vuorinen@keuda.fi", "050 415 0974");
            personData.Rows.Add(4, "Hanna Nyrönen", "Viestintä- ja markkinointipäällikkö", "Viestintäpalvelut", "hanna.nyronen@keuda.fi", "040 521 8428");
            personData.Rows.Add(4, "Maarit Flinck", "Asianhallintapäällikkö", "Hallinto- ja johtamispalvelut", "maarit.flinck@keuda.fi", "0500 837 357");
        }
    }
}