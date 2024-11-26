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
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        EgitimKampiEfTravelDBEntities db = new EgitimKampiEfTravelDBEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            #region Toplam Lokasyon Sayısı
            lblLokasyonDeger.Text = db.TblLocation.Count().ToString();
            #endregion

            #region Toplam Kapasite
            lblKapasiteDeger.Text = db.TblLocation.Sum(x => x.LocationCapacity).ToString();
            #endregion

            #region Toplam Rehber Sayısı
           lblRehberSayisiDeger.Text = db.TblGuide.Count().ToString();
            #endregion

            #region Ortalama Kapasite
            lblOrtKapasiteDeger.Text = db.TblLocation.Average(x => x.LocationCapacity).ToString();
            #endregion

            #region Ortalama Tur Fiyatı
            lblOrtTurFiyatiDeger.Text = db.TblLocation.Average(x => x.LocationPrice)?.ToString("0.00");
            #endregion

            #region Eklenen Son Ülke
            int eklenenSonUlkeId = db.TblLocation.Max(x => x.LocationId);
            //FirstOrDefault tüm değerler yerine tek değer getirmede kullanılır.
            lblEklSonUlkeDeger.Text = db.TblLocation.Where(x => x.LocationId == eklenenSonUlkeId).Select(y => y.LocationCountry).FirstOrDefault();
            #endregion

            #region Kapadokya Tur Kapasitesi
            lblKapadokyaTKDeger.Text = db.TblLocation.Where(x => x.LocationCity == "Kapadokya").Select(y => y.LocationCapacity).FirstOrDefault().ToString();
            #endregion

            #region Türkiye Turları Ortalama Kapasitesi
            lblTurkiyeOrtKapDeger.Text = db.TblLocation.Where(x => x.LocationCountry== "Türkiye").Average(y => y.LocationCapacity).ToString();
            #endregion

            #region Roma Gezi Rehberi
            var romaRehberId = db.TblLocation.Where(x => x.LocationCity == "Roma").Select(y => y.GuideId).FirstOrDefault();
            lblRomaRehberDeger.Text = db.TblGuide.Where(x => x.GuideId == romaRehberId).Select(y => y.GuideName + " " + y.GuideSurname).FirstOrDefault().ToString();
            #endregion

            #region En Yüksek Kapasiteli Tur
            var enYuksekKapasiteliTur = db.TblLocation.Max(x => x.LocationCapacity);
            lblEnYuksekKapasiteDeger.Text = db.TblLocation.Where(x => x.LocationCapacity == enYuksekKapasiteliTur).Select(y => y.LocationCity).FirstOrDefault().ToString();
            #endregion

            #region En Pahalı Tur
            var enPahaliTur = db.TblLocation.Max(x => x.LocationPrice);
            lblEnPahaliTurDeger.Text = db.TblLocation.Where(x => x.LocationPrice == enPahaliTur).Select(y => y.LocationCity).FirstOrDefault().ToString();
            #endregion

            #region Ayşegül Çınar Tur Sayısı
            var aysegulCinarGuideId = db.TblGuide.Where(x => x.GuideName == "Ayşegül" && x.GuideSurname == "Çınar").Select(y => y.GuideId).FirstOrDefault();
            lblAysegulCinarTurDeger.Text = db.TblLocation.Where(x => x.GuideId == aysegulCinarGuideId).Count().ToString();
            #endregion
        }
    }
}
