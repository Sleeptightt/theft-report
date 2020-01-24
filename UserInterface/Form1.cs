using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath+@"\background.jpg");
            groupBoxForm.BackgroundImage = img;
            groupBoxForm.BackgroundImageLayout = ImageLayout.Stretch;
           
        
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
            String text = name + "\n" + lname + "\n" + id + "\n" + program + "\n" + location + "\n" + time + "\n" + description;
            System.IO.File.WriteAllText(@"output.txt", text);
            MessageBox.Show("The report has been submitted successfully, to see it go to the resource folder, the file is named output");
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
    }
}
