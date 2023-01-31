using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);
                // image file path  
                txtName.Text = open.FileName;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string info = "", gender = "", hobby = "";
            
            if (rdMale.Checked)
            {
                 gender = rdMale.Text;
            }
            else {
                 gender = rdFemale.Text;
            }
            int Age = DateTime.Now.Year - dtpBday.Value.Year;
            if (chkSinging.Checked)
                hobby = hobby + "\nSinging";
            if (chkDancing.Checked)
                hobby = hobby + "\nDancing";
            if (chkCooking.Checked)
                hobby = hobby + "\nGaming";
            if (chkMovies.Checked)
                hobby = hobby + "\nCooking";
            if (chkOutdoors.Checked)
                hobby = hobby + "\nCycling";
            if (chkFishing.Checked)
                hobby = hobby + "\nSwimming";
            if (dtpBday.Value.AddYears(Age) > DateTime.Now) Age--;
            MessageBox.Show(info = "Name: " + txtName.Text
                            + "\nGender: " +gender
                            + "\nAge: " +Age
                            +"\nHobbies: "+hobby, "Personal Information", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
        }
    }
}