namespace WindowsFormsApplication2
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
            this.buttonGetDataDir = new System.Windows.Forms.Button();
            this.textboxGetDataDir = new System.Windows.Forms.TextBox();
            this.groupboxGetDataDir = new System.Windows.Forms.GroupBox();
            this.buttonRedate = new System.Windows.Forms.Button();
            this.dialogGetDataDir = new System.Windows.Forms.FolderBrowserDialog();
            this.groupboxGetDataDir.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGetDataDir
            // 
            this.buttonGetDataDir.Location = new System.Drawing.Point(13, 29);
            this.buttonGetDataDir.Name = "buttonGetDataDir";
            this.buttonGetDataDir.Size = new System.Drawing.Size(75, 23);
            this.buttonGetDataDir.TabIndex = 0;
            this.buttonGetDataDir.Text = "Open...";
            this.buttonGetDataDir.UseVisualStyleBackColor = true;
            this.buttonGetDataDir.Click += new System.EventHandler(this.button1_Click);
            // 
            // textboxGetDataDir
            // 
            this.textboxGetDataDir.Location = new System.Drawing.Point(101, 31);
            this.textboxGetDataDir.Name = "textboxGetDataDir";
            this.textboxGetDataDir.Size = new System.Drawing.Size(375, 20);
            this.textboxGetDataDir.TabIndex = 1;
            // 
            // groupboxGetDataDir
            // 
            this.groupboxGetDataDir.Controls.Add(this.textboxGetDataDir);
            this.groupboxGetDataDir.Controls.Add(this.buttonGetDataDir);
            this.groupboxGetDataDir.Location = new System.Drawing.Point(12, 12);
            this.groupboxGetDataDir.Name = "groupboxGetDataDir";
            this.groupboxGetDataDir.Size = new System.Drawing.Size(494, 74);
            this.groupboxGetDataDir.TabIndex = 2;
            this.groupboxGetDataDir.TabStop = false;
            this.groupboxGetDataDir.Text = "Get Data Directory";
            this.groupboxGetDataDir.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonRedate
            // 
            this.buttonRedate.Location = new System.Drawing.Point(431, 92);
            this.buttonRedate.Name = "buttonRedate";
            this.buttonRedate.Size = new System.Drawing.Size(75, 23);
            this.buttonRedate.TabIndex = 2;
            this.buttonRedate.Text = "Redate!";
            this.buttonRedate.UseVisualStyleBackColor = true;
            this.buttonRedate.Click += new System.EventHandler(this.buttonRedate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 124);
            this.Controls.Add(this.buttonRedate);
            this.Controls.Add(this.groupboxGetDataDir);
            this.Name = "Form1";
            this.Text = "Fallout 4 - Bethesda Masters Redate";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupboxGetDataDir.ResumeLayout(false);
            this.groupboxGetDataDir.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGetDataDir;
        private System.Windows.Forms.TextBox textboxGetDataDir;
        private System.Windows.Forms.GroupBox groupboxGetDataDir;
        private System.Windows.Forms.Button buttonRedate;
        private System.Windows.Forms.FolderBrowserDialog dialogGetDataDir;
    }
}

