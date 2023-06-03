using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WaNNaCRYP0
{
    public partial class Form1 : Form
    {
        public int bar1 = 100;
        public int bar2 = 100;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            dikeybar1.Value = 100;
            dikeybar2.Value = 100;
            timer1.Start();
            timer2.Start();
            comboBox1.Text = "Turkish";
            pictureBox1.ImageLocation = "1.png";
            pictureBox2.ImageLocation = "2.jpg";
            textBox2.Text = "qryvvpplegvxxsuwtqwug9k5rjvhm7gp7vydhc09d9";
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            DateTime selectedDate = dateTimePicker1.Value;
            DateTime nextDay = selectedDate.AddDays(1);
            label3.Text = nextDay.ToShortDateString();
            DateTime nextDay2 = selectedDate.AddDays(2);
            label4.Text = nextDay2.ToShortDateString();
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Turkish")
            {
                linkLabel1.Text = "Bitcoinler Hakkında";
                linkLabel2.Text = "Bitcoin nasıl alınır?";
                linkLabel3.Text = "Bize ulaşın";
                button1.Text = "Ödemeyi Kontrol Et";
                button2.Text = "Çözümle";
                label1.Text = "Bu adrese 600$/dolar değerinde bitcoin gönder";
                label2.Text = "Ödeme şu tarihte yapılacaktır";
                label5.Text = "Dosyalarınız şu tarihte silinecektir";
                label6.Text = "Hay aksi, dosyalarınız şifrelenmiş!";
                textBox1.Text = "Bu uyarı size WannaCrypt, WannaCry, WannaCryptor, veya Wcry gibi isimlerle ortaya çıkan  zararlı yazılım saldırısıyla ilgili size bilgi vermeyi amaçlar. Lütfen saldırı hakkında bilgilenmelerini, hazırlıklı olmalarını ve kurumunuzu koruma altına almalarını sağlamak amacıyla BT ve Güvenlik ekiplerinizle paylaşın.12 Mayıs 2017’de dünyanın her yerinden pek çok müşterimizin kullanmakta oldukları kritik sistemler “WannaCrypt” isimli zararlı yazılımdan etkilendi. Microsoft olarak hızla bu saldırıyı inceleyerek müşterilerimizi korumak için mümkün olan tüm önlemleri aldık. Aşağıda her son kullanıcı ve kurumun bu saldırıdan korunmak için yapması gerekenleri paylaşıyoruz. Ayrıca, tüm müşterilerimizi korumak için beklenenin ötesinde bir adım atarak, özel destek politikasına tabi olan Windows XP, Windows 8, and Windows Server 2003 platformları için de bir güvenlik güncellemesi yayınlıyoruz.Mart 2017’de, bu saldırıların faydalandığı zafiyeti adresleyen bir güvenlik güncellemesi yayınladık. Maalesef bu zararlı yazılımın, söz konusu güvenlik güncellemesini uygulamamış bilgisayarları etkilediği görülüyor. Bu nedenle tüm kullanıcılara, eğer daha önce yüklemedilerse, hemen MS17-010 güncellemesini yüklemelerini tavsiye ediyoruz.Korunmak ve saldırıyı engellemek için adımlar:1. Windows 10’a geçin ve bilgisayarlarınızı güncel tutarak Windows 10’un en yeni güvenlik özelliklerinden ve proaktif koruma sistemlerinden faydalanın.2. Henüz MS17-010 güvenlik güncellemesini yüklememiş olan bütün müşterilerimizin mümkün olan en kısa sürede güncellemeyi kurumlarında dağıtmalarını tavsiye ediyoruz. Güncellemeyi dağıtma sürecinde, saldırı alanını daraltmak için aşağıdaki iki geçici çözümü de kullanabilirsiniz:• SMBv1 protokolünü bu makalede anlatıldığı ve daha önce tavsiye edildiği şekilde devre dışı bırakın (yeniden başlatma gerektirir).• Yönlendirici veya Güvenlik Duvarı ayarlarınız için bir kural oluşturarak 445 çıkışına gelen SMB trafiğini engellemeyi değerlendirin.3. Windows Defender 1.243.297.0 güncellemesiyle bu saldırının kaynağı olan zararlı yazılımı Ransom:Win32/WannaCrypt olarak tespit ediyor. Kurumunuzda Windows Defender’ı aktive ederek bu saldırıdan korunabilirsiniz.4. Yapay zeka tabanlı yetenekleriyle fidye yazılımları taşıyan tehlikeli epostaları engelleyen Office 365 Advanced Threat Protection servisimizi kullanın.5. Ağınızdaki şüpheli aktiviteleri tespit etmenize olanak sağlayan Windows Defender Advanced Threat Protection servisimizi kullanın. Windows Defender Advanced Threat Protection – Fidye Yazılımlara Yanıt Verme Kılavuzu’nu indirin ve Windows Defender ATP kullanarak fidye yazılımları nasıl tespit edip, inceleyerek durdurabileceğinizi öğrenin.6. Cihazları zararlı yazılımlara karşı kitlemek için Kernel seviyesinde sanallaştırma tabanlı güvenlik katmanı sağlayan Device Guard’ı kullanın ve bilgisayarlarınızda sadece güvenilen uygulamaların çalışmasına izin verin.7. Destek seçenekleriyle ilgili daha detaylı bilgi almak için Kurumlar için Destek sayfamızı ziyaret edin.Konuyla ilgili güncellemeler için Microsoft Türkiye Blog sayfamızı takip edin. Saygılarımızla,";
            }
            else
            {
                linkLabel1.Text = "About Bitcoin";
                linkLabel2.Text = "How to buy Bitcoin?";
                linkLabel3.Text = "Contact Us";
                button1.Text = "Check Payment";
                button2.Text = "Decyript";
                label1.Text = "Send 600$ worth of bitcoin to this address:";
                label2.Text = "Payment will be raised on";
                label5.Text = "Yout files will be lost on";
                label6.Text = "Ooops, your files have been encrypted!";
                textBox1.Text = "This warning is intended to inform you about the malware attack with names such as WannaCrypt, WannaCry, WannaCryptor, or Wcry. Please share them with your IT and Security teams to ensure that they are informed, prepared and protected by your attack. Critical systems that many customers worldwide have been using on May 12, 2017 are affected by malware named WannaCrypt. As Microsoft, we quickly took this precaution and took all possible precautions to protect our customers. Below we share what every end user and organization needs to do to protect against this attack. We are also releasing a security update for Windows XP, Windows 8, and Windows Server 2003 platforms that are subject to a special support policy by taking a step beyond what is expected to protect all our customers. We released a security update addressing the weaknesses of these attacks in March 2017. Unfortunately, this malware seems to affect computers that have not implemented the security update in question. For this reason, we advise all users to download the MS17-010 update immediately if they have not already. Steps to protect and prevent attack: 1. Upgrade to Windows 10 and take advantage of Windows 10's latest security features and proactive protection systems by keeping your computers current.2. We recommend that all customers who have not yet installed the MS17-010 security update distribute the update in their organization as soon as possible. You can also use the following two workarounds to narrow down the attack area: • Disable the SMBv1 protocol described in this article and disable it as previously recommended (requires a restart) • Create a rule for your Router or Firewall settings, 3. Evaluate to prevent traffic. With Windows Defender 1.243.297.0 update, it detects Ransom: Win32 / WannaCrypt as the source of this attack. You can protect yourself from this attack by activating Windows Defender at your organization. Use our Office 365 Advanced Threat Protection service, which blocks dangerous e-mails carrying ransom software with artificial intelligence capabilities. Use our Windows Defender Advanced Threat Protection service, which allows you to detect suspicious activity on your network. Windows Defender Advanced Threat Protection - Download the Ridiculous Software Aid Guide and learn how you can stop and detect ransom software using Windows Defender ATP. Use Device Guard, which provides a virtualization-based security layer at the Kernel level to lock the devices against malware, and allow only trusted applications to run on your computers. To get more detailed information about support options, visit our support page for updates on edin.kon to follow our corporate blog, Microsoft Turkey. Our respect,";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://scontent.fist13-1.fna.fbcdn.net/v/t39.30808-6/324934131_1358731458224052_5408968308397163367_n.png?stp=dst-png_s960x960&_nc_cat=104&ccb=1-7&_nc_sid=e3f864&_nc_ohc=QVrmJWKgeR4AX9sxVXy&_nc_ht=scontent.fist13-1.fna&oh=00_AfCoU5zUhmyxdM70c4cCF80PdJEeT_P8q0L-kSXYymqbPw&oe=6474FDA7");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Turkish")
            {
                MessageBox.Show("Çözümlendi","",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Decrypted","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int salise = 60;
        int saniye = 60;
        int dakika = 60;
        int saat = 24;
        int countdown;

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1;

            salise = salise - 1;
            lblSalise.Text = Convert.ToString(salise);
            lblSaniye.Text = Convert.ToString(saniye - 1) + ":";
            lblDakika.Text = Convert.ToString(dakika) + ":";
            lblSaat.Text = Convert.ToString(saat) + ":";
            if (salise == 0)
            {
                saniye = saniye - 1;
                lblSaniye.Text = Convert.ToString(saniye);
                salise = 60;

            }
            if (saniye == 0)
            {

                dakika = dakika - 1;
                lblDakika.Text = Convert.ToString(dakika);
                saniye = 60;

            }
            if (dakika == 0)
            {
                saat = saat - 1;
                lblSaat.Text = Convert.ToString(saat);
                dakika = 60;
                if (dikeybar1.Value > 1)
                {
                    dikeybar1.Value = dikeybar1.Value - 1;
                }
            }
            if (saat <= 0)
            {
                timer1.Stop();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int salise2 = 60;
        int saniye2 = 60;
        int dakika2 = 60;
        int saat2 = 48;
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = 1;

            salise2 = salise2 - 1;
            lbSalise.Text = Convert.ToString(salise2);
            lbSaniye.Text = Convert.ToString(saniye2 - 1) + ":";
            lbDakika.Text = Convert.ToString(dakika2) + ":";
            lbSaat.Text = Convert.ToString(saat2) + ":";
            if (salise2 == 0)
            {
                saniye2 = saniye2 - 1;
                lbSaniye.Text = Convert.ToString(saniye2);
                salise2 = 60;
            }
            if (saniye2 == 0)
            {
                dakika2 = dakika2 - 1;
                lbDakika.Text = Convert.ToString(dakika2);
                saniye2 = 60;
            }
            if (dakika2 == 0)
            {
                saat2 = saat2 - 1;
                lbSaat.Text = Convert.ToString(saat2);
                dakika2 = 60;
                if (dikeybar2.Value > 1)
                {
                    dikeybar2.Value = dikeybar2.Value - 1;
                }
            }
            if (saat <= 0)
            {

                timer2.Stop();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void timer3_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (comboBox1.Text == "Turkish")
            {
                System.Diagnostics.Process.Start("https://tr.wikipedia.org/wiki/Bitcoin");
            }
            else
            {
                System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Bitcoin");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (comboBox1.Text == "Turkish")
            {
                System.Diagnostics.Process.Start("https://www.binance.com/tr/how-to-buy/bitcoin");
            }
            else
            {
                System.Diagnostics.Process.Start("https://www.bitcoin.com/get-started/how-to-buy-bitcoin/");
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/PISTIN22");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dikeybar2_Click(object sender, EventArgs e)
        {

        }
    }
}