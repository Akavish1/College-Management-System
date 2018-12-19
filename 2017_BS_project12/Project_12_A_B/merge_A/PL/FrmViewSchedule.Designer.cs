namespace Project_Sce.PL
{
    partial class FrmViewSchedule
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Day = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CourseName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CourseID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClassRoom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Strat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.End = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Return_Button = new System.Windows.Forms.Button();
            this.PrintB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Day,
            this.ClassRoom,
            this.Type,
            this.CourseID,
            this.CourseName,
            this.Strat,
            this.End});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(509, 251);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Day
            // 
            this.Day.Text = "Day";
            this.Day.Width = 66;
            // 
            // CourseName
            // 
            this.CourseName.Text = "Course Name";
            this.CourseName.Width = 90;
            // 
            // CourseID
            // 
            this.CourseID.Text = "Course ID";
            // 
            // ClassRoom
            // 
            this.ClassRoom.Text = "Class Room";
            this.ClassRoom.Width = 74;
            // 
            // Strat
            // 
            this.Strat.Text = "Strat";
            this.Strat.Width = 65;
            // 
            // End
            // 
            this.End.Text = "End";
            this.End.Width = 84;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 65;
            // 
            // Return_Button
            // 
            this.Return_Button.Location = new System.Drawing.Point(12, 293);
            this.Return_Button.Name = "Return_Button";
            this.Return_Button.Size = new System.Drawing.Size(75, 23);
            this.Return_Button.TabIndex = 18;
            this.Return_Button.Text = "Return";
            this.Return_Button.UseVisualStyleBackColor = true;
            this.Return_Button.Click += new System.EventHandler(this.Return_Button_Click);
            // 
            // PrintB
            // 
            this.PrintB.Location = new System.Drawing.Point(422, 293);
            this.PrintB.Name = "PrintB";
            this.PrintB.Size = new System.Drawing.Size(75, 23);
            this.PrintB.TabIndex = 19;
            this.PrintB.Text = "Print";
            this.PrintB.UseVisualStyleBackColor = true;
            // 
            // FrmViewSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 385);
            this.Controls.Add(this.PrintB);
            this.Controls.Add(this.Return_Button);
            this.Controls.Add(this.listView1);
            this.Name = "FrmViewSchedule";
            this.Text = "FrmViewSchedule";
            this.Load += new System.EventHandler(this.FrmViewSchedule_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Day;
        private System.Windows.Forms.ColumnHeader CourseName;
        private System.Windows.Forms.ColumnHeader ClassRoom;
        private System.Windows.Forms.ColumnHeader Strat;
        private System.Windows.Forms.ColumnHeader End;
        private System.Windows.Forms.ColumnHeader CourseID;
        public System.Windows.Forms.Button Return_Button;
        private System.Windows.Forms.ColumnHeader Type;
        public System.Windows.Forms.Button PrintB;
    }
}