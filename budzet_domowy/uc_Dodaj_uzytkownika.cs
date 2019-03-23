using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace budzet_domowy
{
    public partial class uc_Dodaj_uzytkownika : UserControl
    {
        private FormualrzGlowny other;
        private void btn_dodaj_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            uzytkownicy wy = new uzytkownicy
            {
                imie = txb_imie.Text,
                nazwisko = txb_nazwisko.Text
            };
            db.uzytkownicy.InsertOnSubmit(wy);
            try
            {
                db.SubmitChanges();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            other.wyswietl();
            this.Parent.Controls.Remove(this);
        }

        public uc_Dodaj_uzytkownika()
        {
            InitializeComponent();
        }
        public uc_Dodaj_uzytkownika(FormualrzGlowny other)
        {
            InitializeComponent();
            this.other = other;

        }
    }
}
