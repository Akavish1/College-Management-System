namespace Project_Sce.PL
{
    partial class FrmProcLecturer
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
            this.buttonAddLecturer = new System.Windows.Forms.Button();
            this.buttonRemoveLecturer = new System.Windows.Forms.Button();
            this.buttonEditLecturer = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddLecturer
            // 
            this.buttonAddLecturer.ForeColor = System.Drawing.Color.Blue;
            this.buttonAddLecturer.Location = new System.Drawing.Point(55, 23);
            this.buttonAddLecturer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAddLecturer.Name = "buttonAddLecturer";
            this.buttonAddLecturer.Size = new System.Drawing.Size(306, 51);
            this.buttonAddLecturer.TabIndex = 0;
            this.buttonAddLecturer.Text = "Add Lecturer";
            this.buttonAddLecturer.UseVisualStyleBackColor = true;
            this.buttonAddLecturer.Click += new System.EventHandler(this.buttonAddLecturer_Click);
            // 
            // buttonRemoveLecturer
            // 
            this.buttonRemoveLecturer.ForeColor = System.Drawing.Color.Blue;
            this.buttonRemoveLecturer.Location = new System.Drawing.Point(58, 168);
            this.buttonRemoveLecturer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonRemoveLecturer.Name = "buttonRemoveLecturer";
            this.buttonRemoveLecturer.Size = new System.Drawing.Size(303, 46);
            this.buttonRemoveLecturer.TabIndex = 1;
            this.buttonRemoveLecturer.Text = "Delete Lecturer";
            this.buttonRemoveLecturer.UseVisualStyleBackColor = true;
            this.buttonRemoveLecturer.Click += new System.EventHandler(this.buttonRemoveLecturer_Click);
            // 
            // buttonEditLecturer
            // 
            this.buttonEditLecturer.ForeColor = System.Drawing.Color.Blue;
            this.buttonEditLecturer.Location = new System.Drawing.Point(58, 95);
            this.buttonEditLecturer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonEditLecturer.Name = "buttonEditLecturer";
            this.buttonEditLecturer.Size = new System.Drawing.Size(303, 50);
            this.buttonEditLecturer.TabIndex = 2;
            this.buttonEditLecturer.Text = "Edit Lecturer";
            this.buttonEditLecturer.UseVisualStyleBackColor = true;
            this.buttonEditLecturer.Click += new System.EventHandler(this.buttonEditLecturer_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.ForeColor = System.Drawing.Color.Green;
            this.ReturnButton.Location = new System.Drawing.Point(58, 236);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(303, 50);
            this.ReturnButton.TabIndex = 3;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.ForeColor = System.Drawing.Color.Red;
            this.LogoutButton.Location = new System.Drawing.Point(58, 302);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(303, 52);
            this.LogoutButton.TabIndex = 4;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // FrmProcLecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 444);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.buttonEditLecturer);
            this.Controls.Add(this.buttonRemoveLecturer);
            this.Controls.Add(this.buttonAddLecturer);
            this.Font = new System.Drawing.Font("Miriam Fixed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmProcLecturer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProcLecturer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddLecturer;
        private System.Windows.Forms.Button buttonRemoveLecturer;
        private System.Windows.Forms.Button buttonEditLecturer;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button LogoutButton;
    }
}