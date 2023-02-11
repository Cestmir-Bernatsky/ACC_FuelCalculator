
namespace ACCFuelCalc
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.hoursLeft = new System.Windows.Forms.TextBox();
            this.LapTimesMin = new System.Windows.Forms.TextBox();
            this.FuelConsumption = new System.Windows.Forms.TextBox();
            this.TimeLeft_label = new System.Windows.Forms.Label();
            this.LapTimes_label = new System.Windows.Forms.Label();
            this.FuelConsumption_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Calc_btn = new System.Windows.Forms.Button();
            this.minutesLeft = new System.Windows.Forms.TextBox();
            this.secondsLeft = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LapTimesSec = new System.Windows.Forms.TextBox();
            this.LapTimesMiliSec = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // hoursLeft
            // 
            this.hoursLeft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.hoursLeft.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hoursLeft.Location = new System.Drawing.Point(397, 98);
            this.hoursLeft.Margin = new System.Windows.Forms.Padding(5);
            this.hoursLeft.Name = "hoursLeft";
            this.hoursLeft.Size = new System.Drawing.Size(72, 29);
            this.hoursLeft.TabIndex = 0;
            this.hoursLeft.TextChanged += new System.EventHandler(this.hoursLeft_TextChanged);
            // 
            // LapTimesMin
            // 
            this.LapTimesMin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LapTimesMin.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LapTimesMin.Location = new System.Drawing.Point(397, 182);
            this.LapTimesMin.Margin = new System.Windows.Forms.Padding(5);
            this.LapTimesMin.Name = "LapTimesMin";
            this.LapTimesMin.Size = new System.Drawing.Size(72, 29);
            this.LapTimesMin.TabIndex = 1;
            this.LapTimesMin.TextChanged += new System.EventHandler(this.LapTimesMin_TextChanged);
            // 
            // FuelConsumption
            // 
            this.FuelConsumption.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FuelConsumption.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FuelConsumption.Location = new System.Drawing.Point(397, 262);
            this.FuelConsumption.Margin = new System.Windows.Forms.Padding(5);
            this.FuelConsumption.Name = "FuelConsumption";
            this.FuelConsumption.Size = new System.Drawing.Size(72, 29);
            this.FuelConsumption.TabIndex = 2;
            this.FuelConsumption.TextChanged += new System.EventHandler(this.FuelConsumption_TextChanged);
            // 
            // TimeLeft_label
            // 
            this.TimeLeft_label.AutoSize = true;
            this.TimeLeft_label.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TimeLeft_label.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TimeLeft_label.Location = new System.Drawing.Point(185, 99);
            this.TimeLeft_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TimeLeft_label.Name = "TimeLeft_label";
            this.TimeLeft_label.Size = new System.Drawing.Size(156, 26);
            this.TimeLeft_label.TabIndex = 3;
            this.TimeLeft_label.Text = "Time Remaining";
            // 
            // LapTimes_label
            // 
            this.LapTimes_label.AutoSize = true;
            this.LapTimes_label.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LapTimes_label.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LapTimes_label.Location = new System.Drawing.Point(238, 182);
            this.LapTimes_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LapTimes_label.Name = "LapTimes_label";
            this.LapTimes_label.Size = new System.Drawing.Size(103, 26);
            this.LapTimes_label.TabIndex = 4;
            this.LapTimes_label.Text = "Lap Times";
            // 
            // FuelConsumption_label
            // 
            this.FuelConsumption_label.AutoSize = true;
            this.FuelConsumption_label.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FuelConsumption_label.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FuelConsumption_label.Location = new System.Drawing.Point(170, 261);
            this.FuelConsumption_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.FuelConsumption_label.Name = "FuelConsumption_label";
            this.FuelConsumption_label.Size = new System.Drawing.Size(196, 26);
            this.FuelConsumption_label.TabIndex = 5;
            this.FuelConsumption_label.Text = "Fuel Consumption (l)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(225, 465);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 23);
            this.label1.TabIndex = 6;
            // 
            // Calc_btn
            // 
            this.Calc_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.Calc_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Calc_btn.FlatAppearance.BorderSize = 0;
            this.Calc_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calc_btn.ForeColor = System.Drawing.Color.Aquamarine;
            this.Calc_btn.Location = new System.Drawing.Point(225, 546);
            this.Calc_btn.Margin = new System.Windows.Forms.Padding(5);
            this.Calc_btn.Name = "Calc_btn";
            this.Calc_btn.Size = new System.Drawing.Size(280, 52);
            this.Calc_btn.TabIndex = 7;
            this.Calc_btn.Text = "Calculate";
            this.Calc_btn.UseVisualStyleBackColor = false;
            this.Calc_btn.Click += new System.EventHandler(this.Calc_btn_Click);
            // 
            // minutesLeft
            // 
            this.minutesLeft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.minutesLeft.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minutesLeft.Location = new System.Drawing.Point(482, 98);
            this.minutesLeft.Margin = new System.Windows.Forms.Padding(5);
            this.minutesLeft.Name = "minutesLeft";
            this.minutesLeft.Size = new System.Drawing.Size(72, 29);
            this.minutesLeft.TabIndex = 8;
            this.minutesLeft.TextChanged += new System.EventHandler(this.minutesLeft_TextChanged);
            // 
            // secondsLeft
            // 
            this.secondsLeft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.secondsLeft.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.secondsLeft.Location = new System.Drawing.Point(564, 98);
            this.secondsLeft.Margin = new System.Windows.Forms.Padding(5);
            this.secondsLeft.Name = "secondsLeft";
            this.secondsLeft.Size = new System.Drawing.Size(72, 29);
            this.secondsLeft.TabIndex = 9;
            this.secondsLeft.TextChanged += new System.EventHandler(this.secondsLeft_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(781, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "In seconds";
            this.label2.TextChanged += new System.EventHandler(this.label2_TextChanged);
            // 
            // LapTimesSec
            // 
            this.LapTimesSec.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LapTimesSec.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LapTimesSec.Location = new System.Drawing.Point(482, 182);
            this.LapTimesSec.Margin = new System.Windows.Forms.Padding(5);
            this.LapTimesSec.Name = "LapTimesSec";
            this.LapTimesSec.Size = new System.Drawing.Size(72, 29);
            this.LapTimesSec.TabIndex = 11;
            this.LapTimesSec.TextChanged += new System.EventHandler(this.LapTimesSec_TextChanged);
            // 
            // LapTimesMiliSec
            // 
            this.LapTimesMiliSec.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LapTimesMiliSec.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LapTimesMiliSec.Location = new System.Drawing.Point(564, 182);
            this.LapTimesMiliSec.Margin = new System.Windows.Forms.Padding(5);
            this.LapTimesMiliSec.Name = "LapTimesMiliSec";
            this.LapTimesMiliSec.Size = new System.Drawing.Size(72, 29);
            this.LapTimesMiliSec.TabIndex = 12;
            this.LapTimesMiliSec.TextChanged += new System.EventHandler(this.LapTimesMiliSec_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(781, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "In seconds";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(397, 339);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(179, 29);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(494, 465);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(2, 23);
            this.label4.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(224, 409);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 26);
            this.label5.TabIndex = 16;
            this.label5.Text = "Fuel needed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(493, 406);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 26);
            this.label6.TabIndex = 17;
            this.label6.Text = "Laps remaining";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(483, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "/ per lap";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(88, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(253, 26);
            this.label8.TabIndex = 19;
            this.label8.Text = "Time remaining countdown";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(393, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 21);
            this.label9.TabIndex = 20;
            this.label9.Text = "hours";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(478, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 21);
            this.label10.TabIndex = 21;
            this.label10.Text = "minutes";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(560, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 21);
            this.label11.TabIndex = 22;
            this.label11.Text = "seconds";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Location = new System.Drawing.Point(393, 156);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 21);
            this.label12.TabIndex = 23;
            this.label12.Text = "minutes";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Location = new System.Drawing.Point(560, 156);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 21);
            this.label13.TabIndex = 24;
            this.label13.Text = "milliseconds";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Location = new System.Drawing.Point(478, 156);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 21);
            this.label14.TabIndex = 25;
            this.label14.Text = "seconds";
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.resetBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.resetBtn.FlatAppearance.BorderSize = 0;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.ForeColor = System.Drawing.Color.DarkSalmon;
            this.resetBtn.Location = new System.Drawing.Point(531, 546);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(176, 52);
            this.resetBtn.TabIndex = 26;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ACCFuelCalc.Properties.Resources.kisspng_assetto_corsa_sebring_international_raceway_logo_r_assetto_5b15bf222c7285_0193231315281518421821__Vlastní_;
            this.pictureBox1.InitialImage = global::ACCFuelCalc.Properties.Resources.ACC_Logo_Ambientato;
            this.pictureBox1.Location = new System.Drawing.Point(742, 436);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1038, 624);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LapTimesMiliSec);
            this.Controls.Add(this.LapTimesSec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.secondsLeft);
            this.Controls.Add(this.minutesLeft);
            this.Controls.Add(this.Calc_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FuelConsumption_label);
            this.Controls.Add(this.LapTimes_label);
            this.Controls.Add(this.TimeLeft_label);
            this.Controls.Add(this.FuelConsumption);
            this.Controls.Add(this.LapTimesMin);
            this.Controls.Add(this.hoursLeft);
            this.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACC Fuel Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hoursLeft;
        private System.Windows.Forms.TextBox LapTimesMin;
        private System.Windows.Forms.TextBox FuelConsumption;
        private System.Windows.Forms.Label TimeLeft_label;
        private System.Windows.Forms.Label LapTimes_label;
        private System.Windows.Forms.Label FuelConsumption_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Calc_btn;
        private System.Windows.Forms.TextBox minutesLeft;
        private System.Windows.Forms.TextBox secondsLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LapTimesSec;
        private System.Windows.Forms.TextBox LapTimesMiliSec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

