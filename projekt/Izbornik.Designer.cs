namespace projekt
{
    partial class Izbornik
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
            this.label_dobroDosli = new System.Windows.Forms.Label();
            this.labelizaberiteIgricu = new System.Windows.Forms.Label();
            this.buttonAuti = new System.Windows.Forms.Button();
            this.buttonKrizicKruzic = new System.Windows.Forms.Button();
            this.buttonTreseta = new System.Windows.Forms.Button();
            this.buttonZmija = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_dobroDosli
            // 
            this.label_dobroDosli.AutoSize = true;
            this.label_dobroDosli.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_dobroDosli.Location = new System.Drawing.Point(28, 32);
            this.label_dobroDosli.Name = "label_dobroDosli";
            this.label_dobroDosli.Size = new System.Drawing.Size(292, 55);
            this.label_dobroDosli.TabIndex = 0;
            this.label_dobroDosli.Text = "Dobro došli!";
            this.label_dobroDosli.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelizaberiteIgricu
            // 
            this.labelizaberiteIgricu.AutoSize = true;
            this.labelizaberiteIgricu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelizaberiteIgricu.Location = new System.Drawing.Point(32, 105);
            this.labelizaberiteIgricu.Name = "labelizaberiteIgricu";
            this.labelizaberiteIgricu.Size = new System.Drawing.Size(213, 31);
            this.labelizaberiteIgricu.TabIndex = 1;
            this.labelizaberiteIgricu.Text = "Odaberite igricu:";
            this.labelizaberiteIgricu.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // buttonAuti
            // 
            this.buttonAuti.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonAuti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAuti.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAuti.Location = new System.Drawing.Point(274, 276);
            this.buttonAuti.Name = "buttonAuti";
            this.buttonAuti.Size = new System.Drawing.Size(352, 78);
            this.buttonAuti.TabIndex = 5;
            this.buttonAuti.Text = "Auti";
            this.buttonAuti.UseVisualStyleBackColor = false;
            this.buttonAuti.Click += new System.EventHandler(this.otvoriUtrkuAuta);
            // 
            // buttonKrizicKruzic
            // 
            this.buttonKrizicKruzic.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonKrizicKruzic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonKrizicKruzic.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonKrizicKruzic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKrizicKruzic.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonKrizicKruzic.Location = new System.Drawing.Point(274, 192);
            this.buttonKrizicKruzic.Name = "buttonKrizicKruzic";
            this.buttonKrizicKruzic.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonKrizicKruzic.Size = new System.Drawing.Size(352, 78);
            this.buttonKrizicKruzic.TabIndex = 4;
            this.buttonKrizicKruzic.Text = "Križić Kružić";
            this.buttonKrizicKruzic.UseVisualStyleBackColor = false;
            this.buttonKrizicKruzic.Click += new System.EventHandler(this.otvoriKrizicKruzic);
            // 
            // buttonTreseta
            // 
            this.buttonTreseta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonTreseta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTreseta.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTreseta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonTreseta.Location = new System.Drawing.Point(274, 108);
            this.buttonTreseta.Name = "buttonTreseta";
            this.buttonTreseta.Size = new System.Drawing.Size(352, 78);
            this.buttonTreseta.TabIndex = 2;
            this.buttonTreseta.Text = "Trešeta";
            this.buttonTreseta.UseVisualStyleBackColor = false;
            this.buttonTreseta.Click += new System.EventHandler(this.otvoriTreseta);
            // 
            // buttonZmija
            // 
            this.buttonZmija.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonZmija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZmija.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZmija.Location = new System.Drawing.Point(274, 360);
            this.buttonZmija.Name = "buttonZmija";
            this.buttonZmija.Size = new System.Drawing.Size(352, 78);
            this.buttonZmija.TabIndex = 6;
            this.buttonZmija.Text = "Zmija";
            this.buttonZmija.UseVisualStyleBackColor = false;
            // 
            // Izbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(686, 515);
            this.Controls.Add(this.buttonZmija);
            this.Controls.Add(this.buttonAuti);
            this.Controls.Add(this.buttonKrizicKruzic);
            this.Controls.Add(this.buttonTreseta);
            this.Controls.Add(this.labelizaberiteIgricu);
            this.Controls.Add(this.label_dobroDosli);
            this.Name = "Izbornik";
            this.Text = "Izbornik";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_dobroDosli;
        private System.Windows.Forms.Label labelizaberiteIgricu;
        private System.Windows.Forms.Button buttonTreseta;
        private System.Windows.Forms.Button buttonKrizicKruzic;
        private System.Windows.Forms.Button buttonAuti;
        private System.Windows.Forms.Button buttonZmija;
    }
}

