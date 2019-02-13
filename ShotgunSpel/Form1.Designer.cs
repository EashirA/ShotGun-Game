namespace ShotgunSpel
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
            this.btnSkjuta = new System.Windows.Forms.Button();
            this.lblPlayerWins = new System.Windows.Forms.Label();
            this.lblAIWinsCount = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPlayerWinsCount = new System.Windows.Forms.Label();
            this.lblComputer = new System.Windows.Forms.Label();
            this.btnLadda = new System.Windows.Forms.Button();
            this.btnBlocka = new System.Windows.Forms.Button();
            this.btnShotgun = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lblPlayerAmmo = new System.Windows.Forms.Label();
            this.lblAIAmmo = new System.Windows.Forms.Label();
            this.lblAIWins = new System.Windows.Forms.Label();
            this.lblPlayerAmmoCount = new System.Windows.Forms.Label();
            this.lblAIAmmoCount = new System.Windows.Forms.Label();
            this.picBoxVs = new System.Windows.Forms.PictureBox();
            this.picBoxComputerAction = new System.Windows.Forms.PictureBox();
            this.picBoxPlayerAction = new System.Windows.Forms.PictureBox();
            this.picBoxComputer = new System.Windows.Forms.PictureBox();
            this.picBoxPlayer = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxVs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxComputerAction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayerAction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSkjuta
            // 
            this.btnSkjuta.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSkjuta.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkjuta.Location = new System.Drawing.Point(557, 513);
            this.btnSkjuta.Name = "btnSkjuta";
            this.btnSkjuta.Size = new System.Drawing.Size(102, 52);
            this.btnSkjuta.TabIndex = 1;
            this.btnSkjuta.Text = "Skjuta";
            this.btnSkjuta.UseVisualStyleBackColor = false;
            this.btnSkjuta.Click += new System.EventHandler(this.btnSkjuta_Click);
            // 
            // lblPlayerWins
            // 
            this.lblPlayerWins.AutoSize = true;
            this.lblPlayerWins.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerWins.Location = new System.Drawing.Point(166, 205);
            this.lblPlayerWins.Name = "lblPlayerWins";
            this.lblPlayerWins.Size = new System.Drawing.Size(53, 21);
            this.lblPlayerWins.TabIndex = 2;
            this.lblPlayerWins.Text = "Wins";
            // 
            // lblAIWinsCount
            // 
            this.lblAIWinsCount.AutoSize = true;
            this.lblAIWinsCount.BackColor = System.Drawing.Color.LightGray;
            this.lblAIWinsCount.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAIWinsCount.ForeColor = System.Drawing.Color.Blue;
            this.lblAIWinsCount.Location = new System.Drawing.Point(1040, 205);
            this.lblAIWinsCount.Name = "lblAIWinsCount";
            this.lblAIWinsCount.Size = new System.Drawing.Size(21, 21);
            this.lblAIWinsCount.TabIndex = 2;
            this.lblAIWinsCount.Text = "0";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.MistyRose;
            this.lblName.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(166, 148);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(81, 21);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Player";
            // 
            // lblPlayerWinsCount
            // 
            this.lblPlayerWinsCount.AutoSize = true;
            this.lblPlayerWinsCount.BackColor = System.Drawing.Color.LightGray;
            this.lblPlayerWinsCount.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerWinsCount.ForeColor = System.Drawing.Color.Blue;
            this.lblPlayerWinsCount.Location = new System.Drawing.Point(236, 205);
            this.lblPlayerWinsCount.Name = "lblPlayerWinsCount";
            this.lblPlayerWinsCount.Size = new System.Drawing.Size(21, 21);
            this.lblPlayerWinsCount.TabIndex = 2;
            this.lblPlayerWinsCount.Text = "0";
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.BackColor = System.Drawing.Color.LightBlue;
            this.lblComputer.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputer.Location = new System.Drawing.Point(970, 148);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(105, 21);
            this.lblComputer.TabIndex = 2;
            this.lblComputer.Text = "Computer";
            // 
            // btnLadda
            // 
            this.btnLadda.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLadda.Location = new System.Drawing.Point(416, 509);
            this.btnLadda.Name = "btnLadda";
            this.btnLadda.Size = new System.Drawing.Size(102, 56);
            this.btnLadda.TabIndex = 1;
            this.btnLadda.Text = "Ladda";
            this.btnLadda.UseVisualStyleBackColor = true;
            this.btnLadda.Click += new System.EventHandler(this.btnLadda_Click);
            // 
            // btnBlocka
            // 
            this.btnBlocka.BackColor = System.Drawing.Color.PaleGreen;
            this.btnBlocka.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlocka.Location = new System.Drawing.Point(692, 511);
            this.btnBlocka.Name = "btnBlocka";
            this.btnBlocka.Size = new System.Drawing.Size(102, 52);
            this.btnBlocka.TabIndex = 1;
            this.btnBlocka.Text = "Blocka";
            this.btnBlocka.UseVisualStyleBackColor = false;
            this.btnBlocka.Click += new System.EventHandler(this.btnBlocka_Click);
            // 
            // btnShotgun
            // 
            this.btnShotgun.BackColor = System.Drawing.Color.Khaki;
            this.btnShotgun.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShotgun.Location = new System.Drawing.Point(557, 505);
            this.btnShotgun.Name = "btnShotgun";
            this.btnShotgun.Size = new System.Drawing.Size(102, 61);
            this.btnShotgun.TabIndex = 1;
            this.btnShotgun.Text = "Shotgun";
            this.btnShotgun.UseVisualStyleBackColor = false;
            this.btnShotgun.Click += new System.EventHandler(this.btnShotgun_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnHelp.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(1178, 12);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(63, 30);
            this.btnHelp.TabIndex = 1;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lblPlayerAmmo
            // 
            this.lblPlayerAmmo.AutoSize = true;
            this.lblPlayerAmmo.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerAmmo.Location = new System.Drawing.Point(166, 507);
            this.lblPlayerAmmo.Name = "lblPlayerAmmo";
            this.lblPlayerAmmo.Size = new System.Drawing.Size(64, 21);
            this.lblPlayerAmmo.TabIndex = 2;
            this.lblPlayerAmmo.Text = "Ammo";
            // 
            // lblAIAmmo
            // 
            this.lblAIAmmo.AutoSize = true;
            this.lblAIAmmo.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAIAmmo.Location = new System.Drawing.Point(971, 505);
            this.lblAIAmmo.Name = "lblAIAmmo";
            this.lblAIAmmo.Size = new System.Drawing.Size(64, 21);
            this.lblAIAmmo.TabIndex = 2;
            this.lblAIAmmo.Text = "Ammo";
            // 
            // lblAIWins
            // 
            this.lblAIWins.AutoSize = true;
            this.lblAIWins.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAIWins.Location = new System.Drawing.Point(971, 205);
            this.lblAIWins.Name = "lblAIWins";
            this.lblAIWins.Size = new System.Drawing.Size(53, 21);
            this.lblAIWins.TabIndex = 2;
            this.lblAIWins.Text = "Wins";
            // 
            // lblPlayerAmmoCount
            // 
            this.lblPlayerAmmoCount.AutoSize = true;
            this.lblPlayerAmmoCount.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerAmmoCount.ForeColor = System.Drawing.Color.Red;
            this.lblPlayerAmmoCount.Location = new System.Drawing.Point(249, 505);
            this.lblPlayerAmmoCount.Name = "lblPlayerAmmoCount";
            this.lblPlayerAmmoCount.Size = new System.Drawing.Size(21, 21);
            this.lblPlayerAmmoCount.TabIndex = 2;
            this.lblPlayerAmmoCount.Text = "0";
            // 
            // lblAIAmmoCount
            // 
            this.lblAIAmmoCount.AutoSize = true;
            this.lblAIAmmoCount.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAIAmmoCount.ForeColor = System.Drawing.Color.Red;
            this.lblAIAmmoCount.Location = new System.Drawing.Point(1054, 505);
            this.lblAIAmmoCount.Name = "lblAIAmmoCount";
            this.lblAIAmmoCount.Size = new System.Drawing.Size(21, 21);
            this.lblAIAmmoCount.TabIndex = 2;
            this.lblAIAmmoCount.Text = "0";
            // 
            // picBoxVs
            // 
            this.picBoxVs.Image = global::ShotgunSpel.Properties.Resources.Vs;
            this.picBoxVs.Location = new System.Drawing.Point(586, 354);
            this.picBoxVs.Name = "picBoxVs";
            this.picBoxVs.Size = new System.Drawing.Size(44, 36);
            this.picBoxVs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxVs.TabIndex = 5;
            this.picBoxVs.TabStop = false;
            // 
            // picBoxComputerAction
            // 
            this.picBoxComputerAction.Image = global::ShotgunSpel.Properties.Resources.untitled;
            this.picBoxComputerAction.Location = new System.Drawing.Point(784, 309);
            this.picBoxComputerAction.Name = "picBoxComputerAction";
            this.picBoxComputerAction.Size = new System.Drawing.Size(173, 124);
            this.picBoxComputerAction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxComputerAction.TabIndex = 4;
            this.picBoxComputerAction.TabStop = false;
            // 
            // picBoxPlayerAction
            // 
            this.picBoxPlayerAction.Image = global::ShotgunSpel.Properties.Resources.letsPlay;
            this.picBoxPlayerAction.Location = new System.Drawing.Point(291, 309);
            this.picBoxPlayerAction.Name = "picBoxPlayerAction";
            this.picBoxPlayerAction.Size = new System.Drawing.Size(173, 124);
            this.picBoxPlayerAction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPlayerAction.TabIndex = 3;
            this.picBoxPlayerAction.TabStop = false;
            // 
            // picBoxComputer
            // 
            this.picBoxComputer.Image = global::ShotgunSpel.Properties.Resources.Computer;
            this.picBoxComputer.Location = new System.Drawing.Point(975, 271);
            this.picBoxComputer.Name = "picBoxComputer";
            this.picBoxComputer.Size = new System.Drawing.Size(100, 218);
            this.picBoxComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxComputer.TabIndex = 0;
            this.picBoxComputer.TabStop = false;
            // 
            // picBoxPlayer
            // 
            this.picBoxPlayer.Image = global::ShotgunSpel.Properties.Resources.player;
            this.picBoxPlayer.Location = new System.Drawing.Point(170, 271);
            this.picBoxPlayer.Name = "picBoxPlayer";
            this.picBoxPlayer.Size = new System.Drawing.Size(100, 218);
            this.picBoxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPlayer.TabIndex = 0;
            this.picBoxPlayer.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Green;
            this.btnPlay.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(12, 12);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(152, 30);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "Play Again";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExit.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1166, 603);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 30);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ShotgunSpel.Properties.Resources.Background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1253, 645);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.picBoxVs);
            this.Controls.Add(this.picBoxComputerAction);
            this.Controls.Add(this.picBoxPlayerAction);
            this.Controls.Add(this.lblComputer);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAIAmmoCount);
            this.Controls.Add(this.lblPlayerAmmoCount);
            this.Controls.Add(this.lblPlayerWinsCount);
            this.Controls.Add(this.lblAIWinsCount);
            this.Controls.Add(this.lblAIWins);
            this.Controls.Add(this.lblAIAmmo);
            this.Controls.Add(this.lblPlayerAmmo);
            this.Controls.Add(this.lblPlayerWins);
            this.Controls.Add(this.btnShotgun);
            this.Controls.Add(this.btnBlocka);
            this.Controls.Add(this.btnLadda);
            this.Controls.Add(this.btnSkjuta);
            this.Controls.Add(this.picBoxComputer);
            this.Controls.Add(this.picBoxPlayer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxVs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxComputerAction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayerAction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxPlayer;
        private System.Windows.Forms.PictureBox picBoxComputer;
        private System.Windows.Forms.Button btnSkjuta;
        private System.Windows.Forms.Label lblPlayerWins;
        private System.Windows.Forms.Label lblAIWinsCount;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPlayerWinsCount;
        private System.Windows.Forms.Label lblComputer;
        private System.Windows.Forms.Button btnLadda;
        private System.Windows.Forms.Button btnBlocka;
        private System.Windows.Forms.Button btnShotgun;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.PictureBox picBoxPlayerAction;
        private System.Windows.Forms.PictureBox picBoxComputerAction;
        private System.Windows.Forms.Label lblPlayerAmmo;
        private System.Windows.Forms.Label lblAIAmmo;
        private System.Windows.Forms.Label lblAIWins;
        private System.Windows.Forms.Label lblPlayerAmmoCount;
        private System.Windows.Forms.Label lblAIAmmoCount;
        private System.Windows.Forms.PictureBox picBoxVs;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnExit;
    }
}

