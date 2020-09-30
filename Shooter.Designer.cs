namespace DatabaseApp
{
    partial class Shooter
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
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.scoreLBL = new System.Windows.Forms.Label();
            this.monster = new System.Windows.Forms.PictureBox();
            this.tank = new System.Windows.Forms.PictureBox();
            this.loginTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.monster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tank)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 15;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // scoreLBL
            // 
            this.scoreLBL.AutoSize = true;
            this.scoreLBL.Location = new System.Drawing.Point(13, 13);
            this.scoreLBL.Name = "scoreLBL";
            this.scoreLBL.Size = new System.Drawing.Size(38, 13);
            this.scoreLBL.TabIndex = 2;
            this.scoreLBL.Text = "Score:";
            // 
            // monster
            // 
            this.monster.Image = global::DatabaseApp.Properties.Resources.monster;
            this.monster.Location = new System.Drawing.Point(407, 32);
            this.monster.Name = "monster";
            this.monster.Size = new System.Drawing.Size(48, 43);
            this.monster.TabIndex = 1;
            this.monster.TabStop = false;
            this.monster.Tag = "monster";
            // 
            // tank
            // 
            this.tank.Image = global::DatabaseApp.Properties.Resources.tank;
            this.tank.Location = new System.Drawing.Point(407, 363);
            this.tank.Name = "tank";
            this.tank.Size = new System.Drawing.Size(62, 80);
            this.tank.TabIndex = 0;
            this.tank.TabStop = false;
            this.tank.Tag = "tank";
            // 
            // loginTB
            // 
            this.loginTB.Location = new System.Drawing.Point(765, 13);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(100, 20);
            this.loginTB.TabIndex = 3;
            this.loginTB.Visible = false;
            // 
            // Shooter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 455);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.scoreLBL);
            this.Controls.Add(this.monster);
            this.Controls.Add(this.tank);
            this.Name = "Shooter";
            this.Text = "Shooter";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.monster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox tank;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox monster;
        private System.Windows.Forms.Label scoreLBL;
        private System.Windows.Forms.TextBox loginTB;
    }
}