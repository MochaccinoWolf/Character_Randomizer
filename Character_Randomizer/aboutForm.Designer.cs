namespace Character_Randomizer
{
    partial class aboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutForm));
            this.rtbAboutText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbAboutText
            // 
            this.rtbAboutText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbAboutText.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtbAboutText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbAboutText.Enabled = false;
            this.rtbAboutText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbAboutText.Location = new System.Drawing.Point(0, 0);
            this.rtbAboutText.Margin = new System.Windows.Forms.Padding(4);
            this.rtbAboutText.Name = "rtbAboutText";
            this.rtbAboutText.ReadOnly = true;
            this.rtbAboutText.Size = new System.Drawing.Size(405, 319);
            this.rtbAboutText.TabIndex = 0;
            this.rtbAboutText.TabStop = false;
            this.rtbAboutText.Text = resources.GetString("rtbAboutText.Text");
            // 
            // aboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 319);
            this.Controls.Add(this.rtbAboutText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "aboutForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "About ";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbAboutText;
    }
}