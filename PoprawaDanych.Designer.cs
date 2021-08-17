namespace MultiSkaner
{
    partial class PoprawaDanych
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
            this.Opis = new System.Windows.Forms.Label();
            this.PrzyciskPotwierdzenia = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Opis
            // 
            this.Opis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Opis.Location = new System.Drawing.Point(7, 414);
            this.Opis.Name = "Opis";
            this.Opis.Size = new System.Drawing.Size(402, 25);
            this.Opis.TabIndex = 5;
            this.Opis.Text = "label1";
            this.Opis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PrzyciskPotwierdzenia
            // 
            this.PrzyciskPotwierdzenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PrzyciskPotwierdzenia.Location = new System.Drawing.Point(428, 460);
            this.PrzyciskPotwierdzenia.Name = "PrzyciskPotwierdzenia";
            this.PrzyciskPotwierdzenia.Size = new System.Drawing.Size(159, 41);
            this.PrzyciskPotwierdzenia.TabIndex = 2;
            this.PrzyciskPotwierdzenia.Text = "Potwierdź";
            this.PrzyciskPotwierdzenia.UseVisualStyleBackColor = true;
            this.PrzyciskPotwierdzenia.Click += new System.EventHandler(this.PrzyciskPotwierdzenia_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(415, 411);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(585, 33);
            this.comboBox1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(988, 371);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // PoprawaDanych
            // 
            this.AcceptButton = this.PrzyciskPotwierdzenia;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 513);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.PrzyciskPotwierdzenia);
            this.Controls.Add(this.Opis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PoprawaDanych";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PoprawaDanych";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Opis;
        private System.Windows.Forms.Button PrzyciskPotwierdzenia;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}