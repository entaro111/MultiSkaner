using Spire.Pdf;
using Spire.Pdf.Graphics;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Tesseract;

namespace MultiSkaner
{
    public partial class Form1 : Form
    {
        Label templabel = new Label();
        string[] listaFormularzy = {"5737","5738","5740","5753","5754","5754a","5755","5755a","5756","5756a","5757","5757a","5758","5758a","5771","5803","5846","5847","5849",
            "5850","5851","5853","5900","5901","5902","5906","5921","5927","5929","5931","5933","5943","5945","5949","5951","6032","6059","6060","6061","6087","6100","6101",
            "6102","6108","6110","6113","6114","6115","6176","6177","6178","6183","6184","6186","6190","6197","6200","6208","6209","6212","6218","6219","6220","6221","6222",
            "6223","6224","6225","6226","6227","6250","6251","6252","6258","6341","6342","6343","6344","6345","6347","6348","6349","6350","6352","6356","6364","6371","6372",
            "6374","6376","6380","6387","6388","6389","6390","6392","6393","6394","6395","6397","6398","6399","6400","6401","6402","6413","6414","6419","6420","6423","6424",
            "6425","6426","6428","6429","6430","6431","6432","6437","6443","6446","6447","6448","6453","6573","6574","6576","6594","6600","6606","6607","6609","6610","6629",
            "6633","6635","6636","6693","6695","6697","6698","6701","6702","6703","6803","6810","6812","6814","6815","6816","6817","6818","6819","6820","6821","6822","6823",
            "6824","6825","6834","6835","6836","6837","6839","6840","6841","6842","6853","6855","6856","6934","6937","6939","6941","6950","6955","6964","6976","6977","6978",
            "6979","6980","6981","6982","6983","6984","6985","6986","6988","6989","6990","6991","6992","6993","6997","6999","7007","7008","7009","7020","7030","7035","7037",
            "7041","7045","7048","7055","7057","7141","7242","7255","7332","7333","7341","7342","7352","7353","7361","7362","7364","7365","7366","7367","7376","7377","7378",
            "7380","7388","7391","7392","7393","7396","7399","7400","7411","7414","7415","7416","7418","7420","7423","7425","7427","7430","7434","7435","7436","7437","7438",
            "7439","7440","7461","7465","7469","7470","7471","7473","7482","7484","7485","7492","7493","7494","7495","7499","7500","7501","7503","7507","7523","7524","7527",
            "7529","7530","7531","7532","7533","7534","7535","7541","7542","7551","7552","7554","7555","7557","7558","7560","7561","7608","7608","7726","7728","7729","8258",
            "8317","8354","8370","8401","8402","8511","8543","8610","8611","8931","10231","11801","11802","11802a","11804","11804a","11808","11809","11812","11815","11816",
            "11817","11818","11821","11822","11823","12293","12386","12387","12421","12422","12423","12424","12425","12426","12427","12428","12429","12430","12431","12432",
            "12578","12591","12603","12617","12623","12670","12692","12698","12890","12891","12892","12897","12898","12907","12996","12997","13800","13962","14720","14736",
            "14737","14738","14898","14899","14900","14901","14902","14935"};
        string[] listaMiesiecy = {"01 styczeń", "02 luty", "03 marzec", "04 kwiecień", "05 maj", "06 czerwiec", "07 lipiec", "08 sierpień","09 wrzesień", "10 październik",
            "11 listopad", "12 grudzień"};
        string[] listaLat = { "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028" };
        public Form1()
        {
            InitializeComponent();

        }

        private void wybierzKatalogZeskanowany_Click(object sender, EventArgs e)
        {
            folderZeskanowychDialog.ShowDialog();
            sciezkaDoZeskanowanychPlikow.Text = folderZeskanowychDialog.SelectedPath;
        }

        private void KatalogZapisu_Click(object sender, EventArgs e)
        {
            folderZapisuDialog.ShowDialog();
            folderZapisuDokumentow.Text = folderZapisuDialog.SelectedPath;
        }

        private void procesButton_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {

                if (!String.IsNullOrEmpty(sciezkaDoZeskanowanychPlikow.Text) || (!String.IsNullOrEmpty(folderZapisuDokumentow.Text)))
                {

                    backgroundWorker1.RunWorkerAsync();
                    cancelButton.Enabled = true;
                    wybierzKatalogZeskanowany.Enabled = false;
                    KatalogZapisu.Enabled = false;
                    procesButton.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Wybierz katalogi przed rozpoczęciem");
                }
            }
        }



        private void OdczytajPlik(string path, string folder)
        {

            var engine = new TesseractEngine(@"./tessdata", "pol", EngineMode.Default);
            var img = Pix.LoadFromFile(path);
            var res = engine.Process(img);
            string tekst = res.GetText().Trim();

            string Rok = OdczytajRok(tekst, path);
            string Miesiac = OdczytajMiesiac(tekst, path);
            string NumerZlecenia = OdczytajNumerZlecenia(tekst, path);
            string savePath = folder + "\\" + Rok + "\\" + Miesiac + "\\" + NumerZlecenia;
            StworzPDF(path, savePath);
            engine.Dispose();
        }

        private void StworzPDF(string path, string katalog)
        {

            PdfDocument document = new PdfDocument();
            PdfPageBase page = document.Pages.Add();
            PdfSection section = document.Sections.Add();
            PdfImage image = PdfImage.FromFile(path);
            float widthFitRate = image.PhysicalDimension.Width / page.Canvas.ClientSize.Width;
            float heightFitRate = image.PhysicalDimension.Height / page.Canvas.ClientSize.Height;
            float fitRate = Math.Max(widthFitRate, heightFitRate);
            float fitWidth = image.PhysicalDimension.Width / fitRate;
            float fitHeight = image.PhysicalDimension.Height / fitRate;
            page.Canvas.DrawImage(image, 0, 0, fitWidth, fitHeight);
            string skan = katalog + ".pdf";
            document.SaveToFile(skan);
            document.Close();
        }

