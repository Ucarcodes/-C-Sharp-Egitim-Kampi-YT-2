using CSharpEgitimKampi301.EFProject.ADO.NET_Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EgitimKampiEfTravelDBEntities db = new EgitimKampiEfTravelDBEntities();
        private void btnListele_Click(object sender, EventArgs e)
        {
            var values= db.TblGuide.ToList();
            dataGridRehber.DataSource = values;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TblGuide guide = new TblGuide(); //Buradaki TblGuide, SQL tablomuzun ismi, guide ise burada oluşturduğumuz isimdir.
            guide.GuideName = tBoxRehberAdi.Text;
            guide.GuideSurname = tBoxRehberSoyadi.Text;
            db.TblGuide.Add(guide); //TblGuide tablosuna, Add ile değer ekliyoruz.
            db.SaveChanges();
            MessageBox.Show("Rehber, başarıyla veritabanına eklendi!");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tBoxRehberID.Text);
            var deleteValue = db.TblGuide.Find(id); //TblGuide tablosunda, Find ile ID buluyoruz.
            db.TblGuide.Remove(deleteValue); //TblGuide tablosunda, Remove ile değer siliyoruz.
            db.SaveChanges();
            MessageBox.Show("Rehber, başarıyla veritabanından silindi!");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tBoxRehberID.Text);
            var updateValue = db.TblGuide.Find(id);
            updateValue.GuideName = tBoxRehberAdi.Text;
            updateValue.GuideSurname = tBoxRehberSoyadi.Text;
            db.SaveChanges();
            MessageBox.Show("Rehber, başarıyla veritabanında güncellendi!");
        }

        private void btnIdGetir_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tBoxRehberID.Text);
            var values = db.TblGuide.Where(x =>x.GuideId == id).ToList(); //x => x.GuideId demek, olduğunda anlamındadır.
            dataGridRehber.DataSource = values;
        }
    }
}
