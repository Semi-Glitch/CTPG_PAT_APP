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
            this.btn_close = new System.Windows.Forms.Button();
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
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Gray;
            this.btn_close.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_close.Location = new System.Drawing.Point(634, 571);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // formview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 626);
            this.Controls.Add(this.btn_close);
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
        private System.Windows.Forms.Button btn_close;
    }
}