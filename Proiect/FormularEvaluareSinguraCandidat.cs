using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Proiect
{
    public partial class FormularEvaluareSinguraCandidat : Form
    {
        Specializare s;
        public FormularEvaluareSinguraCandidat(List<Candidat> listac,List<Specializare> listaSpecializari)
        {
            InitializeComponent();
            BindingSource bs = new BindingSource(); 
            bs.DataSource = listac;
            bindingNavigator1.BindingSource = bs;
            tbCandidatSelect.DataBindings.Add(new Binding("Text", bs,"Nume"));
            tbNotaOblig.DataBindings.Add(new Binding("Text", bs, "NotaObligatorie"));
            tbNotaProfil.DataBindings.Add(new Binding("Text", bs, "NotaProfil"));
            tbNotaOptionala.DataBindings.Add(new Binding("Text", bs, "NotaOptional"));
            SqlConnection conexiune = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DataBase_Project;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conexiune.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Specializari", conexiune);
            adapter.Fill(dt);
            dgvSpecializari.DataSource = dt;
            conexiune.Close();
        }
        private void dgvSpecializari_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string nume = dgvSpecializari.Rows[e.RowIndex].Cells[1].Value.ToString();
            double buget = Convert.ToDouble(dgvSpecializari.Rows[e.RowIndex].Cells[2].Value.ToString());
            double taxa = Convert.ToDouble(dgvSpecializari.Rows[e.RowIndex].Cells[3].Value.ToString());
            s = new Specializare(nume, buget, taxa);
        }

        private void btnAlegereSpecializare_Click(object sender, EventArgs e)
        {
            if (s!=null) {
                IProcesAdmitere procesAdmitere;
                if (rbSimpla.Checked == true)
                {
                    procesAdmitere = new ProcesAdmitereMedie();
                }
                else
                {
                    procesAdmitere = new ProcesAdmiterePonderat();
                }
                double[] note = new double[3];
                note[0] = Convert.ToDouble(tbNotaOblig.Text);
                note[1] = Convert.ToDouble(tbNotaProfil.Text);
                note[2] = Convert.ToDouble(tbNotaOptionala.Text);
                if (procesAdmitere.EvalueazaStudent(procesAdmitere.calcul(note), s.NotaAdmitereBuget) == true)
                {
                    tbRezultat.Text += " Candidatul " + tbCandidatSelect.Text + " a intrat la buget!";
                }
                else
                {
                    if(procesAdmitere.EvalueazaStudent(procesAdmitere.calcul(note), s.NotaAdmitereTaxa) == true)
                    {
                        tbRezultat.Text += " Candidatul " + tbCandidatSelect.Text + " a intrat la taxa!";
                    }
                    else
                    {
                        tbRezultat.Text += " Candidatul " + tbCandidatSelect.Text + " nu are medie suficienta pentru specializarea aleasa!";
                    }
                }

            }
            else
            {
                MessageBox.Show("Nu ai ales o specializare", "Atentie!");
            }

        }

        private void btnToateSpecializarile_Click(object sender, EventArgs e)
        {
            tbRezultat.Clear();
            for(int i=0;i<dgvSpecializari.Rows.Count-1;i++)
            {
                string nume = dgvSpecializari.Rows[i].Cells[1].Value.ToString();
                double buget = Convert.ToDouble(dgvSpecializari.Rows[i].Cells[2].Value.ToString());
                double taxa = Convert.ToDouble(dgvSpecializari.Rows[i].Cells[3].Value.ToString());
                s = new Specializare(nume, buget, taxa);
                tbRezultat.Text += "Pentru specializarea " + nume;
                btnAlegereSpecializare.PerformClick();
                tbRezultat.Text += Environment.NewLine;
            }

            
        }
    }
}
