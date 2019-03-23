using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace budzet_domowy
{
    public partial class FormualrzGlowny : Form
    {
        public FormualrzGlowny()
        {
            InitializeComponent();
        }

        public void wyswietl()
        {
            ListaUzytkownicy.Items.Clear();
            DataClasses1DataContext db = new DataClasses1DataContext();
            var query = from u in db.uzytkownicy
                        select u;
            foreach (var u in query)
            {
                ListViewItem nowy_rekord = new ListViewItem();
                nowy_rekord = ListaUzytkownicy.Items.Add(u.imie.ToString());
                nowy_rekord.SubItems.Add(u.nazwisko.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListaUzytkownicy.Items.Clear();
            DataClasses1DataContext db = new DataClasses1DataContext();
            var query = from u in db.uzytkownicy
                        select u;
            foreach (var u in query)
            {
                ListViewItem nowy_rekord = new ListViewItem();
                nowy_rekord = ListaUzytkownicy.Items.Add(u.imie.ToString());
                nowy_rekord.SubItems.Add(u.nazwisko.ToString());
            }
        }

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
            wyswietl();
            
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point p = this.PointToClient(Cursor.Position);
            uc_Dodaj_uzytkownika uDu = new uc_Dodaj_uzytkownika(this);
            uDu.Size = new Size(133, 130);
            
            uDu.Location = new Point(p.X- 133, p.Y);
            this.Controls.Add(uDu);
            uDu.BringToFront();
        }
    }
}
