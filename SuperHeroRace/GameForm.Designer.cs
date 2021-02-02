namespace BetGame2
{
    partial class GameForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonPlaceBet = new System.Windows.Forms.Button();
            this.chooseSuperHero = new System.Windows.Forms.NumericUpDown();
            this.SelectBetAmount = new System.Windows.Forms.NumericUpDown();
            this.labelCycleNo = new System.Windows.Forms.Label();
            this.labelBet = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4Punter3 = new System.Windows.Forms.Label();
            this.label3Punter2 = new System.Windows.Forms.Label();
            this.label2Punter1 = new System.Windows.Forms.Label();
            this.punter3Radio = new System.Windows.Forms.RadioButton();
            this.punter2Radio = new System.Windows.Forms.RadioButton();
            this.punter1Radio = new System.Windows.Forms.RadioButton();
            this.panelBet = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAction = new System.Windows.Forms.Button();
            this.pictureHero5 = new System.Windows.Forms.PictureBox();
            this.pictureHero4 = new System.Windows.Forms.PictureBox();
            this.pictureHero3 = new System.Windows.Forms.PictureBox();
            this.pictureHero2 = new System.Windows.Forms.PictureBox();
            this.pictureHero1 = new System.Windows.Forms.PictureBox();
            this.pictureTracks = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chooseSuperHero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectBetAmount)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelBet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHero5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHero4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHero3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHero2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHero1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTracks)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Controls.Add(this.buttonPlaceBet);
            this.groupBox1.Controls.Add(this.chooseSuperHero);
            this.groupBox1.Controls.Add(this.SelectBetAmount);
            this.groupBox1.Controls.Add(this.labelCycleNo);
            this.groupBox1.Controls.Add(this.labelBet);
            this.groupBox1.Controls.Add(this.labelMax);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1020, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 269);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting:";
            // 
            // buttonPlaceBet
            // 
            this.buttonPlaceBet.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonPlaceBet.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlaceBet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPlaceBet.Location = new System.Drawing.Point(27, 219);
            this.buttonPlaceBet.Name = "buttonPlaceBet";
            this.buttonPlaceBet.Size = new System.Drawing.Size(301, 44);
            this.buttonPlaceBet.TabIndex = 5;
            this.buttonPlaceBet.Text = "Place Bet";
            this.buttonPlaceBet.UseVisualStyleBackColor = false;
            this.buttonPlaceBet.Click += new System.EventHandler(this.buttonPlaceBet_Click);
            // 
            // chooseSuperHero
            // 
            this.chooseSuperHero.Location = new System.Drawing.Point(327, 159);
            this.chooseSuperHero.Name = "chooseSuperHero";
            this.chooseSuperHero.Size = new System.Drawing.Size(90, 36);
            this.chooseSuperHero.TabIndex = 4;
            // 
            // SelectBetAmount
            // 
            this.SelectBetAmount.Location = new System.Drawing.Point(327, 97);
            this.SelectBetAmount.Name = "SelectBetAmount";
            this.SelectBetAmount.Size = new System.Drawing.Size(90, 36);
            this.SelectBetAmount.TabIndex = 3;
            // 
            // labelCycleNo
            // 
            this.labelCycleNo.AutoSize = true;
            this.labelCycleNo.Location = new System.Drawing.Point(22, 166);
            this.labelCycleNo.Name = "labelCycleNo";
            this.labelCycleNo.Size = new System.Drawing.Size(216, 29);
            this.labelCycleNo.TabIndex = 2;
            this.labelCycleNo.Text = "Bets on SuperHero :";
            this.labelCycleNo.Click += new System.EventHandler(this.labelCycleNo_Click);
            // 
            // labelBet
            // 
            this.labelBet.AutoSize = true;
            this.labelBet.Location = new System.Drawing.Point(22, 102);
            this.labelBet.Name = "labelBet";
            this.labelBet.Size = new System.Drawing.Size(172, 29);
            this.labelBet.TabIndex = 1;
            this.labelBet.Text = "Bet Amount : $ ";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(22, 49);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(306, 29);
            this.labelMax.TabIndex = 0;
            this.labelMax.Text = "Maximum BET Amount: $50";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.punter3Radio);
            this.groupBox2.Controls.Add(this.punter2Radio);
            this.groupBox2.Controls.Add(this.punter1Radio);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(708, 269);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Punters:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.label4Punter3);
            this.panel1.Controls.Add(this.label3Punter2);
            this.panel1.Controls.Add(this.label2Punter1);
            this.panel1.Location = new System.Drawing.Point(171, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 209);
            this.panel1.TabIndex = 13;
            // 
            // label4Punter3
            // 
            this.label4Punter3.AutoSize = true;
            this.label4Punter3.Location = new System.Drawing.Point(15, 146);
            this.label4Punter3.Name = "label4Punter3";
            this.label4Punter3.Size = new System.Drawing.Size(0, 29);
            this.label4Punter3.TabIndex = 13;
            // 
            // label3Punter2
            // 
            this.label3Punter2.AutoSize = true;
            this.label3Punter2.Location = new System.Drawing.Point(15, 79);
            this.label3Punter2.Name = "label3Punter2";
            this.label3Punter2.Size = new System.Drawing.Size(0, 29);
            this.label3Punter2.TabIndex = 11;
            // 
            // label2Punter1
            // 
            this.label2Punter1.AutoSize = true;
            this.label2Punter1.Location = new System.Drawing.Point(15, 12);
            this.label2Punter1.Name = "label2Punter1";
            this.label2Punter1.Size = new System.Drawing.Size(0, 29);
            this.label2Punter1.TabIndex = 10;
            // 
            // punter3Radio
            // 
            this.punter3Radio.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punter3Radio.Location = new System.Drawing.Point(26, 189);
            this.punter3Radio.Name = "punter3Radio";
            this.punter3Radio.Size = new System.Drawing.Size(159, 41);
            this.punter3Radio.TabIndex = 9;
            this.punter3Radio.TabStop = true;
            this.punter3Radio.Text = "Punter 3";
            this.punter3Radio.UseVisualStyleBackColor = true;
            // 
            // punter2Radio
            // 
            this.punter2Radio.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punter2Radio.Location = new System.Drawing.Point(26, 122);
            this.punter2Radio.Name = "punter2Radio";
            this.punter2Radio.Size = new System.Drawing.Size(159, 41);
            this.punter2Radio.TabIndex = 8;
            this.punter2Radio.TabStop = true;
            this.punter2Radio.Text = "Punter 2";
            this.punter2Radio.UseVisualStyleBackColor = true;
            // 
            // punter1Radio
            // 
            this.punter1Radio.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punter1Radio.Location = new System.Drawing.Point(26, 55);
            this.punter1Radio.Name = "punter1Radio";
            this.punter1Radio.Size = new System.Drawing.Size(159, 41);
            this.punter1Radio.TabIndex = 7;
            this.punter1Radio.TabStop = true;
            this.punter1Radio.Text = "Punter 1";
            this.punter1Radio.UseVisualStyleBackColor = true;
            // 
            // panelBet
            // 
            this.panelBet.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBet.Controls.Add(this.pictureBox1);
            this.panelBet.Controls.Add(this.groupBox2);
            this.panelBet.Controls.Add(this.groupBox1);
            this.panelBet.Location = new System.Drawing.Point(1, 413);
            this.panelBet.Name = "panelBet";
            this.panelBet.Size = new System.Drawing.Size(1480, 304);
            this.panelBet.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BetGame2.Properties.Resources.racebglogo;
            this.pictureBox1.Location = new System.Drawing.Point(724, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(128, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 406);
            this.label1.TabIndex = 8;
            this.label1.Text = "  S       T        A       R       T";
            // 
            // btnAction
            // 
            this.btnAction.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAction.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAction.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAction.Location = new System.Drawing.Point(641, 724);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(508, 93);
            this.btnAction.TabIndex = 6;
            this.btnAction.UseVisualStyleBackColor = false;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // pictureHero5
            // 
            this.pictureHero5.Image = global::BetGame2.Properties.Resources._5;
            this.pictureHero5.Location = new System.Drawing.Point(1, 341);
            this.pictureHero5.Name = "pictureHero5";
            this.pictureHero5.Size = new System.Drawing.Size(129, 66);
            this.pictureHero5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureHero5.TabIndex = 7;
            this.pictureHero5.TabStop = false;
            // 
            // pictureHero4
            // 
            this.pictureHero4.Image = global::BetGame2.Properties.Resources._4;
            this.pictureHero4.Location = new System.Drawing.Point(1, 260);
            this.pictureHero4.Name = "pictureHero4";
            this.pictureHero4.Size = new System.Drawing.Size(129, 66);
            this.pictureHero4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureHero4.TabIndex = 3;
            this.pictureHero4.TabStop = false;
            // 
            // pictureHero3
            // 
            this.pictureHero3.Image = global::BetGame2.Properties.Resources._3;
            this.pictureHero3.Location = new System.Drawing.Point(1, 179);
            this.pictureHero3.Name = "pictureHero3";
            this.pictureHero3.Size = new System.Drawing.Size(129, 66);
            this.pictureHero3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureHero3.TabIndex = 2;
            this.pictureHero3.TabStop = false;
            // 
            // pictureHero2
            // 
            this.pictureHero2.Image = global::BetGame2.Properties.Resources._2;
            this.pictureHero2.Location = new System.Drawing.Point(1, 89);
            this.pictureHero2.Name = "pictureHero2";
            this.pictureHero2.Size = new System.Drawing.Size(129, 66);
            this.pictureHero2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureHero2.TabIndex = 1;
            this.pictureHero2.TabStop = false;
            // 
            // pictureHero1
            // 
            this.pictureHero1.Image = global::BetGame2.Properties.Resources._1;
            this.pictureHero1.Location = new System.Drawing.Point(1, 2);
            this.pictureHero1.Name = "pictureHero1";
            this.pictureHero1.Size = new System.Drawing.Size(129, 66);
            this.pictureHero1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureHero1.TabIndex = 0;
            this.pictureHero1.TabStop = false;
            // 
            // pictureTracks
            // 
            this.pictureTracks.Image = global::BetGame2.Properties.Resources.raceTrack;
            this.pictureTracks.Location = new System.Drawing.Point(1, 1);
            this.pictureTracks.Name = "pictureTracks";
            this.pictureTracks.Size = new System.Drawing.Size(1480, 406);
            this.pictureTracks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTracks.TabIndex = 4;
            this.pictureTracks.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 828);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureHero5);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.panelBet);
            this.Controls.Add(this.pictureHero4);
            this.Controls.Add(this.pictureHero3);
            this.Controls.Add(this.pictureHero2);
            this.Controls.Add(this.pictureHero1);
            this.Controls.Add(this.pictureTracks);
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home :: BET GAME";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chooseSuperHero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectBetAmount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelBet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHero5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHero4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHero3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHero2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHero1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTracks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureHero1;
        private System.Windows.Forms.PictureBox pictureHero2;
        private System.Windows.Forms.PictureBox pictureHero3;
        private System.Windows.Forms.PictureBox pictureHero4;
        private System.Windows.Forms.PictureBox pictureTracks;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown chooseSuperHero;
        private System.Windows.Forms.NumericUpDown SelectBetAmount;
        private System.Windows.Forms.Label labelCycleNo;
        private System.Windows.Forms.Label labelBet;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton punter3Radio;
        private System.Windows.Forms.RadioButton punter2Radio;
        private System.Windows.Forms.RadioButton punter1Radio;
        private System.Windows.Forms.Panel panelBet;
        private System.Windows.Forms.PictureBox pictureHero5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3Punter2;
        private System.Windows.Forms.Label label2Punter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4Punter3;
        private System.Windows.Forms.Button buttonPlaceBet;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

