using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace UserInterface
{
    public partial class Form1 : Form
    {
        private Filer resources;
        public Form1()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath+@"\background.jpg");
            groupBoxForm.BackgroundImage = img;
            groupBoxForm.BackgroundImageLayout = ImageLayout.Stretch;
            resources = new Filer();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            String lname = txtLastName.Text;
            String id = txtID.Text;
            String program = txtProgram.Text;
            String location = txtLocation.Text;
            String time = timeTheft.Text;
            String description = txtDescription.Text;
            if (!String.IsNullOrEmpty(name) && !String.IsNullOrEmpty(lname) && !String.IsNullOrEmpty(id) && !String.IsNullOrEmpty(program) && !String.IsNullOrEmpty(location) && !String.IsNullOrEmpty(time)
                && !String.IsNullOrEmpty(description))
            {
                Report report = new Report(name, lname, id, program, location, time, description);
                resources.save(report);
                MessageBox.Show("The report has been submitted successfully, to see it press the see saved reports button");
            }else
                MessageBox.Show("Please make sure all fields are filled correctly");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void openFile_click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images|*.jpg;*png";
            ofd.Title = "Opening image";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string urlArchive = ofd.FileName;
                string name = ofd.SafeFileName;


                pictureBoxStolenObject.SizeMode = PictureBoxSizeMode.CenterImage;
                pictureBoxStolenObject.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBoxStolenObject.Load(urlArchive);
            }
        }

        private void groupBoxForm_Resize(object sender, EventArgs e)
        {
            groupBoxForm.Width = this.Width;
        }

        private void btnSavedReports_Click(object sender, EventArgs e)
        {
            List<Report> list = resources.load();
            Form2 reports = new Form2();
            String text = "";
            for(int i = 0; i < list.Count; i++)
            {
                if (i != 0)
                {
                    for (int j = 0; j < 100; j++) text += "-";
                    text += "\n\n";
                }
                text += "First name: " + list[i].getfirstN()+"\n";
                text += "Last name: " + list[i].getlastN() + "\n";
                text += "Student Code: " + list[i].getid() + "\n";
                text += "Program: " + list[i].getProgram() + "\n";
                text += "Theft location: " + list[i].getLocation() + "\n";
                text += "Time of theft: " + list[i].getTime() + "\n";
                text += "Description: " + list[i].getDescription() + "\n";
                text += "\n\n";
            }
            
            reports.Show();
            reports.getTxtReports().Text = text;
        }
    }
}
