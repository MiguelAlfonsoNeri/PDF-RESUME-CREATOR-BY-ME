namespace PDF_RESUME_CREATOR_FINAL
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
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Location = new System.Drawing.Point(334, 208);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(113, 38);
            this.BtnGenerate.TabIndex = 0;
            this.BtnGenerate.Text = "GENERATE";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnGenerate);
            this.Name = "Form1";
            this.Text = "Pdf Resume Generator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGenerate;
    }
}

