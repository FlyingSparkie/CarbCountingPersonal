using System;
using System.Windows.Forms;

namespace CarbCountRDI
{

    public partial class RIAssistant : Form
    {
        public int readyUpdate;
        public RIAssistant()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void FatPer_TextChanged(object sender, EventArgs e)
        {
            // String FatUnit = (this.FatPer.Text);
            // MessageBox.Show("Units for fat " + FatUnit);

        }

        private void ProteinPer_TextChanged(object sender, EventArgs e)
        {
            // String ProteinUnit = (this.ProteinPer.Text);
            //MessageBox.Show("Units for protein " + ProteinUnit);
        }

        private void SaltPer_TextChanged(object sender, EventArgs e)
        {
            //String SaltUnit = (this.SaltPer.Text);
            //MessageBox.Show("Units of Salt " + SaltUnit);
        }

        private void FatcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // MessageBox.Show("Fats checked");
        }

        private void ProteincheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // MessageBox.Show("Proteins checked");
        }

        private void SaltcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // MessageBox.Show("Salts checked");
        }

        private void debugText_TextChanged(object sender, EventArgs e)
        {
            debugText.Text = QtyPer.Text;

        }

        private void CarbscheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Carbs Checked");
            // updateScreenCarbs();
        }

        private void CarbsPer_TextChanged(object sender, EventArgs e)
        {
            String CarbsPer = (this.QtyPer.Text);
        }

        private void GrammesOfCarb_TextChanged(object sender, EventArgs e)
        {
            String GrammesOfCarb = (this.GrammesOfCarb.Text);
        }

        private void CarbsCountSoFartextBox_TextChanged(object sender, EventArgs e)
        {
            updateScreenCarbs();
        }

        private void FatCountSoFartextBox_TextChanged(object sender, EventArgs e)
        {
            updateScreenFat();
            // MessageBox.Show("Fat count so far");
        }

        private void ProteinCountSoFartextBox_TextChanged(object sender, EventArgs e)
        {
            updateScreenProtein();
            //MessageBox.Show("Protein count so far");
        }

        private void SaltCountSoFartextBox_TextChanged(object sender, EventArgs e)
        {
            updateScreenSalt();
            //MessageBox.Show("Salt count so far");
        }

        private void GrammesOfFat_TextChanged(object sender, EventArgs e)
        {
            // MessageBox.Show("Grammes of Fat");
        }

        private void GrammesOfProtein_TextChanged(object sender, EventArgs e)
        {
            // MessageBox.Show("Grammes of Protein");
        }

        private void GrammesOfSalt_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Grammes of Salt");
        }

        private void updateScreenCarbs()
        {
            float anpcarb = float.Parse(GrammesOfCarb.Text);
            float anocarb = float.Parse(QtyPer.Text);
            float tot = anocarb * anpcarb;              // carbs per the whole
            float usedCarbs = (260f - tot);                // 
            float usedCarbFormatted = 260 - usedCarbs;
            float carbsPercent = 100 - (100f / 260f) * usedCarbs;     // perent of daily intake
            this.CarbsCountSoFartextBox.Text = (usedCarbFormatted.ToString(".0"));
            this.RDICarbstextBox.Text = (carbsPercent.ToString(".0"));
        }

        private void updateScreenFat()
        {
            float anpfat = float.Parse(GrammesOfFat.Text);
            float anofat = float.Parse(QtyPer.Text);
            float tot = anofat * anpfat;
            float usedFat = (70f - tot);
            float usedFatFormatted = 70 - usedFat;
            float fatPercent = 100 - (100f / 70f) * usedFat;
            this.FatCountSoFartextBox.Text = (usedFatFormatted.ToString(".0"));
            this.RDIFattextBox.Text = (fatPercent.ToString(".0"));
        }

        private void updateScreenProtein()
        {
            float anpprotein = float.Parse(GrammesOfProtein.Text);
            float anoprotein = float.Parse(QtyPer.Text);
            float tot = anoprotein * anpprotein;
            float usedProtein = (50f - tot);
            float usedProteinFormatted = 50 - usedProtein;
            float proteinPercent = 100 - (100f / 50f) * usedProtein;
            this.ProteinCountSoFartextBox.Text = (usedProteinFormatted.ToString(".0"));
            this.RDIProteintextBox.Text = (proteinPercent.ToString(".0"));
        }

        private void updateScreenSalt()
        {
            float anpsalt = float.Parse(GrammesOfSalt.Text);
            float anosalt = float.Parse(QtyPer.Text);
            float tot = anosalt * anpsalt;
            float usedsalt = (6f - tot);
            float usedSaltFormatted = 6 - usedsalt;
            float saltPercent = 100 - (100f / 6f) * usedsalt;
            this.SaltCountSoFartextBox.Text = (usedSaltFormatted.ToString(".0"));
            this.RDISalttextBox.Text = (saltPercent.ToString(".0"));
        }

        private void CarbsConfirmedbutton_Click(object sender, EventArgs e)
        {

            updateScreenCarbs();

        }

        private void FatConfirmedbutton_Click(object sender, EventArgs e)
        {
            updateScreenFat();
        }

        private void ProteinConfirmedButton_Click(object sender, EventArgs e)
        {
            updateScreenProtein();
        }

        private void SaltConfirmedbutton_Click(object sender, EventArgs e)
        {
            updateScreenSalt();
        }

        private void labelEnterProtein_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*
                        float anp = float.Parse(GrammesOfCarb.Text);
                        float ano = float.Parse(CarbsPer.Text);
                        // float tot = ano * anp;
                        float tot = ano;
                        float used = (260 - tot);
                        var Percent = 260 / 100 * ano;
                        this.hundredgper.Text = ("" + (used));
                      //  MessageBox.Show(Percent.ToString() + "% of daily intake");*/
        }

        private void CountsPerunitgrammes_TextChanged(object sender, EventArgs e)
        {

        }

        private void RDICarbstextBox_TextChanged(object sender, EventArgs e)
        {
            /*  int anpcarb = int.Parse(GrammesOfCarb.Text);
              int anocarb = int.Parse(CarbsPer.Text);
              int tot = anocarb * anpcarb;              // carbs per the whole
              int usedCarbs = 260 - tot;                // whats left
              var carbsPercent = 100 / 260 * usedCarbs;     // perent of daily intake
           */
        }

        private void RDIFattextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RDIProteintextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RDISalttextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}