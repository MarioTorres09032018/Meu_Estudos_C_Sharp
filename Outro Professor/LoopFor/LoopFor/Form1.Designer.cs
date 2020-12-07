namespace LoopFor
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
            this.BtnFor = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnFor
            // 
            this.BtnFor.Location = new System.Drawing.Point(12, 12);
            this.BtnFor.Name = "BtnFor";
            this.BtnFor.Size = new System.Drawing.Size(205, 26);
            this.BtnFor.TabIndex = 0;
            this.BtnFor.Text = "For";
            this.BtnFor.UseVisualStyleBackColor = true;
            this.BtnFor.Click += new System.EventHandler(this.BtnFor_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(197, 228);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(54, 21);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "Fechar";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnFor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnFor;
        private System.Windows.Forms.Button BtnClose;
    }
}

