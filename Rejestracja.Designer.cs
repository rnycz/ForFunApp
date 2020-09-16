namespace DatabaseApp
{
    partial class Rejestracja
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rejestracja));
            this.rejestracjaBTN = new System.Windows.Forms.Button();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.hasloTB = new System.Windows.Forms.TextBox();
            this.loginLBL = new System.Windows.Forms.Label();
            this.emailLBL = new System.Windows.Forms.Label();
            this.hasloLBL = new System.Windows.Forms.Label();
            this.loginInfoLBL = new System.Windows.Forms.Label();
            this.emailInfoLBL = new System.Windows.Forms.Label();
            this.hasloInfoLBL = new System.Windows.Forms.Label();
            this.logowanieBTN = new System.Windows.Forms.Button();
            this.offBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rejestracjaBTN
            // 
            this.rejestracjaBTN.BackColor = System.Drawing.Color.YellowGreen;
            this.rejestracjaBTN.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rejestracjaBTN.Location = new System.Drawing.Point(394, 256);
            this.rejestracjaBTN.Name = "rejestracjaBTN";
            this.rejestracjaBTN.Size = new System.Drawing.Size(87, 27);
            this.rejestracjaBTN.TabIndex = 0;
            this.rejestracjaBTN.Text = "Zarejestruj";
            this.rejestracjaBTN.UseVisualStyleBackColor = false;
            this.rejestracjaBTN.Click += new System.EventHandler(this.rejestracjaBTN_Click);
            // 
            // loginTB
            // 
            this.loginTB.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginTB.Location = new System.Drawing.Point(375, 170);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(116, 23);
            this.loginTB.TabIndex = 1;
            // 
            // emailTB
            // 
            this.emailTB.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailTB.Location = new System.Drawing.Point(375, 198);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(116, 23);
            this.emailTB.TabIndex = 2;
            // 
            // hasloTB
            // 
            this.hasloTB.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hasloTB.Location = new System.Drawing.Point(375, 228);
            this.hasloTB.Name = "hasloTB";
            this.hasloTB.Size = new System.Drawing.Size(116, 23);
            this.hasloTB.TabIndex = 3;
            // 
            // loginLBL
            // 
            this.loginLBL.AutoSize = true;
            this.loginLBL.BackColor = System.Drawing.SystemColors.Window;
            this.loginLBL.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginLBL.Location = new System.Drawing.Point(310, 170);
            this.loginLBL.Name = "loginLBL";
            this.loginLBL.Size = new System.Drawing.Size(59, 18);
            this.loginLBL.TabIndex = 4;
            this.loginLBL.Text = "Login:";
            // 
            // emailLBL
            // 
            this.emailLBL.AutoSize = true;
            this.emailLBL.BackColor = System.Drawing.SystemColors.Window;
            this.emailLBL.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailLBL.Location = new System.Drawing.Point(302, 199);
            this.emailLBL.Name = "emailLBL";
            this.emailLBL.Size = new System.Drawing.Size(67, 18);
            this.emailLBL.TabIndex = 5;
            this.emailLBL.Text = "E-mail:";
            // 
            // hasloLBL
            // 
            this.hasloLBL.AutoSize = true;
            this.hasloLBL.BackColor = System.Drawing.SystemColors.Window;
            this.hasloLBL.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hasloLBL.Location = new System.Drawing.Point(310, 228);
            this.hasloLBL.Name = "hasloLBL";
            this.hasloLBL.Size = new System.Drawing.Size(59, 18);
            this.hasloLBL.TabIndex = 6;
            this.hasloLBL.Text = "Hasło:";
            // 
            // loginInfoLBL
            // 
            this.loginInfoLBL.AutoSize = true;
            this.loginInfoLBL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginInfoLBL.Location = new System.Drawing.Point(509, 170);
            this.loginInfoLBL.Name = "loginInfoLBL";
            this.loginInfoLBL.Size = new System.Drawing.Size(0, 19);
            this.loginInfoLBL.TabIndex = 7;
            // 
            // emailInfoLBL
            // 
            this.emailInfoLBL.AutoSize = true;
            this.emailInfoLBL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailInfoLBL.Location = new System.Drawing.Point(509, 199);
            this.emailInfoLBL.Name = "emailInfoLBL";
            this.emailInfoLBL.Size = new System.Drawing.Size(0, 19);
            this.emailInfoLBL.TabIndex = 8;
            // 
            // hasloInfoLBL
            // 
            this.hasloInfoLBL.AutoSize = true;
            this.hasloInfoLBL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hasloInfoLBL.Location = new System.Drawing.Point(509, 229);
            this.hasloInfoLBL.Name = "hasloInfoLBL";
            this.hasloInfoLBL.Size = new System.Drawing.Size(0, 19);
            this.hasloInfoLBL.TabIndex = 9;
            // 
            // logowanieBTN
            // 
            this.logowanieBTN.BackColor = System.Drawing.Color.YellowGreen;
            this.logowanieBTN.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logowanieBTN.Location = new System.Drawing.Point(394, 289);
            this.logowanieBTN.Name = "logowanieBTN";
            this.logowanieBTN.Size = new System.Drawing.Size(87, 27);
            this.logowanieBTN.TabIndex = 10;
            this.logowanieBTN.Text = "Logowanie";
            this.logowanieBTN.UseVisualStyleBackColor = false;
            this.logowanieBTN.Click += new System.EventHandler(this.logowanieBTN_Click);
            // 
            // offBTN
            // 
            this.offBTN.BackColor = System.Drawing.Color.IndianRed;
            this.offBTN.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.offBTN.Location = new System.Drawing.Point(638, 382);
            this.offBTN.Name = "offBTN";
            this.offBTN.Size = new System.Drawing.Size(87, 27);
            this.offBTN.TabIndex = 11;
            this.offBTN.Text = "Zamknij";
            this.offBTN.UseVisualStyleBackColor = false;
            this.offBTN.Click += new System.EventHandler(this.offBTN_Click);
            // 
            // Rejestracja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.offBTN);
            this.Controls.Add(this.logowanieBTN);
            this.Controls.Add(this.hasloInfoLBL);
            this.Controls.Add(this.emailInfoLBL);
            this.Controls.Add(this.loginInfoLBL);
            this.Controls.Add(this.hasloLBL);
            this.Controls.Add(this.emailLBL);
            this.Controls.Add(this.loginLBL);
            this.Controls.Add(this.hasloTB);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.rejestracjaBTN);
            this.Name = "Rejestracja";
            this.Text = "Rejestracja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rejestracjaBTN;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.TextBox hasloTB;
        private System.Windows.Forms.Label loginLBL;
        private System.Windows.Forms.Label emailLBL;
        private System.Windows.Forms.Label hasloLBL;
        private System.Windows.Forms.Label loginInfoLBL;
        private System.Windows.Forms.Label emailInfoLBL;
        private System.Windows.Forms.Label hasloInfoLBL;
        private System.Windows.Forms.Button logowanieBTN;
        private System.Windows.Forms.Button offBTN;
    }
}

