namespace WindowsFormsApp3
{
    partial class Form5
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
            this.typelabel = new System.Windows.Forms.Label();
            this.newbutton = new System.Windows.Forms.Button();
            this.usedbutton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // typelabel
            // 
            this.typelabel.AutoSize = true;
            this.typelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typelabel.Location = new System.Drawing.Point(160, 18);
            this.typelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typelabel.Name = "typelabel";
            this.typelabel.Size = new System.Drawing.Size(290, 29);
            this.typelabel.TabIndex = 0;
            this.typelabel.Text = "SELECT TYPE OF CAR";
            // 
            // newbutton
            // 
            this.newbutton.Location = new System.Drawing.Point(87, 151);
            this.newbutton.Margin = new System.Windows.Forms.Padding(2);
            this.newbutton.Name = "newbutton";
            this.newbutton.Size = new System.Drawing.Size(145, 60);
            this.newbutton.TabIndex = 1;
            this.newbutton.Text = "NEW";
            this.newbutton.UseVisualStyleBackColor = true;
            this.newbutton.Click += new System.EventHandler(this.newbutton_Click);
            // 
            // usedbutton
            // 
            this.usedbutton.Location = new System.Drawing.Point(357, 151);
            this.usedbutton.Margin = new System.Windows.Forms.Padding(2);
            this.usedbutton.Name = "usedbutton";
            this.usedbutton.Size = new System.Drawing.Size(146, 60);
            this.usedbutton.TabIndex = 2;
            this.usedbutton.Text = "USED";
            this.usedbutton.UseVisualStyleBackColor = true;
            this.usedbutton.Click += new System.EventHandler(this.usedbutton_Click);
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(260, 285);
            this.backbutton.Margin = new System.Windows.Forms.Padding(2);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(86, 34);
            this.backbutton.TabIndex = 3;
            this.backbutton.Text = "BACK";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.usedbutton);
            this.Controls.Add(this.newbutton);
            this.Controls.Add(this.typelabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label typelabel;
        private System.Windows.Forms.Button newbutton;
        private System.Windows.Forms.Button usedbutton;
        private System.Windows.Forms.Button backbutton;
    }
}