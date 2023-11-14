using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Proiect
{
    public partial class Principal : Form
    {
        List<Candidat> listaCandidati = new List<Candidat>();
        List<Facultate> listaFacultati = new List<Facultate>();
        SqlConnection conexiune;
        SqlCommand command;
        DataTable dt;
        Candidat candidat;
        public Principal()
        {
            InitializeComponent();
            Candidat c= new Candidat();
            conexiune = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DataBase_Project;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conexiune.Open();
            command = new SqlCommand("SELECT * FROM CANDIDATI",conexiune);
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                c.Nume=reader.GetString(0);
                c.Prenume=reader.GetString(1);
                c.Adresa=reader.GetString(2);
                c.CNP = Convert.ToInt64(reader.GetInt32(3));
                double[] note = new double[3];
                note[0]=reader.GetDouble(4);
                note[1] = reader.GetDouble(5);
                note[2] = reader.GetDouble(6);
                c.NoteBac = note;
                listaCandidati.Add((Candidat)c.Clone());
            }
            conexiune.Close();
            dt =  new DataTable();
            dt.Columns.Add("Nume");
            dt.Columns.Add("Prenume");
            dt.Columns.Add("Adresa");
            dt.Columns.Add("CNP");
            dt.Columns.Add("Proba Obligatorie");
            dt.Columns.Add("Proba Profil");
            dt.Columns.Add("Proba Optionala");
            dt.Columns.Add("Medie Bac");
            foreach(Candidat cand in listaCandidati)
            {
                dt.Rows.Add(cand.Nume, cand.Prenume, cand.Adresa, cand.CNP, cand.NoteBac[0], cand.NoteBac[1], cand.NoteBac[2], cand.CalculMedieBac());
                listBox1.Items.Add(cand.Nume);
            }
            


        }

        private void btnAdaugareCandidati_Click(object sender, EventArgs e)
        {
            FormularAdaugareCandidati fAC= new FormularAdaugareCandidati();
            DialogResult dialogResult = fAC.ShowDialog();
            if(dialogResult == DialogResult.Abort) {
                foreach(Candidat c in fAC.ListCandidati)
                {
                    listaCandidati.Add(c);
                    listBox1.Items.Add(c.Nume);
                    dt.Rows.Add(c.Nume, c.Prenume, c.Adresa, c.CNP, c.NoteBac[0], c.NoteBac[1], c.NoteBac[2], c.CalculMedieBac());
                }
                MessageBox.Show(listaCandidati.Count > 0 ? "S-a adaugat cu succes!":"Nu s-a adaugat nimic" );
            }
        }
        private void btnAdaugareFacultati_Click(object sender, EventArgs e)
        {
            FormularAdaugareFacultate fAF = new FormularAdaugareFacultate();
            DialogResult dialogResult = fAF.ShowDialog();
            if( dialogResult == DialogResult.Abort )
            {
                foreach(Facultate f in fAF.FacultateList)
                {
                    listaFacultati.Add(f);
                }
                MessageBox.Show(listaFacultati.Count > 0 ? "S-a adaugat cu succes!" : "Nu s-a adaugat nimic");
            }
        }

        private void textFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK )
            {
                StreamWriter streamWriter= new StreamWriter(saveFileDialog1.FileName);
                streamWriter.Write("===Candidati===" + Environment.NewLine);
                foreach(Candidat c in listaCandidati)
                {
                    streamWriter.Write(c.ToString()+Environment.NewLine);
                }
                streamWriter.Write("===Facultati===" + Environment.NewLine);
                foreach(Facultate f in listaFacultati)
                {
                    streamWriter.Write(f.ToString()+Environment.NewLine);
                }
                streamWriter.Close();
            }
        }

        private void textFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.txt)|*.txt";
            if(openFileDialog1.ShowDialog(this) == DialogResult.OK )
            {
                StreamReader streamReader= new StreamReader(openFileDialog1.FileName);
                MessageBox.Show(streamReader.ReadToEnd());
                streamReader.Close();
            }
        }

        private void binaryFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fileStream1 = new FileStream("Candidats.bin", FileMode.Create, FileAccess.Write);
            FileStream fileStream2 = new FileStream("Facultys.bin", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fileStream1, listaCandidati);
            bf.Serialize(fileStream2, listaFacultati);
            fileStream1.Close();
            fileStream2.Close();
        }

        private void binaryFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FileStream fileStream1 = new FileStream("Candidats.bin", FileMode.Open, FileAccess.Read);
            FileStream fileStream2 = new FileStream("Facultys.bin", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            listaCandidati = ((List < Candidat >) bf.Deserialize(fileStream1));
            listaFacultati = ((List<Facultate>)bf.Deserialize(fileStream2));
            fileStream1.Close();
            fileStream2.Close();
            foreach(Candidat c in listaCandidati)
            {
                MessageBox.Show(c.ToString());
            }

        }

        private void btnEvaluareCandidati_Click(object sender, EventArgs e)
        {
            FormularEvaluareCandidati form = new FormularEvaluareCandidati(listaCandidati,listaFacultati);
            form.Show();
        }

        private void btnStatistica_Click(object sender, EventArgs e)
        {
            GraficMedii formGrafic = new GraficMedii(listaCandidati);
            formGrafic.Show();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            List<Specializare> list = new List<Specializare>();
            foreach(Facultate f in listaFacultati)
            {
                foreach(Specializare s in f.Specializari)
                {
                    list.Add(s);
                }
            }
            FormularEvaluareSinguraCandidat formularEvaluareSinguraCandidat = new FormularEvaluareSinguraCandidat(listaCandidati,list);
            formularEvaluareSinguraCandidat.Show();
      
        }


        private bool seMisca = false;
        private int index = -1;
        private object obiectMutat = null;
        private void ListBox1_MouseDown(object sender, MouseEventArgs e)
        {
            int index = listBox1.IndexFromPoint(e.X, e.Y);
            if (index >= 0 && index < listBox1.Items.Count)
            {
                seMisca = true;
                this.index = index;
                obiectMutat = listBox1.Items[index];
                listBox1.DoDragDrop(obiectMutat, DragDropEffects.Move);
            }
        }

        private void ListBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (seMisca && obiectMutat != null)
            {
                listBox1.Invalidate();
            }
        }

        private void ListBox1_MouseUp(object sender, MouseEventArgs e)
        {
            seMisca = false;
            index = -1;
            obiectMutat = null;
            listBox1.Invalidate();
        }

        private void ListBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void ListBox1_DragDrop(object sender, DragEventArgs e)
        {
            Point punct = listBox1.PointToClient(new Point(e.X, e.Y));
            int indexTo = listBox1.IndexFromPoint(punct);
            if (indexTo >= 0 && indexTo < listBox1.Items.Count)
            {
                object droppedItem = e.Data.GetData(typeof(string));
                if (droppedItem != null)
                {
                    listBox1.Items.Remove(obiectMutat);
                    listBox1.Items.Insert(indexTo, droppedItem);
                }
            }
            obiectMutat = null;
        }

        private void ListBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedItem = listBox1.SelectedItem.ToString();
                Clipboard.SetText(selectedItem);
            }
        }

    }
}
