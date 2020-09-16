namespace DatabaseApp
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.rejestracjaBTN = new System.Windows.Forms.Button();
            this.zalogujBTN = new System.Windows.Forms.Button();
            this.hasloLBL = new System.Windows.Forms.Label();
            this.loginLBL = new System.Windows.Forms.Label();
            this.hasloTB = new System.Windows.Forms.TextBox();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.logowanieInfoLBL = new System.Windows.Forms.Label();
            this.offBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rejestracjaBTN
            // 
            this.rejestracjaBTN.BackColor = System.Drawing.Color.YellowGreen;
            this.rejestracjaBTN.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rejestracjaBTN.Location = new System.Drawing.Point(391, 261);
            this.rejestracjaBTN.Name = "rejestracjaBTN";
            this.rejestracjaBTN.Size = new System.Drawing.Size(87, 27);
            this.rejestracjaBTN.TabIndex = 0;
            this.rejestracjaBTN.Text = "Rejestracja";
            this.rejestracjaBTN.UseVisualStyleBackColor = false;
            this.rejestracjaBTN.Click += new System.EventHandler(this.rejestracjaBTN_Click);
            // 
            // zalogujBTN
            // 
            this.zalogujBTN.BackColor = System.Drawing.Color.YellowGreen;
            this.zalogujBTN.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zalogujBTN.Location = new System.Drawing.Point(391, 228);
            this.zalogujBTN.Name = "zalogujBTN";
            this.zalogujBTN.Size = new System.Drawing.Size(87, 27);
            this.zalogujBTN.TabIndex = 1;
            this.zalogujBTN.Text = "Zaloguj się";
            this.zalogujBTN.UseVisualStyleBackColor = false;
            this.zalogujBTN.Click += new System.EventHandler(this.zalogujBTN_Click);
            // 
            // hasloLBL
            // 
            this.hasloLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hasloLBL.AutoSize = true;
            this.hasloLBL.BackColor = System.Drawing.SystemColors.Window;
            this.hasloLBL.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hasloLBL.Location = new System.Drawing.Point(310, 200);
            this.hasloLBL.Name = "hasloLBL";
            this.hasloLBL.Size = new System.Drawing.Size(59, 18);
            this.hasloLBL.TabIndex = 15;
            this.hasloLBL.Text = "Hasło:";
            // 
            // loginLBL
            // 
            this.loginLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginLBL.AutoSize = true;
            this.loginLBL.BackColor = System.Drawing.SystemColors.Window;
            this.loginLBL.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginLBL.Location = new System.Drawing.Point(310, 171);
            this.loginLBL.Name = "loginLBL";
            this.loginLBL.Size = new System.Drawing.Size(59, 18);
            this.loginLBL.TabIndex = 13;
            this.loginLBL.Text = "Login:";
            // 
            // hasloTB
            // 
            this.hasloTB.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hasloTB.Location = new System.Drawing.Point(375, 199);
            this.hasloTB.Name = "hasloTB";
            this.hasloTB.Size = new System.Drawing.Size(116, 23);
            this.hasloTB.TabIndex = 12;
            // 
            // loginTB
            // 
            this.loginTB.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginTB.Location = new System.Drawing.Point(375, 170);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(116, 23);
            this.loginTB.TabIndex = 10;
            // 
            // logowanieInfoLBL
            // 
            this.logowanieInfoLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logowanieInfoLBL.AutoSize = true;
            this.logowanieInfoLBL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logowanieInfoLBL.Location = new System.Drawing.Point(323, 142);
            this.logowanieInfoLBL.Name = "logowanieInfoLBL";
            this.logowanieInfoLBL.Size = new System.Drawing.Size(0, 19);
            this.logowanieInfoLBL.TabIndex = 19;
            // 
            // offBTN
            // 
            this.offBTN.BackColor = System.Drawing.Color.IndianRed;
            this.offBTN.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.offBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.offBTN.Location = new System.Drawing.Point(638, 382);
            this.offBTN.Name = "offBTN";
            this.offBTN.Size = new System.Drawing.Size(87, 27);
            this.offBTN.TabIndex = 20;
            this.offBTN.Text = "Zamknij";
            this.offBTN.UseVisualStyleBackColor = false;
            this.offBTN.Click += new System.EventHandler(this.offBTN_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.offBTN);
            this.Controls.Add(this.logowanieInfoLBL);
            this.Controls.Add(this.hasloLBL);
            this.Controls.Add(this.loginLBL);
            this.Controls.Add(this.hasloTB);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.zalogujBTN);
            this.Controls.Add(this.rejestracjaBTN);
            this.Name = "MainWindow";
            this.Text = "Logowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rejestracjaBTN;
        private System.Windows.Forms.Button zalogujBTN;
        private System.Windows.Forms.Label hasloLBL;
        private System.Windows.Forms.Label loginLBL;
        private System.Windows.Forms.TextBox hasloTB;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.Label logowanieInfoLBL;
        private System.Windows.Forms.Button offBTN;
    }
}