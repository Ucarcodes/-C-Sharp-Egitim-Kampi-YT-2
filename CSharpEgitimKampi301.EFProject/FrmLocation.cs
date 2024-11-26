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
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }
        EgitimKampiEfTravelDBEntities db = new EgitimKampiEfTravelDBEntities();
        private void btnListele_Click(object sender, EventArgs e)
        {
            var values = db.TblLocation.ToList();
            dataGridLokasyon.DataSource = values;
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values = db.TblGuide.Select(x=> new
            {
                FullName = x.GuideName + " " + x.GuideSurname, x.GuideId
            }).ToList();
            cBoxRehber.DisplayMember = "FullName";
            cBoxRehber.ValueMember = "GuideId";
            cBoxRehber.DataSource = values;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TblLocation location = new TblLocation();
            location.LocationCapacity = byte.Parse(numUpDKapasite.Value.ToString());
            location.LocationCity = tBoxSehir.Text;
            location.LocationCountry = tBoxUlke.Text;
            location.LocationPrice = decimal.Parse(tBoxFiyat.Text);
            location.DayNight = tBoxGunGece.Text;
            location.GuideId = int.Parse(cBoxRehber.SelectedValue.ToString());
            db.TblLocation.Add(location);
            db.SaveChanges();
            MessageBox.Show("Lokasyon bilgileri başarıyla veri tabanına eklendi!");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tBoxLokasyonID.Text);
            var deletedValue = db.TblLocation.Find(id);
            db.TblLocation.Remove(deletedValue);
            db.SaveChanges();
            MessageBox.Show("Lokasyon bilgileri başarıyla veri tabanından silindi!");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tBoxLokasyonID.Text);
            var updatedValue = db.TblLocation.Find(id);
            updatedValue.LocationCapacity = byte.Parse(numUpDKapasite.Value.ToString());
            updatedValue.LocationCity = tBoxSehir.Text;
            updatedValue.LocationCountry = tBoxUlke.Text;
            updatedValue.LocationPrice = decimal.Parse(tBoxFiyat.Text);
            updatedValue.DayNight = tBoxGunGece.Text;
            updatedValue.GuideId = int.Parse(cBoxRehber.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Lokasyon bilgileri başarıyla veri tabanında güncellendi!");
        }
    }
}
