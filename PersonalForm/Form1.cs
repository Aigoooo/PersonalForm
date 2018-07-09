using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalForm
{
    public partial class Form1 : Form
    {
        PersonalEntities _db = new PersonalEntities();
        Personal personal = new Personal();
        public Form1()
        {
            InitializeComponent();
        }
        void Clear()
        {
            txtNamn.Text = txtAlder.Text = txtSmek.Text = dtPick.Text = "";
            btnSpara.Text = "Save";
            btnRadera.Enabled = false;
            personal.Id = 0;
            
        }
        private void btnRadera_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();
        }

        private void btnSpara_Click(object sender, EventArgs e)
        {
            
            personal.Namn = txtNamn.Text.Trim();
            personal.Ålder = Convert.ToInt32(txtAlder.Text.Trim());
            personal.Smeknamn = txtSmek.Text.Trim();
            personal.Datum = dtPick.Text.Trim();
            
            using (PersonalEntities _db = new PersonalEntities()) 
            {
                if(personal.Id == 0)
                {
                    _db.Personals.Add(personal);
                }
                else
                {
                    _db.Entry(personal).State = System.Data.Entity.EntityState.Modified;
                }

                // _db.Personals.Add(personal);
                _db.SaveChanges();
            }
            Clear();
            PopulateDataGridView();
            MessageBox.Show("Sparad!");
        }
        void PopulateDataGridView()
        {
            dPersonal.AutoGenerateColumns = false;
            {
                dPersonal.DataSource = _db.Personals.ToList<Personal>();
            }
        }

        private void dPersonal_DoubleClick(object sender, EventArgs e)
        {
            if (dPersonal.CurrentRow.Index != -1)
            {
                personal.Id = Convert.ToInt32(dPersonal.CurrentRow.Cells["PersonID"].Value);
                PersonalEntities _db = new PersonalEntities();
                {
                    personal = _db.Personals.Where(x => x.Id == personal.Id).FirstOrDefault();
                    txtNamn.Text = personal.Namn;
                    txtAlder.Text = personal.Ålder.ToString();
                    txtSmek.Text = personal.Smeknamn;
                    dtPick.Text = personal.Datum;
                }
                btnSpara.Text = "Uppdatera";
                btnRadera.Enabled = true;
            }
        }

        private void btnRadera_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Är du säker på att du vill radera?", "Radera", MessageBoxButtons.YesNo) == DialogResult.Yes)
                using (PersonalEntities _db = new PersonalEntities())
                {
                    var entry = _db.Entry(personal);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                    {
                        _db.Personals.Attach(personal);
                        _db.Personals.Remove(personal);
                        _db.SaveChanges();
                        PopulateDataGridView();
                        Clear();
                        MessageBox.Show("Raderad!");
                    }
                }
        }
    }
}
