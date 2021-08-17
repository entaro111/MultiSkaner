namespace MultiSkaner
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.sciezkaDoZeskanowanychPlikow = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.wybierzKatalogZeskanowany = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.folderZapisuDokumentow = new System.Windows.Forms.TextBox();
            this.KatalogZapisu = new System.Windows.Forms.Button();
            this.procesButton = new System.Windows.Forms.Button();
            this.folderZeskanowychDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.folderZapisuDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sciezkaDoZeskanowanychPlikow
            // 
            this.sciezkaDoZeskanowanychPlikow.Location = new System.Drawing.Point(12, 46);
            this.sciezkaDoZeskanowanychPlikow.Name = "sciezkaDoZeskanowanychPlikow";
            this.sciezkaDoZeskanowanychPlikow.ReadOnly = true;
            this.sciezkaDoZeskanowanychPlikow.Size = new System.Drawing.Size(477, 20);
            this.sciezkaDoZeskanowanychPlikow.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Katalog zeskanowanych dokumentów";
            // 
            // wybierzKatalogZeskanowany
            // 
            this.wybierzKatalogZeskanowany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wybierzKatalogZeskanowany.Location = new System.Drawing.Point(555, 38);
            this.wybierzKatalogZeskanowany.Name = "wybierzKatalogZeskanowany";
            this.wybierzKatalogZeskanowany.Size = new System.Drawing.Size(112, 32);
            this.wybierzKatalogZeskanowany.TabIndex = 2;
            this.wybierzKatalogZeskanowany.Text = "Wybierz";
            this.wybierzKatalogZeskanowany.UseVisualStyleBackColor = true;
            this.wybierzKatalogZeskanowany.Click += new System.EventHandler(this.wybierzKatalogZeskanowany_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Katalog gdzie zapisać pliki\r\n";
            // 
            // folderZapisuDokumentow
            // 
            this.folderZapisuDokumentow.Location = new System.Drawing.Point(12, 127);
            this.folderZapisuDokumentow.Name = "folderZapisuDokumentow";
            this.folderZapisuDokumentow.ReadOnly = true;
            this.folderZapisuDokumentow.Size = new System.Drawing.Size(477, 20);
            this.folderZapisuDokumentow.TabIndex = 4;
            // 
            // KatalogZapisu
            // 
            this.KatalogZapisu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KatalogZapisu.Location = new System.Drawing.Point(555, 119);
            this.KatalogZapisu.Name = "KatalogZapisu";
            this.KatalogZapisu.Size = new System.Drawing.Size(112, 32);
            this.KatalogZapisu.TabIndex = 5;
            this.KatalogZapisu.Text = "Wybierz";
            this.KatalogZapisu.UseVisualStyleBackColor = true;
            this.KatalogZapisu.Click += new System.EventHandler(this.KatalogZapisu_Click);
            // 
            // procesButton
            // 
            this.procesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.procesButton.Location = new System.Drawing.Point(153, 221);
            this.procesButton.Name = "procesButton";
            this.procesButton.Size = new System.Drawing.Size(186, 62);
            this.procesButton.TabIndex = 6;
            this.procesButton.Text = "Kataloguj\r\npliki";
            this.procesButton.UseVisualStyleBackColor = true;
            this.procesButton.Click += new System.EventHandler(this.procesButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 176);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(673, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 7;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // cancelButton
            // 
            this.cancelButton.Enabled = false;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cancelButton.Location = new System.Drawing.Point(362, 221);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(184, 62);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Anuluj";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 295);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.procesButton);
            this.Controls.Add(this.KatalogZapisu);
            this.Controls.Add(this.folderZapisuDokumentow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wybierzKatalogZeskanowany);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sciezkaDoZeskanowanychPlikow);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OCR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sciezkaDoZeskanowanychPlikow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button wybierzKatalogZeskanowany;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox folderZapisuDokumentow;
        private System.Windows.Forms.Button KatalogZapisu;
        private System.Windows.Forms.Button procesButton;
        private System.Windows.Forms.FolderBrowserDialog folderZeskanowychDialog;
        private System.Windows.Forms.FolderBrowserDialog folderZapisuDialog;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button cancelButton;
    }
}

