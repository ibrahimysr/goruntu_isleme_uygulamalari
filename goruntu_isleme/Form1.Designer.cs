namespace goruntu_isleme
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resimSeçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temelİşlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.griDönüşümToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görüntüDöndürmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görüntüKırpmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renkUzayıDönüşümüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontrastArttırmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yakınlaştırmaUzaklaştırmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orijinalHistogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.germeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genişletmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aritmetikİşlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bölmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meanFiltresiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tekEşiklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kenarBulmaPrewitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unsharpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saltPepperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meanGürültüTemizlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianGürültüTemizlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.morfolojikİşlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genişlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aşınmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(200)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(50, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(487, 455);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(200)))));
            this.label2.Location = new System.Drawing.Point(524, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(441, 41);
            this.label2.TabIndex = 8;
            this.label2.Text = "GÖRÜNTÜ İŞLEME UYGULAMALARI";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(65)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.temelİşlemlerToolStripMenuItem,
            this.histogramToolStripMenuItem,
            this.aritmetikİşlemlerToolStripMenuItem,
            this.filtrelerToolStripMenuItem,
            this.morfolojikİşlemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1598, 44);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(200)))));
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resimSeçToolStripMenuItem,
            this.kaydetToolStripMenuItem,
            this.silToolStripMenuItem});
            this.dosyaToolStripMenuItem.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dosyaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(74)))), ((int)(((byte)(101)))));
            this.dosyaToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(67, 30);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // resimSeçToolStripMenuItem
            // 
            this.resimSeçToolStripMenuItem.Name = "resimSeçToolStripMenuItem";
            this.resimSeçToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.resimSeçToolStripMenuItem.Text = "Resim Seç";
            this.resimSeçToolStripMenuItem.Click += new System.EventHandler(this.ResimSeçToolStripMenuItem_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.KaydetToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.SilToolStripMenuItem_Click);
            // 
            // temelİşlemlerToolStripMenuItem
            // 
            this.temelİşlemlerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(200)))));
            this.temelİşlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.griDönüşümToolStripMenuItem,
            this.bToolStripMenuItem,
            this.görüntüDöndürmeToolStripMenuItem,
            this.görüntüKırpmaToolStripMenuItem,
            this.renkUzayıDönüşümüToolStripMenuItem,
            this.kontrastArttırmaToolStripMenuItem,
            this.yakınlaştırmaUzaklaştırmaToolStripMenuItem});
            this.temelİşlemlerToolStripMenuItem.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.temelİşlemlerToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(74)))), ((int)(((byte)(101)))));
            this.temelİşlemlerToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.temelİşlemlerToolStripMenuItem.Name = "temelİşlemlerToolStripMenuItem";
            this.temelİşlemlerToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.temelİşlemlerToolStripMenuItem.Size = new System.Drawing.Size(130, 30);
            this.temelİşlemlerToolStripMenuItem.Text = "Temel İşlemler";
            // 
            // griDönüşümToolStripMenuItem
            // 
            this.griDönüşümToolStripMenuItem.Name = "griDönüşümToolStripMenuItem";
            this.griDönüşümToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.griDönüşümToolStripMenuItem.Text = "Gri Dönüşüm";
            this.griDönüşümToolStripMenuItem.Click += new System.EventHandler(this.GriDönüşümToolStripMenuItem_Click);
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.bToolStripMenuItem.Text = "Binary Dönüşüm";
            this.bToolStripMenuItem.Click += new System.EventHandler(this.BToolStripMenuItem_Click);
            // 
            // görüntüDöndürmeToolStripMenuItem
            // 
            this.görüntüDöndürmeToolStripMenuItem.Name = "görüntüDöndürmeToolStripMenuItem";
            this.görüntüDöndürmeToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.görüntüDöndürmeToolStripMenuItem.Text = "Döndürme";
            this.görüntüDöndürmeToolStripMenuItem.Click += new System.EventHandler(this.GörüntüDöndürmeToolStripMenuItem_Click);
            // 
            // görüntüKırpmaToolStripMenuItem
            // 
            this.görüntüKırpmaToolStripMenuItem.Name = "görüntüKırpmaToolStripMenuItem";
            this.görüntüKırpmaToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.görüntüKırpmaToolStripMenuItem.Text = " Kırpma";
            this.görüntüKırpmaToolStripMenuItem.Click += new System.EventHandler(this.GörüntüKırpmaToolStripMenuItem_Click);
            // 
            // renkUzayıDönüşümüToolStripMenuItem
            // 
            this.renkUzayıDönüşümüToolStripMenuItem.Name = "renkUzayıDönüşümüToolStripMenuItem";
            this.renkUzayıDönüşümüToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.renkUzayıDönüşümüToolStripMenuItem.Text = "Renk Uzayı Dönüşümü";
            this.renkUzayıDönüşümüToolStripMenuItem.Click += new System.EventHandler(this.RenkUzayıDönüşümüToolStripMenuItem_Click);
            // 
            // kontrastArttırmaToolStripMenuItem
            // 
            this.kontrastArttırmaToolStripMenuItem.Name = "kontrastArttırmaToolStripMenuItem";
            this.kontrastArttırmaToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.kontrastArttırmaToolStripMenuItem.Text = "Kontrast Arttırma";
            this.kontrastArttırmaToolStripMenuItem.Click += new System.EventHandler(this.KontrastArttırmaToolStripMenuItem_Click);
            // 
            // yakınlaştırmaUzaklaştırmaToolStripMenuItem
            // 
            this.yakınlaştırmaUzaklaştırmaToolStripMenuItem.Name = "yakınlaştırmaUzaklaştırmaToolStripMenuItem";
            this.yakınlaştırmaUzaklaştırmaToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.yakınlaştırmaUzaklaştırmaToolStripMenuItem.Text = "Yakınlaştırma/Uzaklaştırma";
            this.yakınlaştırmaUzaklaştırmaToolStripMenuItem.Click += new System.EventHandler(this.yakınlaştırmaUzaklaştırmaToolStripMenuItem_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(200)))));
            this.histogramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orijinalHistogramToolStripMenuItem,
            this.germeToolStripMenuItem,
            this.genişletmeToolStripMenuItem});
            this.histogramToolStripMenuItem.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.histogramToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(74)))), ((int)(((byte)(101)))));
            this.histogramToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 5, 10, 5);
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(97, 30);
            this.histogramToolStripMenuItem.Text = "Histogram";
            // 
            // orijinalHistogramToolStripMenuItem
            // 
            this.orijinalHistogramToolStripMenuItem.Name = "orijinalHistogramToolStripMenuItem";
            this.orijinalHistogramToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.orijinalHistogramToolStripMenuItem.Text = "Orijinal Histogram";
            this.orijinalHistogramToolStripMenuItem.Click += new System.EventHandler(this.OrijinalHistogramToolStripMenuItem_Click);
            // 
            // germeToolStripMenuItem
            // 
            this.germeToolStripMenuItem.Name = "germeToolStripMenuItem";
            this.germeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.germeToolStripMenuItem.Text = "Germe";
            this.germeToolStripMenuItem.Click += new System.EventHandler(this.GermeToolStripMenuItem_Click);
            // 
            // genişletmeToolStripMenuItem
            // 
            this.genişletmeToolStripMenuItem.Name = "genişletmeToolStripMenuItem";
            this.genişletmeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.genişletmeToolStripMenuItem.Text = "Genişletme";
            this.genişletmeToolStripMenuItem.Click += new System.EventHandler(this.GenişletmeToolStripMenuItem_Click);
            // 
            // aritmetikİşlemlerToolStripMenuItem
            // 
            this.aritmetikİşlemlerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(200)))));
            this.aritmetikİşlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eklemeToolStripMenuItem,
            this.bölmeToolStripMenuItem});
            this.aritmetikİşlemlerToolStripMenuItem.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aritmetikİşlemlerToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(74)))), ((int)(((byte)(101)))));
            this.aritmetikİşlemlerToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.aritmetikİşlemlerToolStripMenuItem.Name = "aritmetikİşlemlerToolStripMenuItem";
            this.aritmetikİşlemlerToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.aritmetikİşlemlerToolStripMenuItem.Text = "Aritmetik İşlemler";
            // 
            // eklemeToolStripMenuItem
            // 
            this.eklemeToolStripMenuItem.Name = "eklemeToolStripMenuItem";
            this.eklemeToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.eklemeToolStripMenuItem.Text = "Ekleme";
            this.eklemeToolStripMenuItem.Click += new System.EventHandler(this.EklemeToolStripMenuItem_Click);
            // 
            // bölmeToolStripMenuItem
            // 
            this.bölmeToolStripMenuItem.Name = "bölmeToolStripMenuItem";
            this.bölmeToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.bölmeToolStripMenuItem.Text = "Bölme";
            this.bölmeToolStripMenuItem.Click += new System.EventHandler(this.BölmeToolStripMenuItem_Click);
            // 
            // filtrelerToolStripMenuItem
            // 
            this.filtrelerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(200)))));
            this.filtrelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meanFiltresiToolStripMenuItem,
            this.tekEşiklemeToolStripMenuItem,
            this.kenarBulmaPrewitToolStripMenuItem,
            this.unsharpToolStripMenuItem,
            this.saltPepperToolStripMenuItem,
            this.meanGürültüTemizlemeToolStripMenuItem,
            this.medianGürültüTemizlemeToolStripMenuItem});
            this.filtrelerToolStripMenuItem.Font = new System.Drawing.Font("Impact", 10.2F);
            this.filtrelerToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(74)))), ((int)(((byte)(101)))));
            this.filtrelerToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.filtrelerToolStripMenuItem.Name = "filtrelerToolStripMenuItem";
            this.filtrelerToolStripMenuItem.Size = new System.Drawing.Size(81, 30);
            this.filtrelerToolStripMenuItem.Text = "Filtreler";
            // 
            // meanFiltresiToolStripMenuItem
            // 
            this.meanFiltresiToolStripMenuItem.Name = "meanFiltresiToolStripMenuItem";
            this.meanFiltresiToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.meanFiltresiToolStripMenuItem.Text = "Mean Konvolüsyon";
            this.meanFiltresiToolStripMenuItem.Click += new System.EventHandler(this.MeanFiltresiToolStripMenuItem_Click);
            // 
            // tekEşiklemeToolStripMenuItem
            // 
            this.tekEşiklemeToolStripMenuItem.Name = "tekEşiklemeToolStripMenuItem";
            this.tekEşiklemeToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.tekEşiklemeToolStripMenuItem.Text = "Tek Eşikleme";
            this.tekEşiklemeToolStripMenuItem.Click += new System.EventHandler(this.TekEşiklemeToolStripMenuItem_Click);
            // 
            // kenarBulmaPrewitToolStripMenuItem
            // 
            this.kenarBulmaPrewitToolStripMenuItem.Name = "kenarBulmaPrewitToolStripMenuItem";
            this.kenarBulmaPrewitToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.kenarBulmaPrewitToolStripMenuItem.Text = "Kenar Bulma Prewit";
            this.kenarBulmaPrewitToolStripMenuItem.Click += new System.EventHandler(this.KenarBulmaPrewitToolStripMenuItem_Click);
            // 
            // unsharpToolStripMenuItem
            // 
            this.unsharpToolStripMenuItem.Name = "unsharpToolStripMenuItem";
            this.unsharpToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.unsharpToolStripMenuItem.Text = "Unsharp";
            this.unsharpToolStripMenuItem.Click += new System.EventHandler(this.UnsharpToolStripMenuItem_Click);
            // 
            // saltPepperToolStripMenuItem
            // 
            this.saltPepperToolStripMenuItem.Name = "saltPepperToolStripMenuItem";
            this.saltPepperToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.saltPepperToolStripMenuItem.Text = "Salt Pepper ";
            this.saltPepperToolStripMenuItem.Click += new System.EventHandler(this.SaltPepperToolStripMenuItem_Click);
            // 
            // meanGürültüTemizlemeToolStripMenuItem
            // 
            this.meanGürültüTemizlemeToolStripMenuItem.Name = "meanGürültüTemizlemeToolStripMenuItem";
            this.meanGürültüTemizlemeToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.meanGürültüTemizlemeToolStripMenuItem.Text = "Mean Gürültü Temizleme";
            this.meanGürültüTemizlemeToolStripMenuItem.Click += new System.EventHandler(this.MeanGürültüTemizlemeToolStripMenuItem_Click);
            // 
            // medianGürültüTemizlemeToolStripMenuItem
            // 
            this.medianGürültüTemizlemeToolStripMenuItem.Name = "medianGürültüTemizlemeToolStripMenuItem";
            this.medianGürültüTemizlemeToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.medianGürültüTemizlemeToolStripMenuItem.Text = "Median Gürültü Temizleme";
            this.medianGürültüTemizlemeToolStripMenuItem.Click += new System.EventHandler(this.MedianGürültüTemizlemeToolStripMenuItem_Click);
            // 
            // morfolojikİşlemlerToolStripMenuItem
            // 
            this.morfolojikİşlemlerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(200)))));
            this.morfolojikİşlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genişlemeToolStripMenuItem,
            this.aşınmaToolStripMenuItem,
            this.açmaToolStripMenuItem,
            this.kaptToolStripMenuItem});
            this.morfolojikİşlemlerToolStripMenuItem.Font = new System.Drawing.Font("Impact", 10.2F);
            this.morfolojikİşlemlerToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(74)))), ((int)(((byte)(101)))));
            this.morfolojikİşlemlerToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.morfolojikİşlemlerToolStripMenuItem.Name = "morfolojikİşlemlerToolStripMenuItem";
            this.morfolojikİşlemlerToolStripMenuItem.Size = new System.Drawing.Size(160, 30);
            this.morfolojikİşlemlerToolStripMenuItem.Text = "Morfolojik İşlemler";
            // 
            // genişlemeToolStripMenuItem
            // 
            this.genişlemeToolStripMenuItem.Name = "genişlemeToolStripMenuItem";
            this.genişlemeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.genişlemeToolStripMenuItem.Text = "Genişleme";
            this.genişlemeToolStripMenuItem.Click += new System.EventHandler(this.GenişlemeToolStripMenuItem_Click);
            // 
            // aşınmaToolStripMenuItem
            // 
            this.aşınmaToolStripMenuItem.Name = "aşınmaToolStripMenuItem";
            this.aşınmaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aşınmaToolStripMenuItem.Text = "Aşınma";
            this.aşınmaToolStripMenuItem.Click += new System.EventHandler(this.AşınmaToolStripMenuItem_Click);
            // 
            // açmaToolStripMenuItem
            // 
            this.açmaToolStripMenuItem.Name = "açmaToolStripMenuItem";
            this.açmaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.açmaToolStripMenuItem.Text = "Açma";
            this.açmaToolStripMenuItem.Click += new System.EventHandler(this.AçmaToolStripMenuItem_Click);
            // 
            // kaptToolStripMenuItem
            // 
            this.kaptToolStripMenuItem.Name = "kaptToolStripMenuItem";
            this.kaptToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kaptToolStripMenuItem.Text = "Kapama";
            this.kaptToolStripMenuItem.Click += new System.EventHandler(this.KaptToolStripMenuItem_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(613, 52);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(232, 104);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(36, 278);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 510);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(65)))));
            this.label1.Location = new System.Drawing.Point(669, 477);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 98);
            this.label1.TabIndex = 13;
            this.label1.Text = "→";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(200)))));
            this.label3.Location = new System.Drawing.Point(36, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 35);
            this.label3.TabIndex = 14;
            this.label3.Text = "Görüntü ";
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsonuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(200)))));
            this.lblsonuc.Location = new System.Drawing.Point(817, 240);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(87, 35);
            this.lblsonuc.TabIndex = 15;
            this.lblsonuc.Text = "Sonuç";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(200)))));
            this.button1.Font = new System.Drawing.Font("Impact", 10.2F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(74)))), ((int)(((byte)(101)))));
            this.button1.Location = new System.Drawing.Point(1413, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 32);
            this.button1.TabIndex = 16;
            this.button1.Text = "Geri Al";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(200)))));
            this.pictureBox2.Location = new System.Drawing.Point(56, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(594, 455);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(129)))), ((int)(((byte)(65)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(823, 278);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(697, 510);
            this.panel2.TabIndex = 12;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(935, 216);
            this.trackBar1.Maximum = 200;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(570, 56);
            this.trackBar1.TabIndex = 17;
            this.trackBar1.Value = 1;
            this.trackBar1.Visible = false;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(74)))), ((int)(((byte)(101)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1598, 938);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Görüntü İşleme Uygulamaları";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resimSeçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temelİşlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem griDönüşümToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görüntüDöndürmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görüntüKırpmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renkUzayıDönüşümüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem germeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genişletmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orijinalHistogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aritmetikİşlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bölmeToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblsonuc;
        private System.Windows.Forms.ToolStripMenuItem kontrastArttırmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meanFiltresiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tekEşiklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kenarBulmaPrewitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unsharpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saltPepperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meanGürültüTemizlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem morfolojikİşlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genişlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aşınmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianGürültüTemizlemeToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ToolStripMenuItem yakınlaştırmaUzaklaştırmaToolStripMenuItem;
    }
}

