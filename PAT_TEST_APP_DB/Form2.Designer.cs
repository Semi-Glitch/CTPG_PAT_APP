namespace PAT_TEST_APP_DB
{
    partial class formview
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
            this.pbconnection = new System.Windows.Forms.PictureBox();
            this.lblapplication = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbconnection)).BeginInit();
            this.SuspendLayout();
            // 
            // pbconnection
            // 
            this.pbconnection.BackColor = System.Drawing.Color.Red;
            this.pbconnection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbconnection.Location = new System.Drawing.Point(697, 600);
            this.pbconnection.Name = "pbconnection";
            this.pbconnection.Size = new System.Drawing.Size(12, 14);
            this.pbconnection.TabIndex = 0;
            this.pbconnection.TabStop = false;
            // 
            // lblapplication
            // 
            this.lblapplication.AutoSize = true;
            this.lblapplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapplication.Location = new System.Drawing.Point(13, 13);
            this.lblapplication.Name = "lblapplication";
            this.lblapplication.Size = new System.Drawing.Size(57, 20);
            this.lblapplication.TabIndex = 1;
            this.lblapplication.Text = "label1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(634, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // formview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 626);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblapplication);
            this.Controls.Add(this.pbconnection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.formview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbconnection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbconnection;
        private System.Windows.Forms.Label lblapplication;
        private System.Windows.Forms.Button button1;
    }
}