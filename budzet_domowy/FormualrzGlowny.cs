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

        private void Form1_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var query = from u in db.uzytkownicy
                        select u;
            DGV_uzytkownicy.DataSource = query;
            DGV_uzytkownicy.Columns[0].Visible = false;
        }
    }
}
