﻿namespace projekt
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonTreseta = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(274, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(352, 78);
            this.button1.TabIndex = 5;
            this.button1.Text = "Igrica 3";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(274, 192);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(352, 78);
            this.button2.TabIndex = 4;
            this.button2.Text = "Križić Kružić";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.otvoriKrizicKruzic);
            // 
            // buttonTreseta
            // 
            this.buttonTreseta.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            // Izbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(686, 439);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

