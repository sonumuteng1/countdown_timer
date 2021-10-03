using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;




namespace Countdown_timer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int saniye, dakika;
        
        private void Form2_Load(object sender, EventArgs e)
        {            
            cbox_suresec.Items.Add("Lütfen Süre Seçiniz!");
            cbox_suresec.SelectedIndex = 0;
            
            for (int i = 1; i < 60; i++)
            {
                cbox_suresec.Items.Add(i);                                
            }            
            btn_3pasif();
        }

        private void cbox_suresec_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbox_sure_kontrol();
            if (saniye==0 && dakika==0)
            {
                btn_3pasif();
            }
            else if (saniye!=0 || dakika!=0)            
            {
                btn_baslalt.Enabled = true;
                btn_durdur.Enabled = false;
                btn_sifirla.Enabled = false;
            }                        
        }

        private void cbox_sure_kontrol()
        {
            if (cbox_suresec.SelectedIndex != 0)
            {
                tmr_countdown.Stop();
                lbl_kalansure_saniye.Text = "00";
                lbl_kalansure_dakika.Text = cbox_suresec.Text;
                dakika = Convert.ToInt32(lbl_kalansure_dakika.Text);
                saniye = 60;
                btn_baslalt.Enabled = true;
                btn_durdur.Enabled = false;
                
            }
            else
            {
                tmr_countdown.Stop();
                sifirla();
            }
        }

        private void btn_baslalt_Click(object sender, EventArgs e)
        {
            if (saniye != 0 || dakika != 0)
            {  //firstcommit 2.commit
                tmr_countdown.Start();
                btn_baslalt.Enabled = false;
                btn_durdur.Enabled = true;
                btn_sifirla.Enabled = false;

                //hesap makinesi branch geliştirmesi.
            }
            else 
            {
                MessageBox.Show("Lütfen Süre Seçiniz.");
            }                        
        }
        
        private void btn_durdur_Click(object sender, EventArgs e)
        {
            tmr_countdown.Stop();
            btn_baslalt.Enabled = true;
            btn_durdur.Enabled = false;
            btn_sifirla.Enabled = true;
        }

        private void btn_sifirla_Click(object sender, EventArgs e)
        {
            sifirla();           
        }

        private void tmr_countdown_Tick(object sender, EventArgs e)
        {                                    
            saniye--;
            lbl_kalansure_saniye.Text = saniye.ToString();
            dakika_kontrol();          
        }

        private void dakika_kontrol()
        {
            if (saniye == 59 && dakika != 0)
            {
                dakika--;
                lbl_kalansure_dakika.Text = dakika.ToString();               
            }

            else if (saniye == 0 && dakika != 0)
            {
                saniye = 60;
            }

            else if (saniye == 0 && dakika == 0)
            {
                tmr_countdown.Stop();
                lbl_kalansure_saniye.Text = "00";
                lbl_kalansure_dakika.Text = "00";               
                btn_3pasif();                
                bitis_sesi_cal();                
               
                if (MessageBox.Show("Süre Bitti!")==DialogResult.OK)
                {
                    bitis_sesi_durdur();
                    sifirla();
                }                               
            }
        }

        private void bitis_sesi_cal()
        {           
                SoundPlayer alarm = new SoundPlayer(Countdown_timer.Properties.Resources.alarm_beep);
                alarm.Play();
        }

        private void bitis_sesi_durdur()
        {
            SoundPlayer alarm = new SoundPlayer(Countdown_timer.Properties.Resources.alarm_beep);
            alarm.Stop();                        
        }

        private void btn_3pasif()
        {
            btn_baslalt.Enabled = false;
            btn_durdur.Enabled = false;
            btn_sifirla.Enabled = false;
        }

        public void sifirla()
        {
            lbl_kalansure_dakika.Text = "00";
            lbl_kalansure_saniye.Text = "00";
            btn_3pasif();
            saniye = 0;
            dakika = 0;
            cbox_suresec.SelectedIndex = 0;
        } 
    }
}
