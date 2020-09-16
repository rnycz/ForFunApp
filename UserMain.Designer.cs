namespace DatabaseApp
{
    partial class UserMain
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
            this.powitanieLBL = new System.Windows.Forms.Label();
            this.wylogujBTN = new System.Windows.Forms.Button();
            this.offBTN = new System.Windows.Forms.Button();
            this.dodajPktBTN = new System.Windows.Forms.Button();
            this.loginBoxTB = new System.Windows.Forms.TextBox();
            this.dodatPktLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // powitanieLBL
            // 
            this.powitanieLBL.AutoSize = true;
            this.powitanieLBL.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.powitanieLBL.Location = new System.Drawing.Point(118, 14);
            this.powitanieLBL.Name = "powitanieLBL";
            this.powitanieLBL.Size = new System.Drawing.Size(62, 18);
            this.powitanieLBL.TabIndex = 0;
            this.powitanieLBL.Text = "Witam";
            // 
            // wylogujBTN
            // 
            this.wylogujBTN.BackColor = System.Drawing.Color.IndianRed;
            this.wylogujBTN.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wylogujBTN.Location = new System.Drawing.Point(701, 378);
            this.wylogujBTN.Name = "wylogujBTN";
            this.wylogujBTN.Size = new System.Drawing.Size(87, 27);
            this.wylogujBTN.TabIndex = 1;
            this.wylogujBTN.Text = "Wyloguj";
            this.wylogujBTN.UseVisualStyleBackColor = false;
            this.wylogujBTN.Click += new System.EventHandler(this.wylogujBTN_Click);
            // 
            // offBTN
            // 
            this.offBTN.BackColor = System.Drawing.Color.IndianRed;
            this.offBTN.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.offBTN.Location = new System.Drawing.Point(701, 411);
            this.offBTN.Name = "offBTN";
            this.offBTN.Size = new System.Drawing.Size(87, 27);
            this.offBTN.TabIndex = 2;
            this.offBTN.Text = "Zamknij";
            this.offBTN.UseVisualStyleBackColor = false;
            this.offBTN.Click += new System.EventHandler(this.offBTN_Click);
            // 
            // dodajPktBTN
            // 
            this.dodajPktBTN.BackColor = System.Drawing.Color.Yellow;
            this.dodajPktBTN.Enabled = false;
            this.dodajPktBTN.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajPktBTN.Location = new System.Drawing.Point(12, 411);
            this.dodajPktBTN.Name = "dodajPktBTN";
            this.dodajPktBTN.Size = new System.Drawing.Size(139, 27);
            this.dodajPktBTN.TabIndex = 3;
            this.dodajPktBTN.Text = "Nie ta pora";
            this.dodajPktBTN.UseVisualStyleBackColor = false;
            this.dodajPktBTN.Click += new System.EventHandler(this.dodajPktBTN_Click);
            // 
            // loginBoxTB
            // 
            this.loginBoxTB.Location = new System.Drawing.Point(12, 12);
            this.loginBoxTB.Name = "loginBoxTB";
            this.loginBoxTB.Size = new System.Drawing.Size(100, 20);
            this.loginBoxTB.TabIndex = 4;
            this.loginBoxTB.Visible = false;
            // 
            // dodatPktLBL
            // 
            this.dodatPktLBL.AutoSize = true;
            this.dodatPktLBL.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodatPktLBL.Location = new System.Drawing.Point(12, 373);
            this.dodatPktLBL.Name = "dodatPktLBL";
            this.dodatPktLBL.Size = new System.Drawing.Size(214, 32);
            this.dodatPktLBL.TabIndex = 5;
            this.dodatPktLBL.Text = "Zdobądź dodatkowe punkty!\r\n(Tylko w odpowiednich porach)";
            // 
            // UserMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dodatPktLBL);
            this.Controls.Add(this.loginBoxTB);
            this.Controls.Add(this.dodajPktBTN);
            this.Controls.Add(this.offBTN);
            this.Controls.Add(this.wylogujBTN);
            this.Controls.Add(this.powitanieLBL);
            this.Name = "UserMain";
            this.Text = "Profil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label powitanieLBL;
        private System.Windows.Forms.Button wylogujBTN;
        private System.Windows.Forms.Button offBTN;
        private System.Windows.Forms.Button dodajPktBTN;
        private System.Windows.Forms.TextBox loginBoxTB;
        private System.Windows.Forms.Label dodatPktLBL;
    }
}