        private string OdczytajNumerZlecenia(string skan, string path)
        {
            string nazwa = "";
            skan = skan.ToLower();
            if (skan.Contains("konserwacji"))
            {
                nazwa = skan.Substring(skan.IndexOf("konserwacji"), 17);
                nazwa = nazwa.Substring(nazwa.Length - 5, 5);
                nazwa = nazwa.Remove(nazwa.Length - 1);
            }
            if (skan.Contains("plan inspekcji"))
            {
                nazwa = skan.Substring(skan.IndexOf("plan inspekcji"), 20);
                nazwa = nazwa.Substring(nazwa.Length - 5, 5);
                nazwa = nazwa.Remove(nazwa.Length - 1);
            }
            if (SprawdźNumer(nazwa))
            {
                return nazwa;
            }
            else
            {
                OtworzOknoPoprawy("POPRAW NUMER ZLECENIA", listaFormularzy, Wycinek(path));
                nazwa = templabel.Text;
            }
            return nazwa;
        }
        public bool SprawdźNumer(string numer)
        {
            if (Array.Exists(listaFormularzy, element => element == numer))
            {
                return true;
            }
            return false;
        }
        public string OdczytajRok(string skan, string path)
        {
            string[] slowa = skan.Split(' ');
            int Rok;
            if (Int32.TryParse(slowa[1], out Rok))
            {
                if (Rok > 2000 && Rok < 2050)
                {
                    return Rok.ToString();
                }
            }
            OtworzOknoPoprawy("POPRAW ROK", listaLat, Wycinek(path));

            return templabel.Text;
        }

        public string OdczytajMiesiac(string skan, string path)
        {
            skan = skan.ToLower();
            string[] slowa = skan.Split(' ');
            string miesiac = "";
            string poprawa;
            if (String.IsNullOrWhiteSpace(slowa[0]))
            {
                poprawa = slowa[1];
            }
            else
            {
                poprawa = slowa[0];
            }

            switch (poprawa)
            {
                case "styczeń":
                    miesiac = "01 " + poprawa;
                    break;
                case "luty":
                    miesiac = "02 " + poprawa;
                    break;
                case "marzec":
                    miesiac = "03 " + poprawa;
                    break;
                case "kwiecień":
                    miesiac = "04 " + poprawa;
                    break;
                case "maj":
                    miesiac = "05 " + poprawa;
                    break;
                case "czerwiec":
                    miesiac = "06 " + poprawa;
                    break;
                case "lipiec":
                    miesiac = "07 " + poprawa;
                    break;
                case "sierpień":
                    miesiac = "08 " + poprawa;
                    break;
                case "wrzesień":
                    miesiac = "09 " + poprawa;
                    break;
                case "październik":
                    miesiac = "10 " + poprawa;
                    break;
                case "listopad":
                    miesiac = "11 " + poprawa;
                    break;
                case "grudzień":
                    miesiac = "12 " + poprawa;
                    break;
                default:
                    OtworzOknoPoprawy("POPRAW MIESIĄC", listaMiesiecy, Wycinek(path));
                    miesiac = templabel.Text;
                    break;
            }

            return miesiac;
        }

        public void OtworzOknoPoprawy(string opis, string[] listaWybieralna, Bitmap wycinek)
        {

            PoprawaDanych poprawa = new PoprawaDanych(opis, listaWybieralna, wycinek);
            poprawa.DataAvailable += new EventHandler(danePoprawy);
            poprawa.ShowDialog();
        }

        void danePoprawy(object sender, EventArgs e)
        {
            PoprawaDanych poprawa = sender as PoprawaDanych;
            if (poprawa != null)
            {

                templabel.Text = poprawa.dane;
            }
        }

        private Bitmap Wycinek(string path)
        {
            int height = 371;
            Bitmap src = Image.FromFile(path) as Bitmap;
            Bitmap trg = new Bitmap(988, height);
            using (Graphics g = Graphics.FromImage(trg))
            {
                g.DrawImage(src, new Rectangle(0, 0, trg.Width, trg.Height), 0, 0, src.Width, height, GraphicsUnit.Pixel);
            }
            return trg;

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker backgroundWorker = sender as BackgroundWorker;
            string[] listaPlikowDoOdczytania = Directory.GetFiles(sciezkaDoZeskanowanychPlikow.Text, "*.jpg");
            for (int i = 0; i < listaPlikowDoOdczytania.Length; i++)
            {
                if (backgroundWorker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    int procent = (int)((float)i / (float)listaPlikowDoOdczytania.Length * 100);
                    backgroundWorker.ReportProgress(procent);
                    OdczytajPlik(listaPlikowDoOdczytania[i], folderZapisuDokumentow.Text);
                }

            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
            cancelButton.Enabled = false;
            wybierzKatalogZeskanowany.Enabled = true;
            KatalogZapisu.Enabled = true;
            procesButton.Enabled = true;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("Bład: " + e.Error.Message);
            }
            else if (e.Cancelled)
            {
                progressBar1.Value = 0;
                MessageBox.Show("Anulowano!");
            }
            else
            {
                progressBar1.Value = 100;
                cancelButton.Enabled = false;
                wybierzKatalogZeskanowany.Enabled = true;
                KatalogZapisu.Enabled = true;
                procesButton.Enabled = true;
                MessageBox.Show("Koniec");
            }
        }
    }
}
