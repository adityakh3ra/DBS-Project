namespace WindowsFormsApp3
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.buybutton = new System.Windows.Forms.Button();
            this.sellbutton = new System.Windows.Forms.Button();
            this.profilebutton = new System.Windows.Forms.Button();
            this.logoutbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAIN PAGE";
            // 
            // buybutton
            // 
            this.buybutton.Location = new System.Drawing.Point(76, 67);
            this.buybutton.Margin = new System.Windows.Forms.Padding(2);
            this.buybutton.Name = "buybutton";
            this.buybutton.Size = new System.Drawing.Size(112, 44);
            this.buybutton.TabIndex = 1;
            this.buybutton.Text = "BUY CAR";
            this.buybutton.UseVisualStyleBackColor = true;
            this.buybutton.Click += new System.EventHandler(this.buybutton_Click);
            // 
            // sellbutton
            // 
            this.sellbutton.Location = new System.Drawing.Point(388, 67);
            this.sellbutton.Margin = new System.Windows.Forms.Padding(2);
            this.sellbutton.Name = "sellbutton";
            this.sellbutton.Size = new System.Drawing.Size(118, 44);
            this.sellbutton.TabIndex = 2;
            this.sellbutton.Text = "SELL CAR";
            this.sellbutton.UseVisualStyleBackColor = true;
            this.sellbutton.Click += new System.EventHandler(this.sellbutton_Click);
            // 
            // profilebutton
            // 
            this.profilebutton.Location = new System.Drawing.Point(76, 272);
            this.profilebutton.Margin = new System.Windows.Forms.Padding(2);
            this.profilebutton.Name = "profilebutton";
            this.profilebutton.Size = new System.Drawing.Size(112, 41);
            this.profilebutton.TabIndex = 3;
            this.profilebutton.Text = "PROFILE";
            this.profilebutton.UseVisualStyleBackColor = true;
            this.profilebutton.Click += new System.EventHandler(this.profilebutton_Click);
            // 
            // logoutbutton
            // 
            this.logoutbutton.Location = new System.Drawing.Point(388, 272);
            this.logoutbutton.Margin = new System.Windows.Forms.Padding(2);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(118, 41);
            this.logoutbutton.TabIndex = 4;
            this.logoutbutton.Text = "LOGOUT";
            this.logoutbutton.UseVisualStyleBackColor = true;
            this.logoutbutton.Click += new System.EventHandler(this.logoutbutton_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(580, 366);
            this.Controls.Add(this.logoutbutton);
            this.Controls.Add(this.profilebutton);
            this.Controls.Add(this.sellbutton);
            this.Controls.Add(this.buybutton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buybutton;
        private System.Windows.Forms.Button sellbutton;
        private System.Windows.Forms.Button profilebutton;
        private System.Windows.Forms.Button logoutbutton;
    }
}