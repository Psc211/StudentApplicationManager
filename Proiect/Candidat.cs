using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    [Serializable]
    public class Candidat:ICloneable,IComparable<Candidat>
    {
        private string numeCandidat;
        private string prenume;
        private long cNP;
        private string adresa;
        private double[] noteBac;
        private List<Specializare> specializariAlese;

        public Candidat(string nume, string prenume, long cNP, string adresa, double[] noteBac, List<Specializare> specializariAlese)
        {
            this.numeCandidat = nume;
            this.prenume = prenume;
            this.cNP = cNP;
            this.adresa = adresa;
            this.noteBac = new double[noteBac.Length];
            for(int i = 0; i < noteBac.Length; i++)
            {
                this.noteBac[i] = noteBac[i];
            }

            this.specializariAlese = specializariAlese;
        }

        public Candidat()
        {
            noteBac = new double[3];
        }

        public string Nume { get => numeCandidat; set => numeCandidat = value; }
        public string Prenume { get => prenume; set => prenume = value; }
        public long CNP { get => cNP; set => cNP = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public double[] NoteBac { 
            get {
                double[] copie = new double[this.noteBac.Length];
                for(int i = 0; i < this.noteBac.Length; i++)
                {
                    copie[i]= this.noteBac[i];
                }
                return copie;
            }
            set{
                this.noteBac = new double[value.Length];
                for (int i = 0; i < this.noteBac.Length; i++)
                {
                    noteBac[i] = value[i];
                }
            }       
        }
        internal List<Specializare> SpecializariAlese { get => specializariAlese; set => specializariAlese = value; }

        public object Clone()
        {
            Candidat c1 = new Candidat(this.numeCandidat, this.prenume, this.cNP, this.adresa, this.noteBac, this.specializariAlese);
            return c1;
        }

        public int CompareTo(Candidat c1)
        {
            double m1=0, m2=0;
            for(int i = 0; i < this.noteBac.Length; i++)
            {
                m1+= this.noteBac[i];
                m2 += c1.noteBac[i];
            }
            m1 = m1 / this.noteBac.Length;
            m2=m2/c1.noteBac.Length;
            if (m1 > m2)
            {
                return 1;
            }else if (m1== m2)
            {
                return 0;
            }else { return -1; }
        }

        public override string ToString()
        {
            string afisare = "Candidatul " + numeCandidat + " " + prenume + " are CNP:" + cNP + Environment.NewLine + "Adresa lui este " + adresa + ". Notele obtinute la bacalaurea sunt:";
            for(int i = 0; i < noteBac.Length; i++)
            {
                afisare += noteBac[i].ToString()+" ";
            }
            if(specializariAlese != null)
            {
                afisare += Environment.NewLine + "Specializarile alese sunt:" + Environment.NewLine;
                foreach(Specializare s in specializariAlese)
                {
                    afisare += s.ToString()+Environment.NewLine;
                }
            }
            else
            {
                afisare += Environment.NewLine + "Nu exista specializari alese in acest moment.";
            }
            return afisare;
        }

        public double this[int index]
        {
            get
            {
                if (index >= 0 && index < noteBac.Length)
                {
                    return noteBac[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
                
               

            }
            set
            {
                noteBac[index] = value;
            }
        }

        public double CalculMedieBac()
        {
            double medie = 0;
            for(int i=0;i<noteBac.Length;i++)
            {
                medie += noteBac[i];
            }
            return medie/noteBac.Length;
        }

        public static Candidat operator++(Candidat c)
        {
            for(int i = 0; i < c.noteBac.Length; i++)
            {
                if ((c.noteBac[i] + 1) > 10)
                {
                    c.noteBac[i] = 10;
                }
                else
                {
                    c.noteBac[i] += 1;
                }
            }
            return c;
        }
        public static Candidat operator --(Candidat c)
        {
            for (int i = 0; i < c.noteBac.Length; i++)
            {
                if ((c.noteBac[i] - 1) < 1)
                {
                    c.noteBac[i] = 1;
                }
                else
                {
                    c.noteBac[i] -= 1;
                }
            }
            return c;
        }
        public double NotaObligatorie
        {
            get { return noteBac[0]; }
            set { noteBac[0] = value; }
        }
        public double NotaProfil
        {
            get { return noteBac[1]; }
            set { noteBac[1] = value; }
        }
        public double NotaOptional
        {
            get { return noteBac[2]; }
            set { noteBac[2] = value; }
        }
    }
}
