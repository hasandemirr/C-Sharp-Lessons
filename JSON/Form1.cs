using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace JSON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Kitap> liste = new List<Kitap>();
        JavaScriptSerializer tercuman = new JavaScriptSerializer();

        private void button2_Click(object sender, EventArgs e)
        {
            Kitap yeni = new Kitap();
            // Oluşturulan Kitap classına yeni adında bir instance eklendi
            yeni.baslik = textBox1.Text;
            yeni.fiyat = numericUpDown1.Value;
            // Başlık ve fiyat bilgisi girildi
            liste.Add(yeni);
            // Yeni instance'ı listeye eklendi
            JsonDosyasınaYaz(liste);
            MessageBox.Show("İşlem Başarılı");
        }

        private void JsonDosyasınaYaz(List<Kitap> liste)
        {
            string jason = tercuman.Serialize(liste);
            //Bu listeyi Jasona çeviriyor
            File.WriteAllText("../../Kitapler.Jason",jason);
            // WriteAllText komutu mevcut olanın üzerine yazar.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string icerik = File.ReadAllText("../../Kitapler.Jason");
            var liste = tercuman.Deserialize<List<Kitap>>(icerik);
            //Jason tipindeki veriyi stringe çeviriyor
            
            listBox1.DisplayMember = "baslik";
            foreach (Kitap kitap in liste)
            {
                listBox1.Items.Add((kitap));
                // Cekilen kitapları listeye ekliyor
            }
        }
    }
}
