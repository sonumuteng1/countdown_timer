
namespace Countdown_timer
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.cbox_suresec = new System.Windows.Forms.ComboBox();
            this.lbl_kalansure_saniye = new System.Windows.Forms.Label();
            this.lbl_kalansure_dakika = new System.Windows.Forms.Label();
            this.btn_sifirla = new System.Windows.Forms.Button();
            this.btn_durdur = new System.Windows.Forms.Button();
            this.btn_baslalt = new System.Windows.Forms.Button();
            this.tmr_countdown = new System.Windows.Forms.Timer(this.components);
            this.lbl_dakika = new System.Windows.Forms.Label();
            this.lbl_saniye = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbox_suresec
            // 
            this.cbox_suresec.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbox_suresec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_suresec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbox_suresec.ForeColor = System.Drawing.Color.Black;
            this.cbox_suresec.FormattingEnabled = true;
            this.cbox_suresec.Location = new System.Drawing.Point(208, 93);
            this.cbox_suresec.Name = "cbox_suresec";
            this.cbox_suresec.Size = new System.Drawing.Size(200, 24);
            this.cbox_suresec.TabIndex = 13;
            this.cbox_suresec.SelectedIndexChanged += new System.EventHandler(this.cbox_suresec_SelectedIndexChanged);
            // 
            // lbl_kalansure_saniye
            // 
            this.lbl_kalansure_saniye.AutoSize = true;
            this.lbl_kalansure_saniye.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kalansure_saniye.Location = new System.Drawing.Point(355, 197);
            this.lbl_kalansure_saniye.Name = "lbl_kalansure_saniye";
            this.lbl_kalansure_saniye.Size = new System.Drawing.Size(34, 24);
            this.lbl_kalansure_saniye.TabIndex = 12;
            this.lbl_kalansure_saniye.Text = "00";
            // 
            // lbl_kalansure_dakika
            // 
            this.lbl_kalansure_dakika.AutoSize = true;
            this.lbl_kalansure_dakika.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kalansure_dakika.Location = new System.Drawing.Point(235, 197);
            this.lbl_kalansure_dakika.Name = "lbl_kalansure_dakika";
            this.lbl_kalansure_dakika.Size = new System.Drawing.Size(34, 24);
            this.lbl_kalansure_dakika.TabIndex = 11;
            this.lbl_kalansure_dakika.Text = "00";
            // 
            // btn_sifirla
            // 
            this.btn_sifirla.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_sifirla.Location = new System.Drawing.Point(387, 271);
            this.btn_sifirla.Name = "btn_sifirla";
            this.btn_sifirla.Size = new System.Drawing.Size(93, 34);
            this.btn_sifirla.TabIndex = 9;
            this.btn_sifirla.Text = "Sıfırla";
            this.btn_sifirla.UseVisualStyleBackColor = false;
            this.btn_sifirla.Click += new System.EventHandler(this.btn_sifirla_Click);
            // 
            // btn_durdur
            // 
            this.btn_durdur.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_durdur.Location = new System.Drawing.Point(270, 271);
            this.btn_durdur.Name = "btn_durdur";
            this.btn_durdur.Size = new System.Drawing.Size(93, 34);
            this.btn_durdur.TabIndex = 8;
            this.btn_durdur.Text = "Durdur";
            this.btn_durdur.UseVisualStyleBackColor = false;
            this.btn_durdur.Click += new System.EventHandler(this.btn_durdur_Click);
            // 
            // btn_baslalt
            // 
            this.btn_baslalt.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_baslalt.Location = new System.Drawing.Point(150, 271);
            this.btn_baslalt.Name = "btn_baslalt";
            this.btn_baslalt.Size = new System.Drawing.Size(93, 34);
            this.btn_baslalt.TabIndex = 7;
            this.btn_baslalt.Text = "Baslat";
            this.btn_baslalt.UseVisualStyleBackColor = false;
            this.btn_baslalt.Click += new System.EventHandler(this.btn_baslalt_Click);
            // 
            // tmr_countdown
            // 
            this.tmr_countdown.Interval = 1000;
            this.tmr_countdown.Tick += new System.EventHandler(this.tmr_countdown_Tick);
            // 
            // lbl_dakika
            // 
            this.lbl_dakika.AutoSize = true;
            this.lbl_dakika.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_dakika.Location = new System.Drawing.Point(216, 157);
            this.lbl_dakika.Name = "lbl_dakika";
            this.lbl_dakika.Size = new System.Drawing.Size(73, 22);
            this.lbl_dakika.TabIndex = 14;
            this.lbl_dakika.Text = "Dakika";
            // 
            // lbl_saniye
            // 
            this.lbl_saniye.AutoSize = true;
            this.lbl_saniye.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_saniye.Location = new System.Drawing.Point(337, 157);
            this.lbl_saniye.Name = "lbl_saniye";
            this.lbl_saniye.Size = new System.Drawing.Size(73, 22);
            this.lbl_saniye.TabIndex = 15;
            this.lbl_saniye.Text = "Saniye";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(631, 450);
            this.Controls.Add(this.lbl_saniye);
            this.Controls.Add(this.lbl_dakika);
            this.Controls.Add(this.cbox_suresec);
            this.Controls.Add(this.lbl_kalansure_saniye);
            this.Controls.Add(this.lbl_kalansure_dakika);
            this.Controls.Add(this.btn_sifirla);
            this.Controls.Add(this.btn_durdur);
            this.Controls.Add(this.btn_baslalt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Gerisayım Aracı";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbox_suresec;
        private System.Windows.Forms.Label lbl_kalansure_saniye;
        private System.Windows.Forms.Label lbl_kalansure_dakika;
        private System.Windows.Forms.Button btn_sifirla;
        private System.Windows.Forms.Button btn_durdur;
        private System.Windows.Forms.Button btn_baslalt;
        private System.Windows.Forms.Timer tmr_countdown;
        private System.Windows.Forms.Label lbl_dakika;
        private System.Windows.Forms.Label lbl_saniye;
    }
}