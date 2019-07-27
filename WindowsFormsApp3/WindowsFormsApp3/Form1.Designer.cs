namespace WindowsFormsApp3
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
            System.Windows.Forms.Button loginButton1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.registerButton2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            loginButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginButton1
            // 
            loginButton1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            loginButton1.ForeColor = System.Drawing.SystemColors.Highlight;
            loginButton1.Location = new System.Drawing.Point(109, 201);
            loginButton1.Margin = new System.Windows.Forms.Padding(2);
            loginButton1.Name = "loginButton1";
            loginButton1.Size = new System.Drawing.Size(134, 72);
            loginButton1.TabIndex = 1;
            loginButton1.Text = "Login";
            loginButton1.UseVisualStyleBackColor = true;
            loginButton1.Click += new System.EventHandler(this.loginButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Dealers";
            // 
            // registerButton2
            // 
            this.registerButton2.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.registerButton2.Location = new System.Drawing.Point(429, 201);
            this.registerButton2.Margin = new System.Windows.Forms.Padding(2);
            this.registerButton2.Name = "registerButton2";
            this.registerButton2.Size = new System.Drawing.Size(136, 72);
            this.registerButton2.TabIndex = 2;
            this.registerButton2.Text = "Register";
            this.registerButton2.UseVisualStyleBackColor = true;
            this.registerButton2.Click += new System.EventHandler(this.registerButton2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(538, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "I AM AN EMPLOYEE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(685, 379);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.registerButton2);
            this.Controls.Add(loginButton1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button registerButton2;
        private System.Windows.Forms.Button button1;
    }
}

