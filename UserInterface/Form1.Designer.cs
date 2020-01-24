namespace UserInterface
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxForm = new System.Windows.Forms.GroupBox();
            this.open_file = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBoxStolenObject = new System.Windows.Forms.PictureBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.timeTheft = new System.Windows.Forms.DateTimePicker();
            this.txtProgram = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStolenObject)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxForm
            // 
            this.groupBoxForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBoxForm.Controls.Add(this.open_file);
            this.groupBoxForm.Controls.Add(this.label8);
            this.groupBoxForm.Controls.Add(this.pictureBoxStolenObject);
            this.groupBoxForm.Controls.Add(this.txtDescription);
            this.groupBoxForm.Controls.Add(this.timeTheft);
            this.groupBoxForm.Controls.Add(this.txtProgram);
            this.groupBoxForm.Controls.Add(this.txtID);
            this.groupBoxForm.Controls.Add(this.txtLastName);
            this.groupBoxForm.Controls.Add(this.label7);
            this.groupBoxForm.Controls.Add(this.label6);
            this.groupBoxForm.Controls.Add(this.label5);
            this.groupBoxForm.Controls.Add(this.label4);
            this.groupBoxForm.Controls.Add(this.label3);
            this.groupBoxForm.Controls.Add(this.btnSubmit);
            this.groupBoxForm.Controls.Add(this.txtLocation);
            this.groupBoxForm.Controls.Add(this.txtName);
            this.groupBoxForm.Controls.Add(this.label2);
            this.groupBoxForm.Controls.Add(this.label1);
            this.groupBoxForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBoxForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxForm.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBoxForm.Location = new System.Drawing.Point(12, 90);
            this.groupBoxForm.Name = "groupBoxForm";
            this.groupBoxForm.Size = new System.Drawing.Size(853, 400);
            this.groupBoxForm.TabIndex = 0;
            this.groupBoxForm.TabStop = false;
            this.groupBoxForm.Text = "S";
            this.groupBoxForm.Enter += new System.EventHandler(this.groupBox1_Enter);
            this.groupBoxForm.Resize += new System.EventHandler(this.groupBoxForm_Resize);
            // 
            // open_file
            // 
            this.open_file.Location = new System.Drawing.Point(601, 317);
            this.open_file.Name = "open_file";
            this.open_file.Size = new System.Drawing.Size(111, 40);
            this.open_file.TabIndex = 16;
            this.open_file.Text = "open image";
            this.open_file.UseVisualStyleBackColor = true;
            this.open_file.Click += new System.EventHandler(this.openFile_click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(455, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(379, 30);
            this.label8.TabIndex = 15;
            this.label8.Text = "insert an image of the stolen object";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // pictureBoxStolenObject
            // 
            this.pictureBoxStolenObject.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxStolenObject.Location = new System.Drawing.Point(512, 57);
            this.pictureBoxStolenObject.Name = "pictureBoxStolenObject";
            this.pictureBoxStolenObject.Size = new System.Drawing.Size(257, 240);
            this.pictureBoxStolenObject.TabIndex = 14;
            this.pictureBoxStolenObject.TabStop = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(148, 201);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(244, 96);
            this.txtDescription.TabIndex = 13;
            this.txtDescription.Text = "";
            // 
            // timeTheft
            // 
            this.timeTheft.Location = new System.Drawing.Point(148, 170);
            this.timeTheft.Name = "timeTheft";
            this.timeTheft.Size = new System.Drawing.Size(244, 20);
            this.timeTheft.TabIndex = 12;
            // 
            // txtProgram
            // 
            this.txtProgram.Location = new System.Drawing.Point(148, 115);
            this.txtProgram.Name = "txtProgram";
            this.txtProgram.Size = new System.Drawing.Size(244, 20);
            this.txtProgram.TabIndex = 11;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(148, 87);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(244, 20);
            this.txtID.TabIndex = 10;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(148, 60);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(244, 20);
            this.txtLastName.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Time of theft";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Program";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Icesi ID";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Name";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(396, 357);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(82, 31);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(148, 141);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(244, 20);
            this.txtLocation.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(148, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(244, 20);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Theft Location";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 502);
            this.Controls.Add(this.groupBoxForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxForm.ResumeLayout(false);
            this.groupBoxForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStolenObject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.DateTimePicker timeTheft;
        private System.Windows.Forms.TextBox txtProgram;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBoxStolenObject;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button open_file;
    }
}

