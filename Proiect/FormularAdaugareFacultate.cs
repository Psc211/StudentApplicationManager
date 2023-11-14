using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class FormularAdaugareFacultate : Form
    {
        List<Facultate> facultateList = new List<Facultate>();
        List<Specializare> specializari = new List<Specializare>();
        SqlConnection conexiune;
        SqlCommand command;
        int idFac ;
        Random nrRand = new Random();
        public FormularAdaugareFacultate()
        {
            InitializeComponent();
            conexiune = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DataBase_Project;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conexiune.Open();
            command = new SqlCommand("Select max(id) from facultati", conexiune);
            object rezultat=command.ExecuteScalar();
            if (rezultat != null)
            {
                idFac = Convert.ToInt32(rezultat);
                idFac++;
            }
            conexiune.Close();
        }

        internal List<Facultate> FacultateList { get => facultateList; set => facultateList = value; }

        private void btnAdaugareFaculatate_Click(object sender, EventArgs e)
        {
            Facultate f = new Facultate();
            f.NumeFacultate = tbNumeFacultate.Text;
            f.Specializari = new List<Specializare>();
            f.Id = idFac;
            adaugaFacBD(f.NumeFacultate);
            foreach (Specializare special in specializari)
            {
                f.Specializari.Add(special);
                adaugaSpecializareBD(special);
            }
            specializari.Clear();
            tbNumeFacultate.Clear();
            idFac++;
            facultateList.Add(f);
        }

        private void btnAdaugaSpecializare_Click(object sender, EventArgs e)
        {
            Specializare s= new Specializare();
            s.NumeSpecializare= tbNumeSpecializare.Text;
            s.NotaAdmitereBuget=Convert.ToDouble(tbNotaBuget.Text);
            s.NotaAdmitereTaxa=Convert.ToDouble(tbNotaTaxa.Text);
            specializari.Add(s);
            tbNumeSpecializare.Clear();
            tbNotaBuget.Clear();
            tbNotaTaxa.Clear();
        }

        private void adaugaFacBD(String numeFacultate)
        {
            conexiune.Open();
            command = new SqlCommand("INSERT INTO FACULTATI(id,Nume) VALUES (@id,@nume)", conexiune);
            command.Parameters.AddWithValue("@id",idFac);
            command.Parameters.AddWithValue("@nume", numeFacultate);
            command.ExecuteNonQuery();
            conexiune.Close();
            MessageBox.Show("Facultate inserata in baza de date!");
            
        }
        private void adaugaSpecializareBD(Specializare s)
        {
            conexiune.Open();
            command = new SqlCommand("INSERT INTO Specializari(id,Nume_specializare,nota_buget,nota_taxa,id_facultate) VALUES (@id,@nume,@buget,@taxa,@fac)", conexiune);
            command.Parameters.AddWithValue("@id", nrRand.Next(100000));
            command.Parameters.AddWithValue("@nume", s.NumeSpecializare);
            command.Parameters.AddWithValue("@buget", s.NotaAdmitereBuget);
            command.Parameters.AddWithValue("@taxa", s.NotaAdmitereTaxa);
            command.Parameters.AddWithValue("@fac", idFac);
            command.ExecuteNonQuery();
            conexiune.Close();
        }
    }
}
