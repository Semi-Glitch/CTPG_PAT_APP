namespace PAT_TEST_APP_DB
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.viewbtn = new System.Windows.Forms.Button();
            this.pbconnect = new System.Windows.Forms.PictureBox();
            this.lblconnect = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.lbltitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbconnect)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 125);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Test Data";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // viewbtn
            // 
            this.viewbtn.BackColor = System.Drawing.Color.Gainsboro;
            this.viewbtn.Location = new System.Drawing.Point(9, 125);
            this.viewbtn.Margin = new System.Windows.Forms.Padding(2);
            this.viewbtn.Name = "viewbtn";
            this.viewbtn.Size = new System.Drawing.Size(90, 23);
            this.viewbtn.TabIndex = 1;
            this.viewbtn.Text = "View Test Data";
            this.viewbtn.UseVisualStyleBackColor = false;
            this.viewbtn.Click += new System.EventHandler(this.viewbtn_Click);
            // 
            // pbconnect
            // 
            this.pbconnect.BackColor = System.Drawing.Color.Red;
            this.pbconnect.Location = new System.Drawing.Point(442, 130);
            this.pbconnect.Margin = new System.Windows.Forms.Padding(2);
            this.pbconnect.Name = "pbconnect";
            this.pbconnect.Size = new System.Drawing.Size(18, 18);
            this.pbconnect.TabIndex = 2;
            this.pbconnect.TabStop = false;
            // 
            // lblconnect
            // 
            this.lblconnect.AutoSize = true;
            this.lblconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconnect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblconnect.Location = new System.Drawing.Point(332, 131);
            this.lblconnect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblconnect.Name = "lblconnect";
            this.lblconnect.Size = new System.Drawing.Size(106, 17);
            this.lblconnect.TabIndex = 3;
            this.lblconnect.Text = "Disconnected";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 38);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(452, 84);
            this.textBox1.TabIndex = 4;
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(198, 125);
            this.btnclose.Margin = new System.Windows.Forms.Padding(2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(64, 23);
            this.btnclose.TabIndex = 5;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbltitle.Location = new System.Drawing.Point(10, 11);
            this.lbltitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(74, 24);
            this.lbltitle.TabIndex = 6;
            this.lbltitle.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(469, 157);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblconnect);
            this.Controls.Add(this.pbconnect);
            this.Controls.Add(this.viewbtn);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CTPG Pat Test Application";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbconnect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button viewbtn;
        private System.Windows.Forms.PictureBox pbconnect;
        private System.Windows.Forms.Label lblconnect;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label lbltitle;
    }
}

