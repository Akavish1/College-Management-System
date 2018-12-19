using merge_A;

namespace merge_A.PL
{
    partial class StudentsSec
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
            this.StudentID_txt = new System.Windows.Forms.TextBox();
            this.Student = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.Students = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Open = new System.Windows.Forms.Button();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.StudentId = new System.Windows.Forms.TextBox();
            this.Remove_From_Cyber = new System.Windows.Forms.Button();
            this.Add_To_Cyber = new System.Windows.Forms.Button();
            this.Block_Student = new System.Windows.Forms.Button();
            this.projectSCEDataSet1 = new merge_A.ProjectSCEDataSet();
            this.Students.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectSCEDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentID_txt
            // 
            this.StudentID_txt.Location = new System.Drawing.Point(385, 31);
            this.StudentID_txt.Name = "StudentID_txt";
            this.StudentID_txt.Size = new System.Drawing.Size(100, 20);
            this.StudentID_txt.TabIndex = 19;
            // 
            // Student
            // 
            this.Student.AutoSize = true;
            this.Student.Location = new System.Drawing.Point(315, 31);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(64, 13);
            this.Student.TabIndex = 18;
            this.Student.Text = "Student ID :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Location = new System.Drawing.Point(23, 28);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(41, 13);
            this.Search.TabIndex = 17;
            this.Search.Text = "Search";
            // 
            // Students
            // 
            this.Students.BackColor = System.Drawing.Color.Transparent;
            this.Students.Controls.Add(this.groupBox1);
            this.Students.Controls.Add(this.dataGridView1);
            this.Students.Location = new System.Drawing.Point(11, 71);
            this.Students.Name = "Students";
            this.Students.Size = new System.Drawing.Size(784, 286);
            this.Students.TabIndex = 15;
            this.Students.TabStop = false;
            this.Students.Text = "Students";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(1, 292);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 70);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(764, 237);
            this.dataGridView1.TabIndex = 0;
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(517, 31);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(141, 22);
            this.Open.TabIndex = 5;
            this.Open.Text = "Enter Student Section ";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Location = new System.Drawing.Point(711, 27);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(85, 26);
            this.ReturnBtn.TabIndex = 13;
            this.ReturnBtn.Text = "Back";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // StudentId
            // 
            this.StudentId.Location = new System.Drawing.Point(26, 382);
            this.StudentId.Name = "StudentId";
            this.StudentId.Size = new System.Drawing.Size(167, 20);
            this.StudentId.TabIndex = 20;
            // 
            // Remove_From_Cyber
            // 
            this.Remove_From_Cyber.BackColor = System.Drawing.Color.Transparent;
            this.Remove_From_Cyber.Location = new System.Drawing.Point(240, 363);
            this.Remove_From_Cyber.Name = "Remove_From_Cyber";
            this.Remove_From_Cyber.Size = new System.Drawing.Size(165, 58);
            this.Remove_From_Cyber.TabIndex = 21;
            this.Remove_From_Cyber.Text = "Remove Student From Cyber";
            this.Remove_From_Cyber.UseVisualStyleBackColor = false;
            this.Remove_From_Cyber.Click += new System.EventHandler(this.Remove_From_Cyber_Click_1);
            // 
            // Add_To_Cyber
            // 
            this.Add_To_Cyber.Location = new System.Drawing.Point(423, 363);
            this.Add_To_Cyber.Name = "Add_To_Cyber";
            this.Add_To_Cyber.Size = new System.Drawing.Size(162, 58);
            this.Add_To_Cyber.TabIndex = 22;
            this.Add_To_Cyber.Text = "Add Student To Cyber";
            this.Add_To_Cyber.UseVisualStyleBackColor = true;
            this.Add_To_Cyber.Click += new System.EventHandler(this.Add_To_Cyber_Click_1);
            // 
            // Block_Student
            // 
            this.Block_Student.Location = new System.Drawing.Point(607, 363);
            this.Block_Student.Name = "Block_Student";
            this.Block_Student.Size = new System.Drawing.Size(155, 58);
            this.Block_Student.TabIndex = 23;
            this.Block_Student.Text = "Block Student";
            this.Block_Student.UseVisualStyleBackColor = true;
            this.Block_Student.Click += new System.EventHandler(this.Block_Student_Click);
            // 
            // projectSCEDataSet1
            // 
            this.projectSCEDataSet1.DataSetName = "ProjectSCEDataSet";
            this.projectSCEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // StudentsSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::merge_A.Properties.Resources.green_design_background;
            this.ClientSize = new System.Drawing.Size(807, 433);
            this.Controls.Add(this.Block_Student);
            this.Controls.Add(this.Add_To_Cyber);
            this.Controls.Add(this.Remove_From_Cyber);
            this.Controls.Add(this.StudentId);
            this.Controls.Add(this.StudentID_txt);
            this.Controls.Add(this.Student);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Students);
            this.Controls.Add(this.ReturnBtn);
            this.Name = "StudentsSec";
            this.Text = "StudentsSec";
            this.Students.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectSCEDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StudentID_txt;
        private System.Windows.Forms.Label Student;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.GroupBox Students;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox StudentId;
        private System.Windows.Forms.Button Remove_From_Cyber;
        private System.Windows.Forms.Button Add_To_Cyber;
        private System.Windows.Forms.Button Block_Student;
        private ProjectSCEDataSet projectSCEDataSet1;
    }
}