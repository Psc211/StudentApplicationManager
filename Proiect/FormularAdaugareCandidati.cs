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
using System.Xml;

namespace Proiect
{
    public partial class FormularAdaugareCandidati : Form
    {
        private List<Candidat> listCandidati = new List<Candidat>();
        SqlConnection conexiune;
        SqlCommand command;


        public FormularAdaugareCandidati()
        {
            InitializeComponent();
            conexiune = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DataBase_Project;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        internal List<Candidat> ListCandidati { get => listCandidati; set => listCandidati = value; }

        private void btnAdaugaCandidat_Click(object sender, EventArgs e)
        {
            Candidat c= new Candidat();
            c.Nume = tbNume.Text;
            c.Prenume = tbPrenume.Text;
            c.Adresa = tbAdresa.Text;
            c.CNP = Convert.ToInt64(tbCNP.Text);
            double[] noteBac = new double[] {Convert.ToDouble(tbNotaMaterieObligatorie.Text), Convert.ToDouble(tbNotaMaterieOptional.Text), Convert.ToDouble(tbNotaMaterieProfil.Text) };
            c.NoteBac = noteBac;
            ListCandidati.Add(c);
            tbNume.Clear();
            tbPrenume.Clear();
            tbAdresa.Clear();
            tbCNP.Clear();
            tbNotaMaterieObligatorie.Clear();
            tbNotaMaterieOptional.Clear();
            tbNotaMaterieProfil.Clear();
            adaugaBD(c);
        }

        private void adaugaBD(Candidat s)
        {
            conexiune.Open();
            command = new SqlCommand("INSERT INTO CANDIDATI(Nume,PRENUME,ADRESA,CNP,PROBA_OBLIGATORIE,PROBA_PROFIL," +
                " PROBA_OPTIONALA) VALUES (@nume, @prenume, @adresa, @cnp, @probaObligatorie, @probaProfil, @probaOptionala)", conexiune);
            command.Parameters.AddWithValue("@nume", s.Nume);
            command.Parameters.AddWithValue("@prenume", s.Prenume);
            command.Parameters.AddWithValue("@adresa", s.Adresa);
            command.Parameters.AddWithValue("@cnp", s.CNP);
            command.Parameters.AddWithValue("@probaObligatorie", s.NoteBac[0]);
            command.Parameters.AddWithValue("@probaProfil", s.NoteBac[1]);
            command.Parameters.AddWithValue("@probaOptionala", s.NoteBac[2]);
            command.ExecuteNonQuery();
            conexiune.Close();
            MessageBox.Show("Candidat inserat in baza de date!");
        }

        private void btnAfisareAdaugareaCand_Click(object sender, EventArgs e)
        {
            conexiune.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Candidati", conexiune);
            adapter.Fill(dt);
            dgvCandidati.DataSource = dt;
            conexiune.Close();
        }

        private void btnAdaugareXML_Click(object sender, EventArgs e)
        {

            Candidat c= new Candidat();
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("Candidati.xml");
            XmlNodeList xmlNodeListCandidati = xmlDocument.SelectNodes("Candidati");
            foreach (XmlNode xmlNodeCandidati in xmlNodeListCandidati)
            {
                XmlNodeList xmlNodeListCandidat = xmlNodeCandidati.ChildNodes;
                foreach (XmlNode xmlCandidat in xmlNodeListCandidat)
                {
                    string nume = xmlCandidat["Nume"].InnerText;
                    string prenume = xmlCandidat["Prenume"].InnerText;
                    string adresa = xmlCandidat["Adresa"].InnerText;
                    long cnp = Convert.ToInt64(xmlCandidat["CNP"].InnerText);
                    double[] note = new double[3];
                    note[0] = Convert.ToDouble(xmlCandidat["NotaBac1"].InnerText);
                    note[1] = Convert.ToDouble(xmlCandidat["NotaBac2"].InnerText);
                    note[2] = Convert.ToDouble(xmlCandidat["NotaBac3"].InnerText);
                    c = new Candidat(nume,prenume, cnp,adresa,note,null);
                    listCandidati.Add(c);
                }

            }
        }
    }
}
