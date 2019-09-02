namespace BettingCounter {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.racetrack = new System.Windows.Forms.PictureBox();
            this.Horse1 = new System.Windows.Forms.PictureBox();
            this.Horse2 = new System.Windows.Forms.PictureBox();
            this.Horse3 = new System.Windows.Forms.PictureBox();
            this.Horse4 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MikeBet = new System.Windows.Forms.Label();
            this.RogerBet = new System.Windows.Forms.Label();
            this.JimBet = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.race = new System.Windows.Forms.Button();
            this.HorseNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.BettingAmount = new System.Windows.Forms.NumericUpDown();
            this.Bets = new System.Windows.Forms.Button();
            this.MikeRButton = new System.Windows.Forms.RadioButton();
            this.RogerRButton = new System.Windows.Forms.RadioButton();
            this.JimButton = new System.Windows.Forms.RadioButton();
            this.MaximumBet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horse1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horse2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horse3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horse4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HorseNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BettingAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // racetrack
            // 
            this.racetrack.BackColor = System.Drawing.SystemColors.Control;
            this.racetrack.Image = ((System.Drawing.Image)(resources.GetObject("racetrack.Image")));
            this.racetrack.Location = new System.Drawing.Point(-1, -79);
            this.racetrack.Margin = new System.Windows.Forms.Padding(4);
            this.racetrack.Name = "racetrack";
            this.racetrack.Size = new System.Drawing.Size(1069, 527);
            this.racetrack.TabIndex = 0;
            this.racetrack.TabStop = false;
            this.racetrack.Click += new System.EventHandler(this.Racetrack_Click);
            // 
            // Horse1
            // 
            this.Horse1.Image = ((System.Drawing.Image)(resources.GetObject("Horse1.Image")));
            this.Horse1.Location = new System.Drawing.Point(17, 4);
            this.Horse1.Margin = new System.Windows.Forms.Padding(4);
            this.Horse1.Name = "Horse1";
            this.Horse1.Size = new System.Drawing.Size(83, 57);
            this.Horse1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Horse1.TabIndex = 1;
            this.Horse1.TabStop = false;
            // 
            // Horse2
            // 
            this.Horse2.Image = ((System.Drawing.Image)(resources.GetObject("Horse2.Image")));
            this.Horse2.Location = new System.Drawing.Point(16, 124);
            this.Horse2.Margin = new System.Windows.Forms.Padding(4);
            this.Horse2.Name = "Horse2";
            this.Horse2.Size = new System.Drawing.Size(83, 57);
            this.Horse2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Horse2.TabIndex = 2;
            this.Horse2.TabStop = false;
            // 
            // Horse3
            // 
            this.Horse3.Image = ((System.Drawing.Image)(resources.GetObject("Horse3.Image")));
            this.Horse3.Location = new System.Drawing.Point(16, 258);
            this.Horse3.Margin = new System.Windows.Forms.Padding(4);
            this.Horse3.Name = "Horse3";
            this.Horse3.Size = new System.Drawing.Size(83, 57);
            this.Horse3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Horse3.TabIndex = 3;
            this.Horse3.TabStop = false;
            // 
            // Horse4
            // 
            this.Horse4.Image = ((System.Drawing.Image)(resources.GetObject("Horse4.Image")));
            this.Horse4.Location = new System.Drawing.Point(17, 366);
            this.Horse4.Margin = new System.Windows.Forms.Padding(4);
            this.Horse4.Name = "Horse4";
            this.Horse4.Size = new System.Drawing.Size(83, 57);
            this.Horse4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Horse4.TabIndex = 4;
            this.Horse4.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.MikeBet);
            this.groupBox1.Controls.Add(this.RogerBet);
            this.groupBox1.Controls.Add(this.JimBet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.race);
            this.groupBox1.Controls.Add(this.HorseNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BettingAmount);
            this.groupBox1.Controls.Add(this.Bets);
            this.groupBox1.Controls.Add(this.MikeRButton);
            this.groupBox1.Controls.Add(this.RogerRButton);
            this.groupBox1.Controls.Add(this.JimButton);
            this.groupBox1.Controls.Add(this.MaximumBet);
            this.groupBox1.Location = new System.Drawing.Point(-1, 455);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1069, 207);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Counter";
            // 
            // MikeBet
            // 
            this.MikeBet.BackColor = System.Drawing.SystemColors.Info;
            this.MikeBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MikeBet.Location = new System.Drawing.Point(649, 110);
            this.MikeBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MikeBet.Name = "MikeBet";
            this.MikeBet.Size = new System.Drawing.Size(386, 20);
            this.MikeBet.TabIndex = 13;
            this.MikeBet.Text = "label6";
            // 
            // RogerBet
            // 
            this.RogerBet.BackColor = System.Drawing.SystemColors.Info;
            this.RogerBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RogerBet.Location = new System.Drawing.Point(649, 80);
            this.RogerBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RogerBet.Name = "RogerBet";
            this.RogerBet.Size = new System.Drawing.Size(386, 20);
            this.RogerBet.TabIndex = 12;
            this.RogerBet.Text = "label5";
            // 
            // JimBet
            // 
            this.JimBet.BackColor = System.Drawing.SystemColors.Info;
            this.JimBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.JimBet.Location = new System.Drawing.Point(649, 50);
            this.JimBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JimBet.Name = "JimBet";
            this.JimBet.Size = new System.Drawing.Size(386, 20);
            this.JimBet.TabIndex = 11;
            this.JimBet.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(645, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bets";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // race
            // 
            this.race.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.race.Location = new System.Drawing.Point(856, 145);
            this.race.Margin = new System.Windows.Forms.Padding(4);
            this.race.Name = "race";
            this.race.Size = new System.Drawing.Size(180, 37);
            this.race.TabIndex = 9;
            this.race.Text = "START RACE";
            this.race.UseVisualStyleBackColor = true;
            this.race.Click += new System.EventHandler(this.race_Click);
            // 
            // HorseNumber
            // 
            this.HorseNumber.Location = new System.Drawing.Point(529, 106);
            this.HorseNumber.Margin = new System.Windows.Forms.Padding(4);
            this.HorseNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.HorseNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HorseNumber.Name = "HorseNumber";
            this.HorseNumber.Size = new System.Drawing.Size(85, 22);
            this.HorseNumber.TabIndex = 8;
            this.HorseNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Horse number";
            // 
            // BettingAmount
            // 
            this.BettingAmount.Location = new System.Drawing.Point(531, 47);
            this.BettingAmount.Margin = new System.Windows.Forms.Padding(4);
            this.BettingAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.BettingAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BettingAmount.Name = "BettingAmount";
            this.BettingAmount.Size = new System.Drawing.Size(84, 22);
            this.BettingAmount.TabIndex = 6;
            this.BettingAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Bets
            // 
            this.Bets.Location = new System.Drawing.Point(364, 37);
            this.Bets.Margin = new System.Windows.Forms.Padding(4);
            this.Bets.Name = "Bets";
            this.Bets.Size = new System.Drawing.Size(112, 44);
            this.Bets.TabIndex = 5;
            this.Bets.Text = "Place Bet";
            this.Bets.UseVisualStyleBackColor = true;
            this.Bets.Click += new System.EventHandler(this.Bets_Click);
            // 
            // MikeRButton
            // 
            this.MikeRButton.AutoSize = true;
            this.MikeRButton.Checked = true;
            this.MikeRButton.Location = new System.Drawing.Point(19, 119);
            this.MikeRButton.Margin = new System.Windows.Forms.Padding(4);
            this.MikeRButton.Name = "MikeRButton";
            this.MikeRButton.Size = new System.Drawing.Size(58, 21);
            this.MikeRButton.TabIndex = 3;
            this.MikeRButton.TabStop = true;
            this.MikeRButton.Text = "Mike";
            this.MikeRButton.UseVisualStyleBackColor = true;
            this.MikeRButton.CheckedChanged += new System.EventHandler(this.MikeButton_CheckedChanged);
            // 
            // RogerRButton
            // 
            this.RogerRButton.AutoSize = true;
            this.RogerRButton.Location = new System.Drawing.Point(19, 90);
            this.RogerRButton.Margin = new System.Windows.Forms.Padding(4);
            this.RogerRButton.Name = "RogerRButton";
            this.RogerRButton.Size = new System.Drawing.Size(68, 21);
            this.RogerRButton.TabIndex = 2;
            this.RogerRButton.Text = "Roger";
            this.RogerRButton.UseVisualStyleBackColor = true;
            this.RogerRButton.CheckedChanged += new System.EventHandler(this.RogerButton_CheckedChanged);
            // 
            // JimButton
            // 
            this.JimButton.AutoSize = true;
            this.JimButton.Location = new System.Drawing.Point(19, 60);
            this.JimButton.Margin = new System.Windows.Forms.Padding(4);
            this.JimButton.Name = "JimButton";
            this.JimButton.Size = new System.Drawing.Size(50, 21);
            this.JimButton.TabIndex = 1;
            this.JimButton.Text = "Jim";
            this.JimButton.UseVisualStyleBackColor = true;
            this.JimButton.CheckedChanged += new System.EventHandler(this.JimButton_CheckedChanged);
            // 
            // MaximumBet
            // 
            this.MaximumBet.AutoSize = true;
            this.MaximumBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumBet.Location = new System.Drawing.Point(15, 30);
            this.MaximumBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaximumBet.Name = "MaximumBet";
            this.MaximumBet.Size = new System.Drawing.Size(120, 20);
            this.MaximumBet.TabIndex = 0;
            this.MaximumBet.Text = "Maximum bet";
            this.MaximumBet.Click += new System.EventHandler(this.MaximumBet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 661);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Horse4);
            this.Controls.Add(this.Horse3);
            this.Controls.Add(this.Horse2);
            this.Controls.Add(this.Horse1);
            this.Controls.Add(this.racetrack);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Race Course";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horse1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horse2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horse3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horse4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HorseNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BettingAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox racetrack;
        private System.Windows.Forms.PictureBox Horse1;
        private System.Windows.Forms.PictureBox Horse2;
        private System.Windows.Forms.PictureBox Horse3;
        private System.Windows.Forms.PictureBox Horse4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton MikeRButton;
        private System.Windows.Forms.RadioButton RogerRButton;
        private System.Windows.Forms.RadioButton JimButton;
        private System.Windows.Forms.Label MaximumBet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown BettingAmount;
        private System.Windows.Forms.Button Bets;
        private System.Windows.Forms.NumericUpDown HorseNumber;
        private System.Windows.Forms.Button race;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label JimBet;
        private System.Windows.Forms.Label MikeBet;
        private System.Windows.Forms.Label RogerBet;
    }
}

