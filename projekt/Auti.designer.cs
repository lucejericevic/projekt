namespace utrkaAuta
{
    partial class UtrkaAuta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UtrkaAuta));
            this.panel1 = new System.Windows.Forms.Panel();
            this.nagrada = new System.Windows.Forms.PictureBox();
            this.auto2 = new System.Windows.Forms.PictureBox();
            this.igrac = new System.Windows.Forms.PictureBox();
            this.bomba = new System.Windows.Forms.PictureBox();
            this.auto1 = new System.Windows.Forms.PictureBox();
            this.cesta2 = new System.Windows.Forms.PictureBox();
            this.cesta1 = new System.Windows.Forms.PictureBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelScore = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nagrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cesta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cesta1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.nagrada);
            this.panel1.Controls.Add(this.auto2);
            this.panel1.Controls.Add(this.igrac);
            this.panel1.Controls.Add(this.bomba);
            this.panel1.Controls.Add(this.auto1);
            this.panel1.Controls.Add(this.cesta2);
            this.panel1.Controls.Add(this.cesta1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 424);
            this.panel1.TabIndex = 0;
            // 
            // nagrada
            // 
            this.nagrada.BackColor = System.Drawing.Color.Transparent;
            this.nagrada.Image = ((System.Drawing.Image)(resources.GetObject("nagrada.Image")));
            this.nagrada.Location = new System.Drawing.Point(66, 157);
            this.nagrada.Name = "nagrada";
            this.nagrada.Size = new System.Drawing.Size(250, 100);
            this.nagrada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nagrada.TabIndex = 5;
            this.nagrada.TabStop = false;
            // 
            // auto2
            // 
            this.auto2.BackColor = System.Drawing.Color.Transparent;
            this.auto2.Image = global::utrkaAuta.Properties.Resources.carGreen;
            this.auto2.Location = new System.Drawing.Point(294, 85);
            this.auto2.Name = "auto2";
            this.auto2.Size = new System.Drawing.Size(50, 101);
            this.auto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.auto2.TabIndex = 9;
            this.auto2.TabStop = false;
            // 
            // igrac
            // 
            this.igrac.BackColor = System.Drawing.Color.Transparent;
            this.igrac.Image = ((System.Drawing.Image)(resources.GetObject("igrac.Image")));
            this.igrac.Location = new System.Drawing.Point(161, 286);
            this.igrac.Name = "igrac";
            this.igrac.Size = new System.Drawing.Size(50, 101);
            this.igrac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.igrac.TabIndex = 8;
            this.igrac.TabStop = false;
            // 
            // bomba
            // 
            this.bomba.BackColor = System.Drawing.Color.Transparent;
            this.bomba.Image = ((System.Drawing.Image)(resources.GetObject("bomba.Image")));
            this.bomba.Location = new System.Drawing.Point(153, 234);
            this.bomba.Name = "bomba";
            this.bomba.Size = new System.Drawing.Size(64, 64);
            this.bomba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bomba.TabIndex = 6;
            this.bomba.TabStop = false;
            // 
            // auto1
            // 
            this.auto1.Image = ((System.Drawing.Image)(resources.GetObject("auto1.Image")));
            this.auto1.Location = new System.Drawing.Point(66, 19);
            this.auto1.Name = "auto1";
            this.auto1.Size = new System.Drawing.Size(50, 101);
            this.auto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.auto1.TabIndex = 4;
            this.auto1.TabStop = false;
            // 
            // cesta2
            // 
            this.cesta2.Image = global::utrkaAuta.Properties.Resources.roadTrack;
            this.cesta2.Location = new System.Drawing.Point(-2, -210);
            this.cesta2.Name = "cesta2";
            this.cesta2.Size = new System.Drawing.Size(385, 632);
            this.cesta2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cesta2.TabIndex = 3;
            this.cesta2.TabStop = false;
            // 
            // cesta1
            // 
            this.cesta1.Image = global::utrkaAuta.Properties.Resources.roadTrack1;
            this.cesta1.Location = new System.Drawing.Point(-2, -638);
            this.cesta1.Name = "cesta1";
            this.cesta1.Size = new System.Drawing.Size(380, 424);
            this.cesta1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cesta1.TabIndex = 2;
            this.cesta1.TabStop = false;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonStart.FlatAppearance.BorderSize = 2;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStart.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonStart.Location = new System.Drawing.Point(131, 523);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(130, 59);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click_1);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelScore.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelScore.Location = new System.Drawing.Point(125, 468);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(144, 32);
            this.labelScore.TabIndex = 1;
            this.labelScore.Text = "Score: 00";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // UtrkaAuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(403, 648);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.panel1);
            this.Name = "UtrkaAuta";
            this.Text = "UtrkaAuta";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.makniAuto);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.zaustaviAuto);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nagrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cesta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cesta1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.PictureBox cesta1;
        private System.Windows.Forms.PictureBox cesta2;
        private System.Windows.Forms.PictureBox auto2;
        private System.Windows.Forms.PictureBox igrac;
        private System.Windows.Forms.PictureBox bomba;
        private System.Windows.Forms.PictureBox nagrada;
        private System.Windows.Forms.PictureBox auto1;
        private System.Windows.Forms.Timer timer;
    }
}

