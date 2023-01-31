namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtpBday = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkCooking = new System.Windows.Forms.CheckBox();
            this.chkDancing = new System.Windows.Forms.CheckBox();
            this.chkFishing = new System.Windows.Forms.CheckBox();
            this.chkOutdoors = new System.Windows.Forms.CheckBox();
            this.chkMovies = new System.Windows.Forms.CheckBox();
            this.chkSinging = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(153, 130);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 23);
            this.txtName.TabIndex = 1;
            // 
            // dtpBday
            // 
            this.dtpBday.Location = new System.Drawing.Point(153, 167);
            this.dtpBday.Name = "dtpBday";
            this.dtpBday.Size = new System.Drawing.Size(200, 23);
            this.dtpBday.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Birthdate";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdFemale);
            this.groupBox1.Controls.Add(this.rdMale);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(75, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(57, 63);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(63, 19);
            this.rdFemale.TabIndex = 5;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Female";
            this.rdFemale.UseVisualStyleBackColor = true;
            this.rdFemale.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Location = new System.Drawing.Point(57, 29);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(51, 19);
            this.rdMale.TabIndex = 5;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Male";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gender";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkCooking);
            this.groupBox2.Controls.Add(this.chkDancing);
            this.groupBox2.Controls.Add(this.chkFishing);
            this.groupBox2.Controls.Add(this.chkOutdoors);
            this.groupBox2.Controls.Add(this.chkMovies);
            this.groupBox2.Controls.Add(this.chkSinging);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(75, 364);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 123);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // chkCooking
            // 
            this.chkCooking.AutoSize = true;
            this.chkCooking.Location = new System.Drawing.Point(63, 98);
            this.chkCooking.Name = "chkCooking";
            this.chkCooking.Size = new System.Drawing.Size(71, 19);
            this.chkCooking.TabIndex = 6;
            this.chkCooking.Text = "Cooking";
            this.chkCooking.UseVisualStyleBackColor = true;
            // 
            // chkDancing
            // 
            this.chkDancing.AutoSize = true;
            this.chkDancing.Location = new System.Drawing.Point(63, 62);
            this.chkDancing.Name = "chkDancing";
            this.chkDancing.Size = new System.Drawing.Size(70, 19);
            this.chkDancing.TabIndex = 6;
            this.chkDancing.Text = "Dancing";
            this.chkDancing.UseVisualStyleBackColor = true;
            // 
            // chkFishing
            // 
            this.chkFishing.AutoSize = true;
            this.chkFishing.Location = new System.Drawing.Point(152, 98);
            this.chkFishing.Name = "chkFishing";
            this.chkFishing.Size = new System.Drawing.Size(64, 19);
            this.chkFishing.TabIndex = 6;
            this.chkFishing.Text = "Fishing";
            this.chkFishing.UseVisualStyleBackColor = true;
            // 
            // chkOutdoors
            // 
            this.chkOutdoors.AutoSize = true;
            this.chkOutdoors.Location = new System.Drawing.Point(152, 62);
            this.chkOutdoors.Name = "chkOutdoors";
            this.chkOutdoors.Size = new System.Drawing.Size(76, 19);
            this.chkOutdoors.TabIndex = 6;
            this.chkOutdoors.Text = "Outdoors";
            this.chkOutdoors.UseVisualStyleBackColor = true;
            // 
            // chkMovies
            // 
            this.chkMovies.AutoSize = true;
            this.chkMovies.Location = new System.Drawing.Point(152, 27);
            this.chkMovies.Name = "chkMovies";
            this.chkMovies.Size = new System.Drawing.Size(64, 19);
            this.chkMovies.TabIndex = 6;
            this.chkMovies.Text = "Movies";
            this.chkMovies.UseVisualStyleBackColor = true;
            // 
            // chkSinging
            // 
            this.chkSinging.AutoSize = true;
            this.chkSinging.Location = new System.Drawing.Point(63, 27);
            this.chkSinging.Name = "chkSinging";
            this.chkSinging.Size = new System.Drawing.Size(66, 19);
            this.chkSinging.TabIndex = 6;
            this.chkSinging.Text = "Singing";
            this.chkSinging.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hobbies";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(453, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 266);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(551, 426);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(86, 28);
            this.btnBrowse.TabIndex = 7;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(171, 521);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 555);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpBday);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private DateTimePicker dtpBday;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton rdFemale;
        private RadioButton rdMale;
        private Label label3;
        private GroupBox groupBox2;
        private CheckBox chkCooking;
        private CheckBox chkDancing;
        private CheckBox chkFishing;
        private CheckBox chkOutdoors;
        private CheckBox chkMovies;
        private CheckBox chkSinging;
        private Label label4;
        private PictureBox pictureBox1;
        private Button btnBrowse;
        private Button btnSubmit;
    }
}