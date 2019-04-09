namespace UseWebApiExample
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
            this.rtbGetData = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbGetData
            // 
            this.rtbGetData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbGetData.Location = new System.Drawing.Point(0, 0);
            this.rtbGetData.Name = "rtbGetData";
            this.rtbGetData.Size = new System.Drawing.Size(546, 351);
            this.rtbGetData.TabIndex = 0;
            this.rtbGetData.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 351);
            this.Controls.Add(this.rtbGetData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbGetData;
    }
}

