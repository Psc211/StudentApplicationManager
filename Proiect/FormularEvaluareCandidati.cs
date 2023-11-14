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

namespace Proiect
{
    public partial class FormularEvaluareCandidati : Form
    {

        private List<Candidat> listaCandidati = new List<Candidat>();
        private List<Facultate>listaFacultati = new List<Facultate>();
        SqlConnection conexiune;
        Specializare s;
        public FormularEvaluareCandidati()
        {
            InitializeComponent();
            conexiune = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DataBase_Project;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        public FormularEvaluareCandidati(List<Candidat> listCandidati, List<Facultate> listaFacultati)
        {
            InitializeComponent();
            conexiune = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DataBase_Project;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            this.listaCandidati = listCandidati;
            this.listaFacultati = listaFacultati;
            conexiune.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Specializari", conexiune);
            adapter.Fill(dt);
            dgvSpecializari.DataSource = dt;
            conexiune.Close();

        }

        private void dgvSpecializari_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dgvSpecializari.Rows[e.RowIndex].Cells[0].Value.ToString());
            string nume = dgvSpecializari.Rows[e.RowIndex].Cells[1].Value.ToString();
            double buget =Convert.ToDouble( dgvSpecializari.Rows[e.RowIndex].Cells[2].Value.ToString());
            double taxa = Convert.ToDouble(dgvSpecializari.Rows[e.RowIndex].Cells[3].Value.ToString());
            s = new Specializare(nume, buget, taxa);
        }

        private void btnEvalueazaCand_Click(object sender, EventArgs e)
        {
            lbCandidatiAdmisi.Items.Clear();
            IProcesAdmitere procesAdmitere;
            if (rbSimpla.Checked == true)
            {
                procesAdmitere = new ProcesAdmitereMedie();
            }
            else
            {
                procesAdmitere= new ProcesAdmiterePonderat();
            }
            if (s != null)
            {
                List<Candidat> listaAdmisiBuget = procesAdmitere.AdmitereCandidati(listaCandidati, s.NotaAdmitereBuget);
                foreach (Candidat c in listaAdmisiBuget)
                {
                    lbCandidatiAdmisi.Items.Add("Candidatul " + c.Nume + " avand media " + Math.Round(procesAdmitere.calcul(c.NoteBac), 2) + " a intrat la buget.");
                }
                List<Candidat> ramasi = new List<Candidat>();
                foreach (Candidat c in listaCandidati)
                {
                    if (listaAdmisiBuget.Contains(c) == false)
                    {
                        ramasi.Add(c);
                    }
                }
                List<Candidat> listaAdmisiTaxa = procesAdmitere.AdmitereCandidati(ramasi, s.NotaAdmitereTaxa);
                foreach (Candidat c in listaAdmisiTaxa)
                {
                    lbCandidatiAdmisi.Items.Add("Candidatul " + c.Nume + " avand media " + Math.Round(procesAdmitere.calcul(c.NoteBac), 2) + " a intrat la taxa.");
                }
            }
            else
            {
                MessageBox.Show("Trebuie aleasa o specializare!");
            }
           

        }
    }
}
