using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiSkaner
{
    public partial class PoprawaDanych : Form
    {
        public PoprawaDanych(string opis,  string[] listaWybieralna, Bitmap wycinek)
        {
            InitializeComponent();
            comboBox1.Items.AddRange(listaWybieralna);
            comboBox1.SelectedIndex = 0;
            pictureBox1.Image = wycinek;
            Opis.Text = opis;
            this.Text = opis;
            
            
        }

        public string dane
        {
            get
            {
                return comboBox1.Text;
                
            }
        }
        public event EventHandler DataAvailable;

        protected virtual void onDataAvailable(EventArgs e)
        {
            DataAvailable?.Invoke(this, e);
        }

        private void PrzyciskPotwierdzenia_Click(object sender, EventArgs e)
        {
            onDataAvailable(null);
            this.Close();
        }
    }
}

