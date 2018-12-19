namespace Project_Sce.PL
{
    partial class FrmCourses
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
            this.AddCoursebtn = new System.Windows.Forms.Button();
            this.DelCoursebtn = new System.Windows.Forms.Button();
            this.Return_Button = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddCoursebtn
            // 
            this.AddCoursebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCoursebtn.ForeColor = System.Drawing.Color.Navy;
            this.AddCoursebtn.Location = new System.Drawing.Point(116, 71);
            this.AddCoursebtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddCoursebtn.Name = "AddCoursebtn";
            this.AddCoursebtn.Size = new System.Drawing.Size(121, 50);
            this.AddCoursebtn.TabIndex = 0;
            this.AddCoursebtn.Text = "Add Course";
            this.AddCoursebtn.UseVisualStyleBackColor = true;
            this.AddCoursebtn.Click += new System.EventHandler(this.AddCoursebtn_Click);
            // 
            // DelCoursebtn
            // 
            this.DelCoursebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelCoursebtn.ForeColor = System.Drawing.Color.Navy;
            this.DelCoursebtn.Location = new System.Drawing.Point(355, 71);
            this.DelCoursebtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DelCoursebtn.Name = "DelCoursebtn";
            this.DelCoursebtn.Size = new System.Drawing.Size(119, 50);
            this.DelCoursebtn.TabIndex = 1;
            this.DelCoursebtn.Text = "Delete Course";
            this.DelCoursebtn.UseVisualStyleBackColor = true;
            this.DelCoursebtn.Click += new System.EventHandler(this.DelCoursebtn_Click);
            // 
            // Return_Button
            // 
            this.Return_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return_Button.ForeColor = System.Drawing.Color.Green;
            this.Return_Button.Location = new System.Drawing.Point(116, 218);
            this.Return_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Return_Button.Name = "Return_Button";
            this.Return_Button.Size = new System.Drawing.Size(121, 44);
            this.Return_Button.TabIndex = 2;
            this.Return_Button.Text = "Return";
            this.Return_Button.UseVisualStyleBackColor = true;
            this.Return_Button.Click += new System.EventHandler(this.Return_Button_Click);
            // 
            // LogOut
            // 
            this.LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.ForeColor = System.Drawing.Color.Red;
            this.LogOut.Location = new System.Drawing.Point(355, 218);
            this.LogOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(112, 44);
            this.LogOut.TabIndex = 3;
            this.LogOut.Text = "Logout";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // FrmCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 331);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.Return_Button);
            this.Controls.Add(this.DelCoursebtn);
            this.Controls.Add(this.AddCoursebtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCourses";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddCoursebtn;
        private System.Windows.Forms.Button DelCoursebtn;
        private System.Windows.Forms.Button Return_Button;
        private System.Windows.Forms.Button LogOut;
    }
}