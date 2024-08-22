using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ehliyet_sınav
{
    public partial class Form1 : Form
    {
       public int soruNo=0, doğru=0, yanlıs=0;
       
        
       
        SONUÇLAR br = new SONUÇLAR();


        public Form1()
        {
            InitializeComponent();
        }

        private void bSONRAKİ_Click(object sender, EventArgs e)
        {
            bBASLA.Enabled = false;
            button1.Enabled = true;
            bA.Enabled = true;
            bB.Enabled = true;
            bC.Enabled = true;
            bD.Enabled = true;

            soruNo = soruNo + 1;
            lblsoruno.Text = soruNo.ToString();

            richTextBox1.Text = "1)Kaza anında araç dışına fırlama riskini azaltmak için araçlarda bulunan güvenlik sistemi aşağıdakilerden hangisidir?";
            bA.Text = "A)ASR";
            bB.Text = "B)ABS";
            bC.Text = "C)Emniyet kemeri";
            bD.Text = "D)Hava yastığı";
            label7.Text = "C)Emniyet kemeri";

        }

        private void bB_Click(object sender, EventArgs e)
        {

            if (bB.Text == label7.Text)
            {
                doğru = doğru + 1;
              
                lbldogru.Text = doğru.ToString();
                bB.BackColor = Color.Green;
            }
            else
            {
                yanlıs = yanlıs + 1;
                
                lblyanlış.Text = yanlıs.ToString();
                bB.BackColor = Color.Red;


                if (bA.Text == label7.Text)
                {
                    bA.BackColor = Color.Green;
                }
                else if (bC.Text == label7.Text)
                {
                    bC.BackColor = Color.Green;
                }
                else if (bD.Text == label7.Text)
                {
                    bD.BackColor = Color.Green;
                }
            }
            if (soruNo != 50)
            {
            bA.Enabled = false;
            bB.Enabled = false;
            bC.Enabled = false;
            bD.Enabled = false;
            button1.Enabled = true;

            }else if (soruNo == 50)
            {
                bA.Enabled = false;
                bB.Enabled = false;
                bC.Enabled = false;
                bD.Enabled = false;
                button1.Enabled = false;
                bBİTİR.Enabled = true;

            }
           
            
        }

        private void bC_Click(object sender, EventArgs e)
        {

            if (bC.Text == label7.Text)
            {
                doğru = doğru + 1;
              
                lbldogru.Text = doğru.ToString();
                bC.BackColor = Color.Green;
            }
            else
            {
                yanlıs = yanlıs + 1;
               
                lblyanlış.Text = yanlıs.ToString();
                bC.BackColor = Color.Red;


                if (bB.Text == label7.Text)
                {
                    bB.BackColor = Color.Green;
                }
                else if (bA.Text == label7.Text)
                {
                    bA.BackColor = Color.Green;
                }
                else if (bD.Text == label7.Text)
                {
                    bD.BackColor = Color.Green;
                }
            }
            if (soruNo != 50)
            {
                bA.Enabled = false;
                bB.Enabled = false;
                bC.Enabled = false;
                bD.Enabled = false;
                button1.Enabled = true;

            }
            else if (soruNo == 50)
            {
                bA.Enabled = false;
                bB.Enabled = false;
                bC.Enabled = false;
                bD.Enabled = false;
                button1.Enabled = false;
                bBİTİR.Enabled = true;

            }
        }

        private void bD_Click(object sender, EventArgs e)
        {

            if (bD.Text == label7.Text)
            {
                doğru = doğru + 1;
                
                lbldogru.Text = doğru.ToString();
                bD.BackColor = Color.Green;
            }
            else
            {
                yanlıs = yanlıs + 1;
                
                lblyanlış.Text = yanlıs.ToString();
                bD.BackColor = Color.Red;


                if (bB.Text == label7.Text)
                {
                    bB.BackColor = Color.Green;
                }
                else if (bC.Text == label7.Text)
                {
                    bC.BackColor = Color.Green;
                }
                else if (bA.Text == label7.Text)
                {
                    bA.BackColor = Color.Green;
                }

            }

            if (soruNo != 50)
            {
                bA.Enabled = false;
                bB.Enabled = false;
                bC.Enabled = false;
                bD.Enabled = false;
                button1.Enabled = true;

            }
            else if (soruNo == 50)
            {
                bA.Enabled = false;
                bB.Enabled = false;
                bC.Enabled = false;
                bD.Enabled = false;
                button1.Enabled = false;
                bBİTİR.Enabled = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bA.Enabled = true;
            bB.Enabled = true;
            bC.Enabled = true;
            bD.Enabled = true;
            button1.Enabled = false;
            bA.BackColor =Color.White;
            bB.BackColor = Color.White;
            bC.BackColor = Color.White;
            bD.BackColor = Color.White;


            soruNo = soruNo + 1;
            lblsoruno.Text = soruNo.ToString();

            
            if (soruNo == 2)
            {
                richTextBox1.Text = "2)Yaralının taşınmasında ilk yardımcı kendi sağlığını riske sokmamalıdır. Gereksiz zorlama ve yaralanmalara engel olmak için kurallara uygun davranmalıdır.\r\n2) Buna göre aşağıdakilerden hangisi yaralının taşınması sırasında ilk yardımcının uyması gereken genel kurallardandır?";
                bA.Text = " A) Yaralıya uzak mesafede çalışması";
                bB.Text = "B) Daha uzun ve kuvvetli kas gruplarını kullanması";
                bC.Text = " C) Ani dönme ve bükülmeler yaparak yön değiştirmesi";
                bD.Text = "D) Yaralıyı mümkün olduğunca çok hareket ettirmesi";
                label7.Text = "B) Daha uzun ve kuvvetli kas gruplarını kullanması";
            }
            if (soruNo == 3) {
                richTextBox1.Text = "3) Sürücüler, trafik adabı açısından başarılı iletişim kurma becerilerini geliştirmek için hangisini yapmalıdır?";
            bA.Text = " A) İnsanların değişebileceğine inanmalıdır. ";
            bB.Text = " B) Dinlerken aynı zamanda değerlendirme eğiliminde olmalıdır.";
            bC.Text = " C) Karşısındakinin kişiliğini sevmediğinde kendini iletişime kapatmalıdır.";
            bD.Text = " D) Birini anlamak için tek bir olayın yeterli olduğunu düşünmelidir. ";
            label7.Text = " A) İnsanların değişebileceğine inanmalıdır. "; }

            if (soruNo == 4)
            {
                richTextBox1.Text = "4) Kazazedenin ağız bölgesine bir cam parçası ya da ayna yaklaştırarak buharlanıp buharlanmadığına bakılması, \"Bak-DinleHisset\" yönteminin hangi aşamasını oluşturur?";
                bA.Text = " A) Dinle";
                bB.Text = " B) Bak";
                bC.Text = " C) Hisset";
                bD.Text = " D) Dinle-Hisset";
                label7.Text = " B) Bak";
            }

            if (soruNo ==5)
            {
                richTextBox1.Text = "5) Manevra yapacak sürücü aşağıdakilerden hangisini yapmalıdır? ";
                bA.Text = " A) Ön, arka ve yanlardaki trafiği kontrol etmeli ";
                bB.Text = " B) İşaret verdiği anda manevraya başlamalı ";
                bC.Text = " C) Manevraya başladıktan sonra işaret vermeli ";
                bD.Text = " D) Manevra bitmeden önce işaret vermeyi sona erdirmeli ";
                label7.Text = " A) Ön, arka ve yanlardaki trafiği kontrol etmeli ";
            }


            if (soruNo ==6)
            {
                richTextBox1.Text = "  Trafik kazası geçiren kişiler:\r\n\r\nI. Canlarına bir zarar gelmese bile psikolojik olarak zarar görürler.\r\n\r\nII. Kişilerin bu bozuk psikolojileri ailelerin eve topluma olumsuz yansır.\r\n\r\nVerilenler için aşağıdakilerden hangisi söylenebilir?";
                bA.Text = " A) I. doğru, II. yanlış  ";
                bB.Text = " B) I. yanlış, II. doğru ";
                bC.Text = " C) Her ikisi de doğru  ";
                bD.Text = "  D) Her ikisi de yanlış";
                label7.Text = " C) Her ikisi de doğru  ";
            }


            if (soruNo ==7)
            {
                richTextBox1.Text = "Yaralıyı araçtan çıkarırken aşağıdakilerden hangisine dikkat edilir? ";
                bA.Text = " A) Yaralıda baş ağrısı meydana gelmemesine";
                bB.Text = "B) Yaralıda bilinç kaybı olmamasına ";
                bC.Text = "C) Yaralının omurga ekseni düzlüğünün bozulmamasına  ";
                bD.Text = "D) Her zaman önce ayak tarafının çıkarılmasına ";
                label7.Text = "C) Yaralının omurga ekseni düzlüğünün bozulmamasına  ";
            }


            if (soruNo ==8)
            {
                richTextBox1.Text = "Araçlarda hangisinin bulunması, olası bir kaza anında ölüm ve yaralanma riskini azaltır? ";
                bA.Text = " A) Alarm ";
                bB.Text = "  B) Hava yastığı";
                bC.Text = " C) Merkezi kilit ";
                bD.Text = " D) Hız sabitleyici ";
                label7.Text = "  B) Hava yastığı";
            }


            if (soruNo ==8)
            {
                richTextBox1.Text = " Aksine bir işaret yoksa otobüslerin otoyoldaki azami hızı saatte kaç kilometredir? ";
                bA.Text = "80 ";
                bB.Text = "90 ";
                bC.Text = "100 ";
                bD.Text = "110 ";
                label7.Text = "100 ";
            }


            if (soruNo ==9)
            {
                richTextBox1.Text = "I- Atardamar kanamaları\r\nII- Toplardamar kanamaları\r\nIII- Kılcal damar kanamaları\r\n\r\nYukarıda verilen kanama türlerinin hangile­rinde, açık renkli kanın yara ağzından kalp atımına uyumlu şekilde fışkırarak çıktığı izlenir?\r\n\r\n";
                bA.Text = " A) Yalnız 1";
                bB.Text = "B) 1 ve 2 ";
                bC.Text = "C) 2 ve 3 ";
                bD.Text = "D) 1, 2 ve 3 ";
                label7.Text = " A) Yalnız 1";
            }


            if (soruNo ==10)
            {
                richTextBox1.Text = " Yaralı taşımada sedye kullanımı ile ilgili olarak aşağıdakilerden hangisi doğrudur? ";
                bA.Text = "A) Sedye kullanımı her zaman tercih edilmelidir. ";
                bB.Text = " B) Sadece bacağı kırılanları yatırarak taşımak için tercih edilir. ";
                bC.Text = " C) Sadece zehirlenme vakalarının taşınmasında kullanılmalıdır. ";
                bD.Text = " D) Köprücük kemiği kırıklarında hastanın sedye ile taşınması hayati önem taşır.";
                label7.Text = "A) Sedye kullanımı her zaman tercih edilmelidir. ";
            }


            if (soruNo ==11)
            {
                richTextBox1.Text = "Araçlarda emniyet kemeri kullanımının zorunlu olması ile aşağıdakilerden hangisi hedeflenmektedir? ";
                bA.Text = " A) Kazaların önlenmesi ";
                bB.Text = "B) Sürücülerin dikkatinin artırılması  ";
                bC.Text = " C) Denetimlerde herhangi bir sorun yaşanmaması ";
                bD.Text = " D) Kaza anında ölüm ve yaralanmaların en aza indirilmesi  ";
                label7.Text = " D) Kaza anında ölüm ve yaralanmaların en aza indirilmesi  ";
            }


            if (soruNo ==12)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi, trafikte diğerlerine göre daha çabuk ve fazla öfkelenen sürücülerin yol açtığı bir durum değildir? ";
                bA.Text = " A) Sabırsızlık ve tahammülsüzlüğün artması ";
                bB.Text = "B) Kazaya karışma olasılığının azalması ";
                bC.Text = " C) Kural ihlallerinin artması ";
                bD.Text = " D) Dikkatin dağılması ";
                label7.Text = "B) Kazaya karışma olasılığının azalması ";
            }


            if (soruNo ==13 )
            {
                richTextBox1.Text = " Ailesi ile birlikte yolculuk yapan bir sürücü, aracını hız limitlerini aşarak sürdüğünde ailesinin hayatını da tehlikeye atmış olacaktır. Bu sürücü, hız ihlalinden kaynaklanan olası bir kazada sevdiklerinin canını riske atmakla trafikte hangi temel değeri yerine getirmemiş olur? ";
                bA.Text = " A) Hırçınlık ";
                bB.Text = " B) Sorumluluk ";
                bC.Text = "  C)Yardımlaşma";
                bD.Text = " D) Hoşnutsuzluk ";
                label7.Text = " B) Sorumluluk ";
            }


            if (soruNo ==14 )
            {
                richTextBox1.Text = "  Aracın lastikleri ne zaman kontrol edilir?";
                bA.Text = " A) Günde bir ";
                bB.Text = "  B) Haftada bir";
                bC.Text = " C) Altı ayda bir ";
                bD.Text = " D) Araca binileceği zaman ";
                label7.Text = " D) Araca binileceği zaman ";
            }


            if (soruNo ==15 )
            {
                richTextBox1.Text = " Ticari amaçla yük taşımacılığı yapan ve azami ağırlığı 3,5 tonu geçen araçların şoförleri ile ticari amaçla yolcu taşımacılığı yapan ve taşıma kapasitesi şoförü dahil 9 kişiyi geçen araçların şoförlerinin, 24 saatlik herhangi bir süre içinde devamlı olarak kaç saatten fazla araç sürmeleri yasaktır? ";
                bA.Text = " A) 1,5 ";
                bB.Text = " B) 2,5 ";
                bC.Text = "  C) 3,5";
                bD.Text = " D) 4,5 ";
                label7.Text = " D) 4,5 ";
            }


            if (soruNo == 16)
            {
                richTextBox1.Text = "Süspansiyon sisteminde bulunan ve yay salınım süresini kısaltan parça aşağıdakilerden hangisidir? ";
                bA.Text = " A) Rotil ";
                bB.Text = " B) Aks ";
                bC.Text = " C) Amortisör ";
                bD.Text = " D) Şaft ";
                label7.Text = " C) Amortisör ";
            }


            if (soruNo ==17 )
            {
                richTextBox1.Text = "Bayılan bir kazazedenin kusması varsa hangi pozisyonda tutulmalıdır? ";
                bA.Text = " A) Baş geride yarı oturuş ";
                bB.Text = " B) Sırtüstü yatış ";
                bC.Text = " C) Dik oturuş ";
                bD.Text = "D) Yan yatış ";
                label7.Text = "D) Yan yatış ";
            }


            if (soruNo ==18 )
            {
                richTextBox1.Text = " Aşağıdakilerden hangisi, kazazedenin ikinci değerlendirilme aşamalarından olan “Görüşerek Bilgi Edinme” basamağında yer alır?";
                bA.Text = "  A) Solunum sayısının değerlendirilmesi";
                bB.Text = "  B) Hoşgörülü ve nazik davranılması";
                bC.Text = "  C) Bilinç düzeyinin kontrol edilmesi";
                bD.Text = "  D) Cilt renginin değerlendirilmesi ";
                label7.Text = "  B) Hoşgörülü ve nazik davranılması";
            }


            if (soruNo ==19 )
            {
                richTextBox1.Text = "Kara Yolları Trafik Kanununa göre “M,A1, A2, A, B1, B, BE, F ve G” sınıfı sürücü belgeleri kaç yıl süreyle geçerlidir? ";
                bA.Text = "10 ";
                bB.Text = "15 ";
                bC.Text = "20 ";
                bD.Text = "25 ";
                label7.Text = "10 ";
            }


            if (soruNo ==20 )
            {
                richTextBox1.Text = ") Trafikte hangi temel değere sahip olan sürücü, kendini yaya olan yol kullanıcısının yerine koyar ve aracını kaldırıma park etmekten kaçınır? ";
                bA.Text = " A) Empati düzeyi yüksek ";
                bB.Text = " B) Görgü seviyesi düşük ";
                bC.Text = " C) Sorumsuz ";
                bD.Text = " D) Bencil ";
                label7.Text = " A) Empati düzeyi yüksek ";
            }


            if (soruNo ==21 )
            {
                richTextBox1.Text = " Hangi durumdaki yetişkin bir kazazedeye, göğüs kemiği 5 cm aşağıya inecek şekilde basınç uygulanır? ";
                bA.Text = " A) Solunumu düzensiz olan ";
                bB.Text = " B) Solunum sayısı azalan ";
                bC.Text = " C) Kalbi düzensiz çalışan ";
                bD.Text = " D) Kalbi duran ";
                label7.Text = " D) Kalbi duran ";
            }


            if (soruNo ==22 )
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi geçiş üstünlüğüne sahip araçlardandır? ";
                bA.Text = " A) Zırhlı taşıt";
                bB.Text = "  B) Kamu hizmeti taşıtı";
                bC.Text = "C) Organ nakil araçları ";
                bD.Text = "  D) Umum servis araçları";
                label7.Text = "C) Organ nakil araçları ";
            }


            if (soruNo ==23 )
            {
                richTextBox1.Text = " Periyodik bakımda aşağıdakilerden hangisinin değiştirilmemesi araç motorunun çalışmasını olumsuz etkiler?\r\n\r\n ";
                bA.Text = " A) Polen filtresinin ";
                bB.Text = "B) Yağ filtresinin  ";
                bC.Text = "C) Araç lastiklerinin ";
                bD.Text = "D) Cam sileceklerinin ";
                label7.Text = "B) Yağ filtresinin  ";
            }


            if (soruNo == 24)
            {
                richTextBox1.Text = "Hava filtresi kirli ise motor nasıl bir karışımla çalışır? ";
                bA.Text = "  A) Fakir";
                bB.Text = " B) Zengin ";
                bC.Text = " C) Normal ";
                bD.Text = " D) Az yakıtlı  ";
                label7.Text = " B) Zengin ";
            }


            if (soruNo == 25)
            {
                richTextBox1.Text = "• Gereksiz yere korna çalınması\r\n• Egzoz susturucularının orijinalliğinin bozulması\r\n• Araç camlarının açılarak yüksek sesle müzik dinlenilmesi\r\n\r\n37) Verilen davranışların yapılması aşağıdakilerden hangisine sebep olur? ";
                bA.Text = " A) Yolculuğun huzurlu geçmesine ";
                bB.Text = "B) Yolculuk süresinin kısalmasına ";
                bC.Text = "  C) Trafiğin hızlı akmasına";
                bD.Text = " D) Gürültü kirliliğine ";
                label7.Text = " D) Gürültü kirliliğine ";
            }


            if (soruNo ==26 )
            {
                richTextBox1.Text = "• Doğrultu değiştirme manevralarını yanlış yapmak\r\n• Önde giden bir aracı güvenli ve yeterli mesafeden izlememek\r\n\r\n39) Yukarıda verilenler, trafik kazalarında rol oynayan faktörlerin hangisinin içinde değerlendirilir? ";
                bA.Text = " A) Araç kusurları ";
                bB.Text = "  B) Yaya kusurları";
                bC.Text = "C) Yolcu kusurları ";
                bD.Text = "  D) Sürücü kusurları";
                label7.Text = "  D) Sürücü kusurları";
            }


            if (soruNo == 27)
            {
                richTextBox1.Text = "  Çarpışma durumunda otomatik olarak şişerek sürücü ve yolcuların ölüm ve yaralanmalarını azaltan pasif güvenlik sisteminin adı nedir?";
                bA.Text = "  A) ABS";
                bB.Text = " B) Start-Stop ";
                bC.Text = "C) Hava yastığı ";
                bD.Text = " D) Hafızalı koltuk ";
                label7.Text = "C) Hava yastığı ";
            }


            if (soruNo ==28 )
            {
                richTextBox1.Text = " Kamu hizmeti yapan yolcu taşıtlarının yolcu veya hizmetlileri bindirmeleri, indirmeleri veya duraklamaları için yatay ve düşey işaretlerle belirlenmiş yere ne ad verilir?";
                bA.Text = "  A) Garaj";
                bB.Text = "  B) Durak";
                bC.Text = "  C) Otopark";
                bD.Text = "  D) Park yeri ";
                label7.Text = "  B) Durak";
            }


            if (soruNo ==29 )
            {
                richTextBox1.Text = " Araç sürücüleri, taşıt yolunun dar olduğu yerlerdeki karşılaşmalarda, aksini gösteren bir trafik işareti yoksa aşağıdakilerden hangisine geçiş hakkı vermek suretiyle geçiş kolaylığı sağlamak zorundadır?";
                bA.Text = "  A) Otomobili süren otobüse";
                bB.Text = "  B) Motorsuz aracı süren motorlu araca";
                bC.Text = " C) Motorlu aracı süren motorsuz araca ";
                bD.Text = "  D) Minibüsü süren lastik tekerlekli traktöre";
                label7.Text = "  B) Motorsuz aracı süren motorlu araca";
            }


            if (soruNo == 30)
            {
                richTextBox1.Text = "  Sürükleme yöntemleri;\r\n\r\nI. Çok kilolu ve iri yarı kişilerin taşınmasında,\r\nII. Kazazedelerin dar, basık ve geçiş güçlüğü olan bir yerden çıkarılmasında kullanılır.\r\n\r\nVerilenler için aşağıdakilerden hangisi söylenebilir?";
                bA.Text = " A) Yalnız I doğru";
                bB.Text = " B) Yalnız II doğru ";
                bC.Text = " C) Her ikisi de doğru ";
                bD.Text = " D) Her ikisi de yanlış";
                label7.Text = " C) Her ikisi de doğru ";
            }


            if (soruNo == 31)
            {
                richTextBox1.Text = " Çok sayıda yaralının olduğu kazalarda, kazazedelerin durumu değerlendirilir ve öncelikli müdahale edilecekler belirlenir. Buna göre en son müdahale edilmesi gereken kazazede aşağıdakilerden hangisidir? ";
                bA.Text = "  A) Açık karın yarası olan";
                bB.Text = " B) Bilinci yerinde olmayan ";
                bC.Text = "  C) Solunum zorluğu çeken";
                bD.Text = "  D) Ayak bileğinde çıkık olan";
                label7.Text = "  D) Ayak bileğinde çıkık olan";
            }


            if (soruNo ==32 )
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi hoşgörü sahibi olmayan sürücülerin özelliklerindendir? ";
                bA.Text = " A) Öfkeli olmak ";
                bB.Text = " B) Sabırlı olmak ";
                bC.Text = "  C) Başarılı iletişim kurmak";
                bD.Text = "  D) Bencillikten uzak durmak";
                label7.Text = " A) Öfkeli olmak ";
            }


            if (soruNo == 33)
            {
                richTextBox1.Text = " I. Trafikteki bütün kuralların nedenini öğrenir.\r\nII. Araç kullanırken yapacağı bir kural ihlalinin sonucunda sadece maddi ceza olduğunu düşünür.\r\nIII. Trafik içinde yapacağı bir kural ihlalinde, kendisinin ya da sevdiklerinin canını tehlikeye attığının farkında değildir.\r\n\r\n48) Yukarıdakilerden hangileri trafik adabına sahip olan bir sürücü için söylenebilir?";
                bA.Text = "  A) Yalnız I";
                bB.Text = "B) I ve II ";
                bC.Text = "C) II ve III ";
                bD.Text = " D) I, II ve III ";
                label7.Text = "  A) Yalnız I";
            }


            if (soruNo ==34 )
            {
                richTextBox1.Text = " Beyin, insan vücudundaki hangi sistemin bir parçasıdır?";
                bA.Text = " A) Dolaşım sisteminin ";
                bB.Text = " B) Sindirim sisteminin ";
                bC.Text = "  C) Hareket sisteminin";
                bD.Text = " D) Sinir sisteminin ";
                label7.Text = " D) Sinir sisteminin ";
            }


            if (soruNo ==35 )
            {
                richTextBox1.Text = "• Sıkıntı veya nefes darlığı\r\n• Genellikle göğüs ortasından başlayıp kollara, boyuna, sırta ve çeneye doğru ilerleyen ve yaklaşık 5-10 dakika kadar süren ağrı hissi\r\n\r\nVerilen bulgular kazazedede aşağıdaki du­rumların hangisinin olduğunu gösterir?";
                bA.Text = " A) Reflü";
                bB.Text = "B) Kalp spazmı  ";
                bC.Text = " C) Kalp durması";
                bD.Text = "D) Solunum durması ";
                label7.Text = "B) Kalp spazmı  ";
            }


            if (soruNo == 36)
            {
                richTextBox1.Text = " Bebeklere sunî solunum nasıl yapılır?";
                bA.Text = " A) Büyüklere uygulandığı gibi";
                bB.Text = " B) Bebeğin sırtına vurarak";
                bC.Text = "C) Ağzına ve burnuna birlikte sık aralıklarla az hava vererek  ";
                bD.Text = " D) Sırt üstü yatırıp göğüs ve karnına birlikte bastırarak ";
                label7.Text = "C) Ağzına ve burnuna birlikte sık aralıklarla az hava vererek  ";
            }


            if (soruNo == 37)
            {
                richTextBox1.Text = "Aksine bir işaret yoksa, eğimsiz iki yönlü dar yolda, minibüs ile kamyonun karşı­laşması durumunda, hangisi diğerine yol vermelidir? ";
                bA.Text = "A) Minibüs, kamyona ";
                bB.Text = "B) Kamyon, minibüse ";
                bC.Text = "C) Hızı fazla olan, diğerine ";
                bD.Text = " D) Yolcu sayısı fazla olan, diğerine";
                label7.Text = "B) Kamyon, minibüse ";
            }


            if (soruNo ==38 )
            {
                richTextBox1.Text = "Kalp masajı uygulaması, aşağıdaki durumların hangisinde sonlandırılır? ";
                bA.Text = "A) Kalp çalıştığında ";
                bB.Text = " B) 112´ye haber verildiğinde";
                bC.Text = "C) Kazazedenin akrabaları geldiğinde ";
                bD.Text = "D) Kazazedenin cildinde kızarıklıklar gözlemlendiğinde ";
                label7.Text = "A) Kalp çalıştığında ";
            }


            if (soruNo ==39 )
            {
                richTextBox1.Text = " Kara yolu üzerinde hareket hâlinde olan bir veya birden fazla aracın karıştığı ölüm, yaralanma veya zararla sonuçlanan olaylara ne ad verilir?";
                bA.Text = "A) Kayıp ";
                bB.Text = "B) Hasar ";
                bC.Text = "C) Tahribat ";
                bD.Text = "D) Trafik kazası ";
                label7.Text = "D) Trafik kazası ";
            }


            if (soruNo ==40 )
            {
                richTextBox1.Text = " Araçların durma ve duraklama halleri dışında, genelde uzun süreli olarak bekletilmek üzere bırakılmasına ne ad verilir?";
                bA.Text = "A) Park etme ";
                bB.Text = " B) İşaretleme";
                bC.Text = "C) Trafik kazası ";
                bD.Text = "D) Trafikten men ";
                label7.Text = "A) Park etme ";
            }


            if (soruNo == 41)
            {
                richTextBox1.Text = "Aşağıdakilerin hangisinde oturuş pozisyona alınırlar? ";
                bA.Text = "A) Başa darbe sonucu, kulaktan kanaması olanlar ";
                bB.Text = "B) Solunum yolu zehirlenmesi olanlar  ";
                bC.Text = "C) Kusan hastalar  ";
                bD.Text = " D) Göğüs yarası olanlar";
                label7.Text = "B) Solunum yolu zehirlenmesi olanlar  ";
            }


            if (soruNo ==42 )
            {
                richTextBox1.Text = " Aşağıdakilerden hangisi trafik kazalarının sebeplerinden birisidir?";
                bA.Text = " A) Hatalı park etmiş araçlar";
                bB.Text = "B) Tarlada çift sürülen aracın arızalı olması ";
                bC.Text = "C) Trenlerde hız sınırlarının yüksek olması  ";
                bD.Text = "D) Karayolu dışında çalışan iş makinelerinin arıza yapması ";
                label7.Text = " A) Hatalı park etmiş araçlar";
            }


            if (soruNo ==43 )
            {
                richTextBox1.Text = " Alkollü içki içen bir sürücüde aşağıdaki durumlardan hangisi görülür?";
                bA.Text = "A) Dinç ve zinde olma ";
                bB.Text = " B) Reflekslerinde zayıflama ";
                bC.Text = "C) Manevra kabiliyetinde artma ";
                bD.Text = "D) Aşırı hareketli ve uyumlu olma ";
                label7.Text = " B) Reflekslerinde zayıflama ";
            }


            if (soruNo ==44 )
            {
                richTextBox1.Text = "Bir kavşakta sağa dönecek olan sürücünün aşağıdakilerden hangisini yapması yanlıştır? ";
                bA.Text = "A) Hızını azaltması ";
                bB.Text = " B) Dönüş işareti vermesi";
                bC.Text = " C) Geniş bir kavisle dönmesi";
                bD.Text = "D) Sağ şeride veya işaretlerle dönüş izni verilen şeride girmesi ";
                label7.Text = " C) Geniş bir kavisle dönmesi";
            }


            if (soruNo == 45)
            {
                richTextBox1.Text = "Karlı havada zincir takmaya çalışan bir sürücünün sorununa, bu konuda daha deneyimli ve becerikli diğer bir sürücünün çözüm bulması, trafikte hangi temel değere sahip olunduğunu gösterir? ";
                bA.Text = "A) Trafik kültüründe birbirini uyarma ";
                bB.Text = "B) Kendini eleştirme ";
                bC.Text = "C) Yardımlaşma ";
                bD.Text = "D) İnatlaşma ";
                label7.Text = "C) Yardımlaşma ";
            }


            if (soruNo == 46)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi toplardamar kanamalarına ait bir özelliktir? ";
                bA.Text = "A) Kesik kesik akan bir kanama olması ";
                bB.Text = " B) Kalp atımları ile uyumlu olarak akması";
                bC.Text = "C) Koyu kırmızı renkteki kanın sürekli akması ";
                bD.Text = "D) Parlak ve açık kırmızı renkteki kanın fışkırır tarzda akması ";
                label7.Text = "C) Koyu kırmızı renkteki kanın sürekli akması ";
            }


            if (soruNo ==47 )
            {
                richTextBox1.Text = "Sürücüler; yaya ve okul geçitlerine yaklaşırken, görüş yetersizliği olan tepe üstü ve dönemeçlerde aşağıdakilerden hangisini yapmalıdır? ";
                bA.Text = "A) Hızını azaltmalı ";
                bB.Text = " B) Öndeki aracı geçmeli";
                bC.Text = "C) En sol şeritten gitmeli ";
                bD.Text = " D) Dörtlü ikaz ışıklarını yakmalı";
                label7.Text = "A) Hızını azaltmalı ";
            }


            if (soruNo == 48)
            {
                richTextBox1.Text = " I. Lastik hava basınçlarının ve yakıt seviyesinin kontrol edilmesi\r\nII. Aydınlatma ve sinyal sisteminin düzgün çalışıp çalışmadığının kontrol edilmesi\r\nIII. Ön koltuklar, kafalıkları ve aynanın beden ölçülerine uygun olarak ayarlanması\r\n\r\n\r\nVerilenlerden hangileri, aracı kullanmaya başlamadan önce yapılması gereken hazırlıklardandır?";
                bA.Text = "A) Yalnız I ";
                bB.Text = " B) Yalnız II";
                bC.Text = " C) Yalnız III";
                bD.Text = "D) I, II ve III. ";
                label7.Text = "D) I, II ve III. ";
            }


            if (soruNo ==49 )
            {
                richTextBox1.Text = "Aksine bir durum yoksa saatte 100 kilometre hızla seyreden bir sürücü, önündeki araca en fazla kaç metre yaklaşabilir? ";
                bA.Text = "20 ";
                bB.Text = " 30";
                bC.Text = "40 ";
                bD.Text = "50 ";
                label7.Text = "50 ";
               


            if (soruNo == 50)
            {
                richTextBox1.Text = "• Kısa süreli, yüzeysel ve geçicidir.\r\n• Beyne giden kan akışının azalması sonucu oluşur.\r\n\r\nYukarıda özellikleri verilen bilinç kaybı hâli hangisidir? ";
                bA.Text = "A) Bayılma ";
                bB.Text = "B) Şok ";
                bC.Text = " C) Kansızlık";
                bD.Text = "D) Koma ";
                label7.Text = "A) Bayılma ";
                  

                }

        }

 }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bBİTİR_Click(object sender, EventArgs e)
        {

            br.Show();
            this.Hide();
            br.textBox2.Text = doğru.ToString();
            br.textBox3.Text = yanlıs.ToString();
            if (doğru >= 35)
            {

                br.groupBox3.BackColor = Color.Green;
                br.label6.Text = "TEBRİKLER SINAVI BAŞARIYLA GEÇTİNİZ";
                br.label7.Text = "EHLİYET ALMAYA HAK KAZANDINIZ";
                br.pictureCONG.Enabled = true;
                br.pictureCONG.Visible = true;

            }
            else
            {

                br.groupBox3.BackColor = Color.Red;
                br.label6.Text = "MAALESEF BAŞARISIZ OLDUNUZ";
                br.label7.Text = "SONRAKİ SINAV TARİHİNDE TEKRAR DENEYİN";
                br.pictureDİSS.Enabled = true;
                br.pictureDİSS.Visible = true;


            }

        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bA_Click(object sender, EventArgs e)
        {

            if (bA.Text == label7.Text)
            {
                doğru = doğru + 1;
                

                lbldogru.Text = doğru.ToString();
                bA.BackColor = Color.Green;
            }
            else
            {
                yanlıs = yanlıs + 1;
               

                lblyanlış.Text = yanlıs.ToString();
                bA.BackColor = Color.Red; 

               
                 if (bB.Text == label7.Text)
                {
                    bB.BackColor = Color.Green;
                }
                else if (bC.Text == label7.Text)
                {
                    bC.BackColor = Color.Green;
                }
                else if (bD.Text == label7.Text)
                {
                    bD.BackColor = Color.Green;
                }

            }

            if (soruNo != 50)
            {
                bA.Enabled = false;
                bB.Enabled = false;
                bC.Enabled = false;
                bD.Enabled = false;
                button1.Enabled = true;

            }
            else if (soruNo == 50)
            {
                bA.Enabled = false;
                bB.Enabled = false;
                bC.Enabled = false;
                bD.Enabled = false;
                button1.Enabled = false;
                bBİTİR.Enabled = true;

            }
        }
    }
}
