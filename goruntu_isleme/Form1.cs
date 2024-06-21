using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace goruntu_isleme
{
    public partial class Form1 : Form
    {

        private Bitmap originalImage;
        private Bitmap processedImage;
        public Stack<Bitmap> imageHistory = new Stack<Bitmap>();




        public Form1()
        {
            InitializeComponent();
        }
        private void AddToHistory(Bitmap image)
        {
            // Derin kopyalama yaparak mevcut görüntüyü yığına ekleyin
            imageHistory.Push(new Bitmap(image));
        }
        private void UndoLastOperation()
        {
            if (imageHistory.Count > 0)
            {
                processedImage = imageHistory.Pop();
                pictureBox1.Image = processedImage;
                pictureBox2.Image = null;
            }
            else
            {
                MessageBox.Show("Geri alacak bir işlem yok.");
            }
        }

        private void ResimSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files (*.bmp, *.jpeg, *.png, *.gif)|*.bmp;*.jpeg;*.png;*.gif"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                originalImage = new Bitmap(imagePath);
                pictureBox1.Image = originalImage;
            }
        }

        private void KaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResmiKaydet();
        }

        private void SilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Resimtemizle();
        }

        private void GriDönüşümToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckImageAndApplyOperation(() =>
            {
                AddToHistory(originalImage);

                processedImage = GriYap(originalImage);
                pictureBox2.Image = processedImage;

            });
        }

        private void BToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckImageAndApplyOperation(() =>
            {
                AddToHistory(originalImage);
                processedImage = BinaryYap(originalImage);
                pictureBox2.Image = processedImage;

            });
        }

        private void GörüntüDöndürmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckImageAndApplyOperation(() =>
            {
                string dondurmeinput = "Çevirmek İstediğiniz Açıyı Giriniz";
                DialogResult result1 = ShowInputDialog(ref dondurmeinput);

                if (result1 == DialogResult.OK)
                {
                    AddToHistory(originalImage);
                    processedImage = Dondurme(originalImage, Convert.ToInt32(dondurmeinput));
                    pictureBox2.Image = processedImage;
                }
                else
                {
                    Console.WriteLine("Kullanıcı işlemi iptal etti.");
                }
            });
        }

        private void GörüntüKırpmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckImageAndApplyOperation(() =>
            {
                string x1 = "x1";
                string y1 = "y1";
                string x2 = "x2";
                string y2 = "y2";

                DialogResult result2 = KirmpaDialog(ref x1, ref y1, ref x2, ref y2);

                if (result2 == DialogResult.OK)
                {
                    AddToHistory(originalImage);
                    processedImage = GoruntuKirpma(originalImage, Convert.ToInt32(x1), Convert.ToInt32(y1), Convert.ToInt32(x2), Convert.ToInt32(y2));
                    pictureBox2.Image = processedImage;
                }
                else
                {
                    Console.WriteLine("Kullanıcı işlemi iptal etti.");
                }

            });
        }

     


        private void RenkUzayıDönüşümüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckImageAndApplyOperation(() =>
            {
                AddToHistory(originalImage);
                renkuzayi();
            });
        }

        private void KontrastArttırmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckImageAndApplyOperation(() =>
            {
                string kontrastseviyesi = "Kontrast Değerini Giriniz";
                DialogResult result = ShowInputDialog(ref kontrastseviyesi);

                if (result == DialogResult.OK)
                {
                    AddToHistory(originalImage);
                    Kontrast(Convert.ToInt32(kontrastseviyesi));
                }
                else
                {
                    Console.WriteLine("Kullanıcı işlemi iptal etti.");
                }
            });
        }

        private void OrijinalHistogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckImageAndApplyOperation(() =>
            {
                AddToHistory(originalImage);
                ResminHistograminiCiz();
            });
        }

        private void GermeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckImageAndApplyOperation(() =>
            {
                AddToHistory(originalImage);
                Histogramgerme(originalImage);
            });
        }

        private void GenişletmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckImageAndApplyOperation(() =>
            {
                AddToHistory(originalImage);
                HistogramGenisletme(20, 170);
            });

        }

        private void EklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckImageAndApplyOperation(() =>
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "Image Files (*.bmp, *.jpg, *.png, *.gif)|*.bmp;*.jpg;*.png;*.gif"
                };
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    AddToHistory(originalImage);
                    string imagePath = openFileDialog.FileName;
                    originalImage = new Bitmap(imagePath);
                    pictureBox2.Image = originalImage;
                }
                Bitmap processedImage = Ekleme();
                lblsonuc.Text = "Eklenen Görüntü";
                ShowProcessDialog(processedImage);


            });
        }

        private void BölmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckImageAndApplyOperation(() =>
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "Image Files (*.bmp, *.jpg, *.png, *.gif)|*.bmp;*.jpg;*.png;*.gif"
                };
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    AddToHistory(originalImage);
                    string imagePath = openFileDialog.FileName;
                    originalImage = new Bitmap(imagePath);
                    pictureBox2.Image = originalImage;
                }
                Bitmap processedImage = Bölme();
                lblsonuc.Text = "Eklenen Görüntü";
                ShowProcessDialog(processedImage);


            });
        }

        private void MeanFiltresiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckImageAndApplyOperation(() =>
            {
                AddToHistory(originalImage);
                pictureBox2.Image = MeanFiltresi();
            });
        }

        private void TekEşiklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CheckImageAndApplyOperation(() =>
            {
                string esikleme = "Eşikleme Sınırını Giriniz";
                DialogResult result1 = ShowInputDialog(ref esikleme);

                if (result1 == DialogResult.OK)
                {
                    AddToHistory(originalImage);
                    processedImage = Resimesikleme(Convert.ToInt32(esikleme));
                    pictureBox2.Image = processedImage;
                }
                else
                {
                    Console.WriteLine("Kullanıcı işlemi iptal etti.");
                }
            });
        }


        private void KenarBulmaPrewitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckImageAndApplyOperation(() =>
            {
                AddToHistory(originalImage);
                Prewitt();
            });
        }

        private void UnsharpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckImageAndApplyOperation(() =>
            {

                Bitmap originalImage = new Bitmap(pictureBox1.Image);

                // Unsharp mask filtresi uygulanacak parametreleri belirleme
                double[,] kernel = {
                { -1, -1, -1 },
                { -1,  9, -1 },
                { -1, -1, -1 }
                              };
                double factor = 1.0;
                double bias = 2.0;
                AddToHistory(originalImage);

                // Görüntüye Unsharp mask filtresini uygulama
                Bitmap sharpenedImage = Unsharp(originalImage, kernel, factor, bias);
                pictureBox2.Image = sharpenedImage;

            });
        }

        private void SaltPepperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckImageAndApplyOperation(() =>
            {
                AddToHistory(originalImage);
                Bitmap gurultuluresim = SaltAndPepperNoise();
                pictureBox2.Image = gurultuluresim;

            });

        }

        private void MeanGürültüTemizlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckImageAndApplyOperation(() =>
            {


                AddToHistory(originalImage);
                // Gürültülü görüntü oluştur
                Bitmap noisyImage = SaltAndPepperNoise();
                pictureBox1.Image = noisyImage;

                // Mean filtresi uygula
                int filterSize = 6; // Filtre boyutunu istediğiniz değere ayarlayabilirsiniz
                Bitmap filteredImage = MeanFilter(noisyImage, filterSize);

                // Sonucu göster
                pictureBox2.Image = filteredImage;



            });
        }

        public Bitmap MeanFilter(Bitmap noisyImage, int filterSize)
        {
            Bitmap filteredImage = new Bitmap(noisyImage.Width, noisyImage.Height);

            // Filtre boyutunun yarısını hesapla
            int halfFilterSize = filterSize / 2;

            // Her piksel için filtre uygula
            for (int y = 0; y < noisyImage.Height; y++)
            {
                for (int x = 0; x < noisyImage.Width; x++)
                {
                    // Pikselin etrafındaki pikselleri topla
                    int totalR = 0, totalG = 0, totalB = 0;
                    int pixelCount = 0;

                    for (int offsetY = -halfFilterSize; offsetY <= halfFilterSize; offsetY++)
                    {
                        for (int offsetX = -halfFilterSize; offsetX <= halfFilterSize; offsetX++)
                        {
                            int newX = x + offsetX;
                            int newY = y + offsetY;

                            // Kenar pikselleri kontrol et
                            if (newX >= 0 && newX < noisyImage.Width && newY >= 0 && newY < noisyImage.Height)
                            {
                                Color pixelColor = noisyImage.GetPixel(newX, newY);
                                totalR += pixelColor.R;
                                totalG += pixelColor.G;
                                totalB += pixelColor.B;
                                pixelCount++;
                            }
                        }
                    }

                    // Ortalama değerleri hesapla
                    int avgR = totalR / pixelCount;
                    int avgG = totalG / pixelCount;
                    int avgB = totalB / pixelCount;

                    // Yeni pikseli oluştur ve filtrelenmiş görüntüye ekle
                    Color newColor = Color.FromArgb(avgR, avgG, avgB);
                    filteredImage.SetPixel(x, y, newColor);
                }
            }

            return filteredImage;
        }



        private void MedianGürültüTemizlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckImageAndApplyOperation(() => {
                // Gürültülü görüntü oluştur
                AddToHistory(originalImage);
                Bitmap noisyImage = SaltAndPepperNoise();
                pictureBox1.Image = noisyImage;

                // Mean filtresi uygula
                int filterSize = 6; // Filtre boyutunu istediğiniz değere ayarlayabilirsiniz
                Bitmap filteredImage = MedianFilter(noisyImage, filterSize);

                // Sonucu göster
                pictureBox2.Image = filteredImage;

            });
        }

        public Bitmap MedianFilter(Bitmap noisyImage, int filterSize)// pixellerin ortalamasını alıp farklı olana yazar örn:200
        {

            Bitmap filteredImage = new Bitmap(noisyImage.Width, noisyImage.Height);

            // Filtre boyutunun yarısını hesapla
            int halfFilterSize = filterSize / 2;

            // Her piksel için filtre uygula
            for (int y = 0; y < noisyImage.Height; y++)
            {
                for (int x = 0; x < noisyImage.Width; x++)
                {
                    // Pikselin etrafındaki pikselleri topla
                    List<int> rValues = new List<int>();
                    List<int> gValues = new List<int>();
                    List<int> bValues = new List<int>();

                    for (int offsetY = -halfFilterSize; offsetY <= halfFilterSize; offsetY++)
                    {
                        for (int offsetX = -halfFilterSize; offsetX <= halfFilterSize; offsetX++)
                        {
                            int newX = x + offsetX;
                            int newY = y + offsetY;

                            // Kenar pikselleri kontrol et
                            if (newX >= 0 && newX < noisyImage.Width && newY >= 0 && newY < noisyImage.Height)
                            {
                                Color pixelColor = noisyImage.GetPixel(newX, newY);
                                rValues.Add(pixelColor.R);
                                gValues.Add(pixelColor.G);
                                bValues.Add(pixelColor.B);
                            }
                        }
                    }

                    // Ortanca değerleri hesapla
                    rValues.Sort();
                    gValues.Sort();
                    bValues.Sort();
                    int medianR = rValues[rValues.Count / 2];
                    int medianG = gValues[gValues.Count / 2];
                    int medianB = bValues[bValues.Count / 2];

                    // Yeni pikseli oluştur ve filtrelenmiş görüntüye ekle
                    Color newColor = Color.FromArgb(medianR, medianG, medianB);
                    filteredImage.SetPixel(x, y, newColor);
                }
            }

            return filteredImage;
        }

        private void GenişlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckImageAndApplyOperation(() =>
            {
                AddToHistory(originalImage);
                Bitmap binaryimage = BinaryYap(originalImage);
                // Genişleme işlemi için kernel oluştur
                int[,] kernel = new int[,] {
            { 1, 1, 1 },
            { 1, 1, 1 },
            { 1, 1, 1 }
        };

                Bitmap resultImage = Morfolojikgenisleme(originalImage);

                pictureBox2.Image = resultImage;
            });
        }

        private void AşınmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckImageAndApplyOperation(() =>
            {
                AddToHistory(originalImage);
                Bitmap binaryimage = BinaryYap(originalImage);
                // Genişleme işlemi için kernel oluştur
                int[,] kernel = new int[,] {
            { 1, 1, 1 },
            { 1, 1, 1 },
            { 1, 1, 1 }
        };

                // Genişleme işlemi uygula
                Bitmap resultImage = Morfolojikasinma(binaryimage, kernel);

                // PictureBox 2'ye sonucu göster
                pictureBox2.Image = resultImage;
            });

        }

        private void AçmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckImageAndApplyOperation(() =>
            {
                AddToHistory(originalImage);
                Bitmap binaryimage = BinaryYap(originalImage);
                int[,] kernel = new int[,] {
            { 1, 1, 1 },
            { 1, 1, 1 },
            { 1, 1, 1 }
        };

                Bitmap resultImage = Morfolojikaçma(binaryimage, kernel);

                pictureBox2.Image = resultImage;
            });
        }

        private void KaptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckImageAndApplyOperation(() =>
            {
                AddToHistory(originalImage);
                Bitmap binaryimage = BinaryYap(originalImage);
                int[,] kernel = new int[,] {
            { 1, 1, 1 },
            { 1, 1, 1 },
            { 1, 1, 1 }
        };

                Bitmap resultImage = Morfolojikkapama(binaryimage, kernel);

                pictureBox2.Image = resultImage;
            });
        }

        public Bitmap GriYap(Bitmap originalImage)
        {
            Bitmap grayscaleImage = new Bitmap(originalImage.Width, originalImage.Height);

            for (int y = 0; y < originalImage.Height; y++)
            {
                for (int x = 0; x < originalImage.Width; x++)
                {
                    Color pixelColor = originalImage.GetPixel(x, y);
                    int grayValue = (int)(pixelColor.R * 0.3 + pixelColor.G * 0.59 + pixelColor.B * 0.11);

                    Color grayscaleColor = Color.FromArgb(grayValue, grayValue, grayValue);
                    grayscaleImage.SetPixel(x, y, grayscaleColor);
                }
            }

            return grayscaleImage;
        }





        private Bitmap BinaryYap(Bitmap bmp)
        {
            Bitmap gri = GriYap(bmp);
            int esik = EsikBul(gri);
            Color renk;
            for (int i = 0; i < gri.Height - 1; i++)
            {
                for (int j = 0; j < gri.Width - 1; j++)
                {
                    int tmp = gri.GetPixel(j, i).G;
                    if (tmp < esik)
                    {
                        renk = Color.FromArgb(0, 0, 0);
                        gri.SetPixel(j, i, renk);
                    }
                    else
                    {
                        renk = Color.FromArgb(255, 255, 255);
                        gri.SetPixel(j, i, renk);
                    }
                }

            }

            return gri;
        }
        private int EsikBul(Bitmap gri)
        {
            int enb = gri.GetPixel(0, 0).G;
            int enk = gri.GetPixel(0, 0).G;
            for (int i = 0; i < gri.Height - 1; i++)
            {
                for (int j = 0; j < gri.Width - 1; j++)
                {
                    if (enb > gri.GetPixel(j, i).G)
                        enb = gri.GetPixel(j, i).G;
                    if (enk < gri.GetPixel(j, i).G)
                        enk = gri.GetPixel(j, i).G;

                }
            }
            int a = enb;
            int b = enk;
            int esik = (a + b) / 2;
            return esik;
        }
    
        public Bitmap Dondurme(Bitmap GirisResim, int Aci)
        {
            Color OkunanRenk;
            Bitmap CikisResim;
            int ResimGenisligi = GirisResim.Width;
            int ResimYuksekligi = GirisResim.Height;
            CikisResim = new Bitmap(ResimGenisligi, ResimYuksekligi);
            double RadyanAci = Aci * 2 * Math.PI / 360;
            // Resim merkezini buluyor. Resim merkezi etrafında döndürecek.
            int x0 = ResimGenisligi / 2;
            int y0 = ResimYuksekligi / 2;
            for (int x1 = 0; x1 < (ResimGenisligi); x1++)
            {
                for (int y1 = 0; y1 < (ResimYuksekligi); y1++)
                {
                    OkunanRenk = GirisResim.GetPixel(x1, y1);
                    // Döndürme Formülleri
                    double x2 = Math.Cos(RadyanAci) * (x1 - x0) - Math.Sin(RadyanAci) * (y1 - y0) + x0;
                    double y2 = Math.Sin(RadyanAci) * (x1 - x0) + Math.Cos(RadyanAci) * (y1 - y0) + y0;
                    if (x2 > 0 && x2 < ResimGenisligi && y2 > 0 && y2 < ResimYuksekligi)
                        CikisResim.SetPixel((int)x2, (int)y2, OkunanRenk);
                }
            }
            return CikisResim;
        }
        public Bitmap GoruntuKirpma(Bitmap originalImage, int startX, int startY, int width, int height)
        {
           
            Bitmap croppedImage = new Bitmap(width, height);

            // Pikselleri doğrudan kopyalayarak kırpılmış görüntüyü oluşturun
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    // Orijinal görüntüden pikseli al
                    Color pixelColor = originalImage.GetPixel(startX + x, startY + y);

                    // Kırpılmış görüntüye pikseli yerleştir
                    croppedImage.SetPixel(x, y, pixelColor);
                }
            }

            // Kırpılmış görüntüyü döndürün
            return croppedImage;
        }

       

        public void Kontrast(int deger)
        {
            Color OkunanRenk, DonusenRenk;
            Bitmap GirisResmi, CikisResmi;

            GirisResmi = new Bitmap(pictureBox1.Image);
            int ResimGenisligi = GirisResmi.Width; // Giriş resmi global tanımlandı.
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi); // Çıkış resmini oluşturuyor. Boyutları 


            double F_KontrastFaktoru = (259 * (deger + 255)) / (255 * (259 - deger));

            for (int x = 0; x < ResimGenisligi; x++)
            {
                for (int y = 0; y < ResimYuksekligi; y++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x, y);
                    int R = OkunanRenk.R;
                    int G = OkunanRenk.G;
                    int B = OkunanRenk.B;

                    R = (int)((F_KontrastFaktoru * (R - 128)) + 128); //Bu formül, her renk bileşenini (kırmızı, yeşil, mavi) yeniden ölçeklendirir
                                                                      //ve merkezi 128'e kaydırır, bu da kontrast ayarını gerçekleştirir.
                    G = (int)((F_KontrastFaktoru * (G - 128)) + 128);
                    B = (int)((F_KontrastFaktoru * (B - 128)) + 128);

                    // Renkler sınırların dışına çıktıysa, sınır değer alınacak.
                    if (R > 255) R = 255;
                    if (G > 255) G = 255;
                    if (B > 255) B = 255;
                    if (R < 0) R = 0;
                    if (G < 0) G = 0;
                    if (B < 0) B = 0;

                    DonusenRenk = Color.FromArgb(R, G, B);
                    CikisResmi.SetPixel(x, y, DonusenRenk);
                }
            }

            pictureBox2.Image = CikisResmi;

        }
        private void Histogramgerme(Bitmap inputImage)
        {
            int width = inputImage.Width;
            int height = inputImage.Height;
            Bitmap outputImage = new Bitmap(width, height);

            int min = 0;
            int max = 255;

            ArrayList DiziPiksel = new ArrayList();

            // Minimum ve maksimum parlaklık değerlerini bul
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixelColor = inputImage.GetPixel(x, y);
                    int intensity = pixelColor.R; // Gri tonlama görüntü için R, G, B aynı değerdedir

                    if (intensity < min)
                    {
                        min = intensity;
                    }

                    if (intensity > max)
                    {
                        max = intensity;
                    }
                }
            }

            // Kontrast germe işlemi yap
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixelColor = inputImage.GetPixel(x, y);
                    int intensity = pixelColor.R;

                    // Yeni parlaklık değeri hesapla
                    int newIntensity = (int)((double)(intensity - min) / (max - min) * 255);

                    // Yeni piksel rengini ayarla
                    Color newPixelColor = Color.FromArgb(newIntensity, newIntensity, newIntensity);
                    outputImage.SetPixel(x, y, newPixelColor);
                    DiziPiksel.Add(newIntensity);
                }
            }

            // Histogramı çizdir
            int[] DiziPikselSayilari = new int[256];
            for (int r = 0; r < 255; r++)
            {
                int PikselSayisi = 0;
                for (int s = 0; s < DiziPiksel.Count; s++)
                {
                    if (r == Convert.ToInt16(DiziPiksel[s]))
                        PikselSayisi++;
                }
                DiziPikselSayilari[r] = PikselSayisi;
            }

            int RenkMaksPikselSayisi = 0;
            for (int k = 0; k <= 255; k++)
            {
                if (DiziPikselSayilari[k] > RenkMaksPikselSayisi)
                {
                    RenkMaksPikselSayisi = DiziPikselSayilari[k];
                }
            }

            Graphics CizimAlani;
            Pen Kalem1 = new Pen(System.Drawing.Color.Blue, 1);
            Pen Kalem2 = new Pen(System.Drawing.Color.Red, 1);
            CizimAlani = pictureBox2.CreateGraphics();

            pictureBox2.Refresh();
            int GrafikYuksekligi = 330;
            double OlcekY = RenkMaksPikselSayisi / GrafikYuksekligi, OlcekX = 1.6;
            for (int x = 0; x <= 255; x++)
            {
                CizimAlani.DrawLine(Kalem1, (int)(20 + x * OlcekX), GrafikYuksekligi, (int)(20 + x * OlcekX), (GrafikYuksekligi - (int)(DiziPikselSayilari[x] / OlcekY)));
                if (x % 50 == 0)
                    CizimAlani.DrawLine(Kalem2, (int)(20 + x * OlcekX), GrafikYuksekligi, (int)(20 + x * OlcekX), 0);

            }
            pictureBox1.Refresh();
            pictureBox1.Image = null;
            pictureBox1.Image = outputImage;
        }
       

        private void HistogramGenisletme(int deger1, int deger2)
        {
            Color OkunanRenk, DonusenRenk;
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);
            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
            int X1 = deger1;
            int X2 = deger2;
            int A = 0; // yeni sınırlar 
            int b1 = 255; // yeni sınırlar 

            ArrayList DiziPiksel = new ArrayList();

            for (int x = 0; x < ResimGenisligi; x++)
            {
                for (int y = 0; y < ResimYuksekligi; y++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x, y);
                    int R = OkunanRenk.R;
                    int G = OkunanRenk.G;
                    int B = OkunanRenk.B;

                    // Gri seviyesini hesapla
                    int Gri = (R + G + B) / 3;

                    // Histogram genişletme işlemi
                    int YeniGri = (int)(((Gri - X1) / (double)(X2 - X1)) * (b1 - A) + A);
                    //Gri Değerin Normalleştirilmesi   //Normalleştirilmiş Gri Değerin Aralık ile Bölünmesi:  //Yeni Aralığa Genişletme:


                    // Sınırları kontrol et
                    if (YeniGri > 255) YeniGri = 255;
                    if (YeniGri < 0) YeniGri = 0;

                    // Yeni rengi oluştur
                    DonusenRenk = Color.FromArgb(YeniGri, YeniGri, YeniGri);

                    // Çıkış resmindeki pikseli ayarla
                    CikisResmi.SetPixel(x, y, DonusenRenk);

                    // Histogram için gri değerleri dizisine ekle
                    DiziPiksel.Add(YeniGri);
                }
            }

            // Histogramı çizdir
            int[] DiziPikselSayilari = new int[256];
            for (int r = 0; r < 255; r++)
            {
                int PikselSayisi = 0;
                for (int s = 0; s < DiziPiksel.Count; s++)
                {
                    if (r == Convert.ToInt16(DiziPiksel[s]))
                        PikselSayisi++;
                }
                DiziPikselSayilari[r] = PikselSayisi;
            }

            int RenkMaksPikselSayisi = 0;
            for (int k = 0; k <= 255; k++)
            {
                if (DiziPikselSayilari[k] > RenkMaksPikselSayisi)
                {
                    RenkMaksPikselSayisi = DiziPikselSayilari[k];
                }
            }

            Graphics CizimAlani;
            Pen Kalem1 = new Pen(System.Drawing.Color.Blue, 1);
            Pen Kalem2 = new Pen(System.Drawing.Color.Red, 1);
            CizimAlani = pictureBox2.CreateGraphics();

            pictureBox2.Refresh();
            int GrafikYuksekligi = 330;
            double OlcekY = RenkMaksPikselSayisi / GrafikYuksekligi, OlcekX = 1.6;
            for (int x = 0; x <= 255; x++)
            {
                CizimAlani.DrawLine(Kalem1, (int)(20 + x * OlcekX), GrafikYuksekligi, (int)(20 + x * OlcekX), (GrafikYuksekligi - (int)(DiziPikselSayilari[x] / OlcekY)));
                if (x % 50 == 0)
                    CizimAlani.DrawLine(Kalem2, (int)(20 + x * OlcekX), GrafikYuksekligi, (int)(20 + x * OlcekX), 0);

            }
            pictureBox1.Refresh();
            pictureBox1.Image = null;
            pictureBox1.Image = CikisResmi;
        }

        public void ResminHistograminiCiz()
        {
            pictureBox2.Image = null;

            ArrayList DiziPiksel = new ArrayList();

      
            Color OkunanRenk;

            Bitmap GirisResmi; //Histogram için giriş resmi gri-ton olmalıdır.
            GirisResmi = new Bitmap(pictureBox1.Image);

            Bitmap GriResim = GriYap(GirisResmi); //Giriş resmi global olduğu için burada götürmüyor.
            pictureBox1.Image = GriResim;

          

            for (int x = 0; x < GirisResmi.Width; x++)
            {
                for (int y = 0; y < GirisResmi.Height; y++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x, y);
                  

                    DiziPiksel.Add(OkunanRenk.R); //Gri resim olduğu için tek kanalı okuması yeterli olacaktır. 
                }

            }

            int[] DiziPikselSayilari = new int[256];
            for (int r = 0; r < 255; r++) //256 tane renk tonu için dönecek.
            {
                int PikselSayisi = 0;
                for (int s = 0; s < DiziPiksel.Count; s++) //resimdeki piksel sayısınca dönecek. 
                {
                    if (r == Convert.ToInt16(DiziPiksel[s]))
                        PikselSayisi++;
                }
                DiziPikselSayilari[r] = PikselSayisi;
            }

            int RenkMaksPikselSayisi = 0; //Grafikte y eksenini ölçeklerken kullanılacak. 
            for (int k = 0; k <= 255; k++)
            {

                if (DiziPikselSayilari[k] > RenkMaksPikselSayisi)
                {
                    RenkMaksPikselSayisi = DiziPikselSayilari[k];
                }
            }

            //Grafiği çiziyor. 
            Graphics CizimAlani;
            Pen Kalem1 = new Pen(System.Drawing.Color.Blue, 1);
            Pen Kalem2 = new Pen(System.Drawing.Color.Red, 1);
            CizimAlani = pictureBox2.CreateGraphics();

            pictureBox2.Refresh();
            int GrafikYuksekligi = 330;
            double OlcekY = RenkMaksPikselSayisi / GrafikYuksekligi, OlcekX = 1.6;
            for (int x = 0; x <= 255; x++)
            {
                CizimAlani.DrawLine(Kalem1, (int)(20 + x * OlcekX), GrafikYuksekligi, (int)(20 + x * OlcekX), (GrafikYuksekligi - (int)(DiziPikselSayilari[x] / OlcekY)));
                if (x % 50 == 0)
                    CizimAlani.DrawLine(Kalem2, (int)(20 + x * OlcekX), GrafikYuksekligi, (int)(20 + x * OlcekX), 0);

            }

        }

        
        public Bitmap MeanFiltresi()  //3*3lük matriste pixelleri toplayıp 9a bölüp ortasına yazdırır
        {

            Color OkunanRenk;
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);

            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;

            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);


            int SablonBoyutu = 9; //şablon boyutu 3 den büyük tek rakam olmalıdır (3,5,7 gibi).
            int x, y, i, j, toplamR, toplamG, toplamB, ortalamaR, ortalamaG, ortalamaB;

            for (x = (SablonBoyutu - 1) / 2; x < ResimGenisligi - (SablonBoyutu - 1) / 2; x++)
            {
                for (y = (SablonBoyutu - 1) / 2; y < ResimYuksekligi - (SablonBoyutu - 1) / 2; y++)
                {
                    toplamR = 0;
                    toplamG = 0;
                    toplamB = 0;

                    for (i = -((SablonBoyutu - 1) / 2); i <= (SablonBoyutu - 1) / 2; i++)
                    {
                        for (j = -((SablonBoyutu - 1) / 2); j <= (SablonBoyutu - 1) / 2; j++)
                        {
                            OkunanRenk = GirisResmi.GetPixel(x + i, y + j);

                            toplamR += OkunanRenk.R;
                            toplamG += OkunanRenk.G;
                            toplamB += OkunanRenk.B;

                        }
                    }

                    ortalamaR = toplamR / (SablonBoyutu * SablonBoyutu);
                    ortalamaG = toplamG / (SablonBoyutu * SablonBoyutu);
                    ortalamaB = toplamB / (SablonBoyutu * SablonBoyutu);

                    CikisResmi.SetPixel(x, y, Color.FromArgb(ortalamaR, ortalamaG, ortalamaB));
                }
            }

            return CikisResmi;
        }

        public Bitmap Resimesikleme(int EsiklemeDegeri) // esik değerinin altındakileri siyaha çevirir
        {
            Color OkunanRenk, DonusenRenk;
            Bitmap GirisResmi, CikisResmi, Griresim;
            GirisResmi = new Bitmap(pictureBox1.Image);
            Griresim = GriYap(GirisResmi);
            int ResimGenisligi = Griresim.Width; //GirisResmi global tanımlandı.
            int ResimYuksekligi = Griresim.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi); //Cikis resmini oluşturuyor. Boyutları 


            for (int x = 0; x < ResimGenisligi; x++)
            {
                for (int y = 0; y < ResimYuksekligi; y++)
                {
                    OkunanRenk = Griresim.GetPixel(x, y);
                    int R;
                    if (OkunanRenk.R >= EsiklemeDegeri)
                        R = 255;
                    else
                        R = 0;
                    int G;
                    if (OkunanRenk.G >= EsiklemeDegeri)
                        G = 255;
                    else
                        G = 0;
                    int B;
                    if (OkunanRenk.B >= EsiklemeDegeri)
                        B = 255;
                    else
                        B = 0;
                    DonusenRenk = Color.FromArgb(R, G, B);
                    CikisResmi.SetPixel(x, y, DonusenRenk);
                }
            }
            return CikisResmi;
        }



        public void Prewitt() //kenar bulma//görüntü parlaklığının keskin bir şekilde  değiştiği yerler
        {
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);
            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);

            int SablonBoyutu = 3;
           
            int x, y;
            Color Renk;
            int P1, P2, P3, P4, P5, P6, P7, P8, P9;
            for (x = (SablonBoyutu - 1) / 2; x < ResimGenisligi - (SablonBoyutu - 1) / 2; x++) //Resmi
            {
                for (y = (SablonBoyutu - 1) / 2; y < ResimYuksekligi - (SablonBoyutu - 1) / 2; y++)
                {
                    Renk = GirisResmi.GetPixel(x - 1, y - 1);
                    P1 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = GirisResmi.GetPixel(x, y - 1);
                    P2 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = GirisResmi.GetPixel(x + 1, y - 1);
                    P3 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = GirisResmi.GetPixel(x - 1, y);
                    P4 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = GirisResmi.GetPixel(x, y);
                    P5 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = GirisResmi.GetPixel(x + 1, y);
                    P6 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = GirisResmi.GetPixel(x - 1, y + 1);
                    P7 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = GirisResmi.GetPixel(x, y + 1);
                    P8 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = GirisResmi.GetPixel(x + 1, y + 1);
                    P9 = (Renk.R + Renk.G + Renk.B) / 3;
                    int Gx = Math.Abs(-P1 + P3 - P4 + P6 - P7 + P9); //Dikey çizgileri Bulur
                    int Gy = Math.Abs(P1 + P2 + P3 - P7 - P8 - P9); //Yatay Çizgileri Bulur.
                    int PrewittDegeri = Gx + Gy;
                   
                    if (PrewittDegeri > 255) PrewittDegeri = 255;
                    
                    CikisResmi.SetPixel(x, y, Color.FromArgb(PrewittDegeri, PrewittDegeri, PrewittDegeri));
                }
            }
            pictureBox2.Image = CikisResmi;
        }

      
        // Unsharp mask filtresi uygulamak için metod
        public Bitmap Unsharp(Bitmap image, double[,] kernel, double factor, double bias) // 
        {
            int width = image.Width;
            int height = image.Height;
            Bitmap sharpenedImage = new Bitmap(width, height);

            // Görüntü üzerinde dolaşarak Unsharp mask filtresini uygulama
            for (int y = 1; y < height - 1; y++)
            {
                for (int x = 1; x < width - 1; x++)
                {
                    double red = 0.0, green = 0.0, blue = 0.0;

                    // Kernel matrisi ile piksel komşularının çarpımını hesaplama
                    for (int j = -1; j <= 1; j++)
                    {
                        for (int i = -1; i <= 1; i++)
                        {
                            Color pixel = image.GetPixel(x + i, y + j);
                            red += pixel.R * kernel[i + 1, j + 1];
                            green += pixel.G * kernel[i + 1, j + 1];
                            blue += pixel.B * kernel[i + 1, j + 1];
                        }
                    }

                    // Belirlenen katsayı ve bias ile çarpma işlemi
                    red = Math.Min(Math.Max((factor * red) + bias, 0), 255);
                    green = Math.Min(Math.Max((factor * green) + bias, 0), 255);
                    blue = Math.Min(Math.Max((factor * blue) + bias, 0), 255);

                    // Keskinleştirilmiş pikseli yeni görüntüye ekleme
                    sharpenedImage.SetPixel(x, y, Color.FromArgb((int)red, (int)green, (int)blue));
                }
            }

            return sharpenedImage;
        }

        public Bitmap Bölme()
        {
            Bitmap Resim1, Resim2, CikisResmi;
            Resim1 = new Bitmap(pictureBox1.Image);
            Resim2 = new Bitmap(pictureBox2.Image);
            int ResimGenisligi = Resim1.Width;
            int ResimYuksekligi = Resim1.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
            Color Renk1, Renk2;
            int x, y;
            // Resim boyutlarını alın
            int Resim1Genisligi = Resim1.Width;
            int Resim1Yuksekligi = Resim1.Height;
            int Resim2Genisligi = Resim2.Width;
            int Resim2Yuksekligi = Resim2.Height;

            // Eğer boyutlar farklı ise, Resim2'yi Resim1 ile aynı boyuta getirin
            if (Resim1Genisligi != Resim2Genisligi || Resim1Yuksekligi != Resim2Yuksekligi)
            {
                Resim2 = new Bitmap(Resim1Genisligi, Resim1Yuksekligi);
                using (Graphics g = Graphics.FromImage(Resim2))
                {
                    g.DrawImage(pictureBox2.Image, 0, 0, Resim1Genisligi, Resim1Yuksekligi);
                }
            }
            for (x = 0; x < ResimGenisligi; x++) //Resmi taramaya şablonun yarısı kadar dış kenarlardan

            {
                for (y = 0; y < ResimYuksekligi; y++)
                {
                    Renk1 = Resim1.GetPixel(x, y);
                    Renk2 = Resim2.GetPixel(x, y);
                    if (Renk2.R == 0 || Renk2.G == 0 || Renk2.B == 0)
                    {
                        // Payda sıfır olduğunda işlem atlanabilir veya varsayılan bir değer kullanılabilir
                        // Burada payda sıfır olduğunda bölme işlemi yapılmaz ve pikselin rengi sabitlenir
                        CikisResmi.SetPixel(x, y, Renk1);
                    }
                    else
                    {
                        // Bölme işlemi
                        int R = Renk1.R / Renk2.R;
                        int G = Renk1.G / Renk2.G;
                        int B = Renk1.B / Renk2.B;

                        R = Math.Max(0, R);
                        G = Math.Max(0, G);
                        B = Math.Max(0, B);

                        // Yeni renk oluşturuyoruz
                        Color newColor = Color.FromArgb(R, G, B);

                        // Sonuç görüntüsüne pikseli yerleştiriyoruz
                        CikisResmi.SetPixel(x, y, newColor);
                    }
                }
            }
            return CikisResmi;
        }
        public Bitmap Ekleme()
        {
            Bitmap Resim1, Resim2, CikisResmi;
            Resim1 = new Bitmap(pictureBox1.Image);
            Resim2 = new Bitmap(pictureBox2.Image);
            int ResimGenisligi = Resim1.Width;
            int ResimYuksekligi = Resim1.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
            Color Renk1, Renk2;
            int x, y;
            // Resim boyutlarını alın
            int Resim1Genisligi = Resim1.Width;
            int Resim1Yuksekligi = Resim1.Height;
            int Resim2Genisligi = Resim2.Width;
            int Resim2Yuksekligi = Resim2.Height;

            // Eğer boyutlar farklı ise, Resim2'yi Resim1 ile aynı boyuta getirin
            if (Resim1Genisligi != Resim2Genisligi || Resim1Yuksekligi != Resim2Yuksekligi)
            {
                Resim2 = new Bitmap(Resim1Genisligi, Resim1Yuksekligi);
                using (Graphics g = Graphics.FromImage(Resim2))
                {
                    g.DrawImage(pictureBox2.Image, 0, 0, Resim1Genisligi, Resim1Yuksekligi);
                }
            }
            for (x = 0; x < ResimGenisligi; x++) //Resmi taramaya şablonun yarısı kadar dış kenarlardan
            {
                for (y = 0; y < ResimYuksekligi; y++)
                {
                    Renk1 = Resim1.GetPixel(x, y);
                    Renk2 = Resim2.GetPixel(x, y);
                    int B;
                    int R;
                    int G;
                    //İki resmi direk toplama
                    R = Renk1.R + Renk2.R;
                    G = Renk1.G + Renk2.G;
                    B = Renk1.B + Renk2.B;
                 
                    //Sınırı aşan değerleri 255 ayarlama
                    if (R > 255) R = 255;
                    if (G > 255) G = 255;
                    if (B > 255) B = 255;
                   
                    CikisResmi.SetPixel(x, y, Color.FromArgb(R, G, B));
                }
            }
            return CikisResmi;
        }





        public Bitmap SaltAndPepperNoise()// tuz beyaz biber ise siyahtır bu da görüntüde nokta nokta biber ve tuz imgecikleri açıkca görünür
        {
            double noiseProbability = 0.02;
            Bitmap image = new Bitmap(pictureBox1.Image);
            Random random = new Random();
            Bitmap noisyImage = (Bitmap)image.Clone();

            // Her pikselde gürültü ekleme
            for (int y = 0; y < noisyImage.Height; y++)
            {
                for (int x = 0; x < noisyImage.Width; x++)
                {
                    // Belirli bir olasılıkla gürültü ekleme
                    if (random.NextDouble() < noiseProbability)
                    {
                        // Rastgele olarak pikseli siyah veya beyaz yapma
                        Color noiseColor = (random.NextDouble() < 0.5) ? Color.Black : Color.White;
                        noisyImage.SetPixel(x, y, noiseColor);
                    }
                }
            }

            return noisyImage;
        }



        public Bitmap Morfolojikgenisleme(Bitmap inputImage) // piksel grupları büyür piksel arası boşluklar küçülür.
        {// Giriş görüntüsünü yükleyin
    

            // Genişletme işlemi için boş bir görüntü oluşturun
            Bitmap dilatedImage = new Bitmap(inputImage.Width, inputImage.Height);

            // Yapısal eleman boyutu (3x3)
            int structuringElementSize = 3;
            int offset = structuringElementSize / 2;

            // Genişletme işlemini gerçekleştirin
            for (int y = 0; y < inputImage.Height; y++)
            {
                for (int x = 0; x < inputImage.Width; x++)
                {
                    bool isForeground = false;

                    // Yapısal eleman çevresindeki piksel komşularını kontrol edin
                    for (int dy = -offset; dy <= offset; dy++)
                    {
                        for (int dx = -offset; dx <= offset; dx++)
                        {
                            int nx = x + dx;
                            int ny = y + dy;

                            // Görüntü sınırları içinde olup olmadığını kontrol edin
                            if (nx >= 0 && nx < inputImage.Width && ny >= 0 && ny < inputImage.Height)
                            {
                                // Piksel beyaz mı (ön plan) kontrol edin
                                if (inputImage.GetPixel(nx, ny).R > 0)
                                {
                                    isForeground = true;
                                    break;
                                }
                            }
                        }
                        if (isForeground)
                        {
                            break;
                        }
                    }

                    // Genişletilmiş görüntüdeki pikseli ayarlayın
                    if (isForeground)
                    {
                        dilatedImage.SetPixel(x, y, Color.White);
                    }
                    else
                    {
                        dilatedImage.SetPixel(x, y, Color.Black);
                    }
                }
            }

            return dilatedImage;
        }

        private Bitmap Morfolojikasinma(Bitmap originalImage, int[,] kernel) // bozuk olan görüntü gürültüden arındırılarak temizlenir.
        {
            int imageWidth = originalImage.Width;
            int imageHeight = originalImage.Height;

            Bitmap resultImage = new Bitmap(imageWidth, imageHeight);

            for (int y = 0; y < imageHeight; y++)
            {
                for (int x = 0; x < imageWidth; x++)
                {
                    Color minPixelColor = Color.White;

                    for (int ky = 0; ky < kernel.GetLength(0); ky++)
                    {
                        for (int kx = 0; kx < kernel.GetLength(1); kx++)
                        {
                            int nx = x + kx - 1;
                            int ny = y + ky - 1;

                            if (nx >= 0 && nx < imageWidth && ny >= 0 && ny < imageHeight)
                            {
                                Color pixelColor = originalImage.GetPixel(nx, ny);
                                if (kernel[ky, kx] == 1 && pixelColor.R < minPixelColor.R)
                                {
                                    minPixelColor = pixelColor;
                                }
                            }
                        }
                    }

                    resultImage.SetPixel(x, y, minPixelColor);
                }
            }

            return resultImage;
        }

    
        public Bitmap Morfolojikaçma(Bitmap originalImage, int[,] kernel)
        {
            // Açılma işlemi, önce erozyon sonra genişleme işlemi uygulayarak gerçekleştirilir
            Bitmap intermediateImage = Morfolojikasinma(originalImage, kernel);
            Bitmap resultImage = Morfolojikgenisleme(intermediateImage);

            return resultImage;
        }

       
        public Bitmap Morfolojikkapama(Bitmap originalImage, int[,] kernel)
        {
            // Kapama işlemi, önce genişleme sonra erozyon işlemi uygulayarak gerçekleştirilir
            Bitmap intermediateImage = Morfolojikgenisleme(originalImage);
            Bitmap resultImage = Morfolojikasinma(intermediateImage, kernel);

            return resultImage;
        }



        public void renkuzayi() {

            // PictureBox1'den resmi al
            Bitmap kaynakResim = (Bitmap)pictureBox1.Image;

            // Yeni bir bitmap oluştur
            Bitmap hedefResim = new Bitmap(kaynakResim.Width, kaynakResim.Height, PixelFormat.Format24bppRgb);

            // Renk uzayı dönüşümü yap
            for (int y = 0; y < kaynakResim.Height; y++)
            {
                for (int x = 0; x < kaynakResim.Width; x++)
                {
                    Color piksel = kaynakResim.GetPixel(x, y);

                    // Örnek olarak, her pikselin RGB değerlerini tersine çevirelim
                    int kirmizi = 255 - piksel.R;
                    int yesil = 255 - piksel.G;
                    int mavi = 255 - piksel.B;

                    // Yeni renk oluştur
                    Color yeniRenk = Color.FromArgb(kirmizi, yesil, mavi);

                    // Hedef resimdeki pikseli ayarla
                    hedefResim.SetPixel(x, y, yeniRenk);
                }
            }

            // PictureBox2'ye dönüştürülmüş resmi göster
            pictureBox2.Image = hedefResim;
        }

     
        public void ResmiKaydet()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Filter = "Jpeg Resmi|*.jpg|Bitmap Resmi|*.bmp|Gif Resmi|*.gif",
                Title = "Resmi Kaydet"
            };
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "") //Dosya adı boş değilse kaydedecek.
            {
                // FileStream nesnesi ile kayıtı gerçekleştirecek. 
                FileStream DosyaAkisi = (FileStream)saveFileDialog1.OpenFile();

                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        pictureBox2.Image.Save(DosyaAkisi, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        pictureBox2.Image.Save(DosyaAkisi, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        pictureBox2.Image.Save(DosyaAkisi, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }

                DosyaAkisi.Close();
            }


        }
        public void Resimtemizle()
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
        }

    

       

     

        private static DialogResult ShowProcessDialog(Bitmap image)
        {
            // PictureBox oluştur
            PictureBox pictureBox = new PictureBox
            {
                Image = image,
                SizeMode = PictureBoxSizeMode.AutoSize
            };

            // Form oluştur
            Form processDialog = new Form
            {
                Text = "İşlem Sonucu",
                FormBorderStyle = FormBorderStyle.FixedDialog,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink
            };

            // PictureBox'ı forma ekle
            processDialog.Controls.Add(pictureBox);

            // OK butonu oluştur
            System.Windows.Forms.Button okButton = new System.Windows.Forms.Button
            {
                Text = "OK",
                DialogResult = DialogResult.OK,
                Dock = DockStyle.Bottom
            };

            // OK butonunu forma ekle
            processDialog.Controls.Add(okButton);

            // Dialog sonucunu göster
            DialogResult result = processDialog.ShowDialog();

            return result;
        }
        
        
        private static DialogResult ShowInputDialog(ref string input)
        {
            System.Drawing.Size size = new System.Drawing.Size(200, 70);
            Form inputBox = new Form
            {
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog,
                ClientSize = size,
                Text = "Değeri Giriniz"
            };

            System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox
            {
                Size = new System.Drawing.Size(size.Width - 10, 23),
                Location = new System.Drawing.Point(5, 5),
                Text = input
            };
            inputBox.Controls.Add(textBox);

            System.Windows.Forms.Button okButton = new System.Windows.Forms.Button
            {
                DialogResult = System.Windows.Forms.DialogResult.OK,
                Name = "okButton",
                Size = new System.Drawing.Size(75, 23),
                Text = "&OK",
                Location = new System.Drawing.Point(size.Width - 80 - 80, 39)
            };
            inputBox.Controls.Add(okButton);

            System.Windows.Forms.Button cancelButton = new System.Windows.Forms.Button
            {
                DialogResult = System.Windows.Forms.DialogResult.Cancel,
                Name = "cancelButton",
                Size = new System.Drawing.Size(75, 23),
                Text = "&Cancel",
                Location = new System.Drawing.Point(size.Width - 80, 39)
            };
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            input = textBox.Text;
            return result;
        }
        private static DialogResult KirmpaDialog(ref string input1, ref string input2, ref string input3, ref string input4)
        {
            System.Drawing.Size size = new System.Drawing.Size(400, 150);
            Form inputBox = new Form
            {
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog,
                ClientSize = size,
                Text = "Değerleri Giriniz"
            };

            System.Windows.Forms.TextBox textBox1 = new System.Windows.Forms.TextBox
            {
                Size = new System.Drawing.Size((size.Width - 30) / 2, 23),
                Location = new System.Drawing.Point(10, 10),
                Text = input1
            };
            inputBox.Controls.Add(textBox1);

            System.Windows.Forms.TextBox textBox2 = new System.Windows.Forms.TextBox
            {
                Size = new System.Drawing.Size((size.Width - 30) / 2, 23),
                Location = new System.Drawing.Point(textBox1.Right + 10, 10),
                Text = input2
            };
            inputBox.Controls.Add(textBox2);

            System.Windows.Forms.TextBox textBox3 = new System.Windows.Forms.TextBox
            {
                Size = new System.Drawing.Size((size.Width - 30) / 2, 23),
                Location = new System.Drawing.Point(10, textBox1.Bottom + 10),
                Text = input3
            };
            inputBox.Controls.Add(textBox3);

            System.Windows.Forms.TextBox textBox4 = new System.Windows.Forms.TextBox
            {
                Size = new System.Drawing.Size((size.Width - 30) / 2, 23),
                Location = new System.Drawing.Point(textBox3.Right + 10, textBox1.Bottom + 10),
                Text = input4
            };
            inputBox.Controls.Add(textBox4);

            System.Windows.Forms.Button okButton = new System.Windows.Forms.Button
            {
                DialogResult = System.Windows.Forms.DialogResult.OK,
                Name = "okButton",
                Size = new System.Drawing.Size(75, 23),
                Text = "&OK",
                Location = new System.Drawing.Point(size.Width - 80 - 80, size.Height - 40)
            };
            inputBox.Controls.Add(okButton);

            System.Windows.Forms.Button cancelButton = new System.Windows.Forms.Button
            {
                DialogResult = System.Windows.Forms.DialogResult.Cancel,
                Name = "cancelButton",
                Size = new System.Drawing.Size(75, 23),
                Text = "&Cancel",
                Location = new System.Drawing.Point(size.Width - 80, size.Height - 40)
            };
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            input1 = textBox1.Text;
            input2 = textBox2.Text;
            input3 = textBox3.Text;
            input4 = textBox4.Text;
            return result;
        }
        private void CheckImageAndApplyOperation(Action action)
        {
            if (originalImage != null)
            {
                action();
            }
            else
            {
                MessageBox.Show("Önce bir resim seçmelisiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UndoLastOperation();

        }







        private Bitmap ZoomImage(Bitmap originalBitmap, float zoomLevel)
        {
            int newWidth = (int)(originalBitmap.Width * zoomLevel);
            int newHeight = (int)(originalBitmap.Height * zoomLevel);

            Bitmap zoomedBitmap = new Bitmap(newWidth, newHeight);

            for (int y = 0; y < newHeight; y++)
            {
                for (int x = 0; x < newWidth; x++)
                {
                    int originalX = (int)(x / zoomLevel);
                    int originalY = (int)(y / zoomLevel);

                    if (originalX >= 0 && originalX < originalBitmap.Width && originalY >= 0 && originalY < originalBitmap.Height)
                    {
                        Color originalColor = originalBitmap.GetPixel(originalX, originalY);
                        zoomedBitmap.SetPixel(x, y, originalColor);
                    }
                }
            }

            Bitmap resultBitmap = new Bitmap(originalBitmap.Width, originalBitmap.Height);
            using (Graphics g = Graphics.FromImage(resultBitmap))
            {
                if (zoomLevel >= 1)
                {
                    // Zoom In: Crop from center
                    int cropX = (newWidth - originalBitmap.Width) / 2;
                    int cropY = (newHeight - originalBitmap.Height) / 2;
                    for (int y = 0; y < originalBitmap.Height; y++)
                    {
                        for (int x = 0; x < originalBitmap.Width; x++)
                        {
                            Color color = zoomedBitmap.GetPixel(x + cropX, y + cropY);
                            resultBitmap.SetPixel(x, y, color);
                        }
                    }
                }
                else
                {
                    // Zoom Out: Center the image
                    int offsetX = (originalBitmap.Width - newWidth) / 2;
                    int offsetY = (originalBitmap.Height - newHeight) / 2;
                    for (int y = 0; y < newHeight; y++)
                    {
                        for (int x = 0; x < newWidth; x++)
                        {
                            Color color = zoomedBitmap.GetPixel(x, y);
                            resultBitmap.SetPixel(x + offsetX, y + offsetY, color);
                        }
                    }
                }
            }

            return resultBitmap;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int zoomFactor = 100;

            if (pictureBox1.Image != null)
            {
                Bitmap originalBitmap = new Bitmap(pictureBox1.Image);
                int trackValue = trackBar1.Value;
                float zoomLevel = (float)trackValue / zoomFactor;
                Bitmap zoomedBitmap = ZoomImage(originalBitmap, zoomLevel);
                pictureBox2.Image = zoomedBitmap;

                if (trackBar1.Value == 0)
                {
                    trackBar1.Value = 1;
                }
            }
            }

        private void yakınlaştırmaUzaklaştırmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckImageAndApplyOperation(() =>
            {
                AddToHistory(originalImage);

                
                trackBar1.Visible = true;

            });
           
        }

       
    }

}
