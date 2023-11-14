using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    [Serializable]
    public class Specializare:IComparable<Specializare>,ICloneable
    {
        private string numeSpecializare;
        private double notaAdmitereBuget;
        private double notaAdmitereTaxa;

        public Specializare()
        {
        }

        public Specializare(string numeSpecializare, double notaAdmitereBuget, double notaAdmitereTaxa)
        {
            this.numeSpecializare = numeSpecializare;
            this.notaAdmitereBuget = notaAdmitereBuget;
            this.notaAdmitereTaxa = notaAdmitereTaxa;
        }

        public string NumeSpecializare { get => numeSpecializare; set => numeSpecializare = value; }
        public double NotaAdmitereBuget { get => notaAdmitereBuget; set => notaAdmitereBuget = value; }
        public double NotaAdmitereTaxa { get => notaAdmitereTaxa; set => notaAdmitereTaxa = value; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(Specializare s)
        {
            if (this.notaAdmitereBuget > s.notaAdmitereBuget)
            {
                return 1;
            }else if (this.notaAdmitereBuget > s.notaAdmitereBuget)
            {
                return -1;
            }else { return 0; }
        }

        public override string ToString()
        {
            string afisare="Specializarea " +numeSpecializare+Environment.NewLine+"Limita Buget:"
                +notaAdmitereBuget+Environment.NewLine+"Limita Taxa: "+notaAdmitereTaxa;
            return afisare;
        }

        public double diferentaBugetTaxa()
        {
            return notaAdmitereBuget=notaAdmitereTaxa;
        }

        public static Specializare operator ++(Specializare s)
        {
            if ((s.notaAdmitereBuget + 1) > 10)
            {
                s.notaAdmitereBuget = 10;
            }
            else
            {
                s.notaAdmitereBuget += 1;
            }
            if ((s.notaAdmitereTaxa + 1) > 10)
            {
                s.notaAdmitereTaxa = 10;
            }
            else
            {
                s.notaAdmitereTaxa += 1;
            }
            return s;
        }
        public static Specializare operator --(Specializare s)
        {
            if ((s.notaAdmitereBuget - 1) > 5)
            {
                s.notaAdmitereBuget -= 1 ;
            }
            else
            {
                s.notaAdmitereBuget = 5;
            }
            if ((s.notaAdmitereTaxa - 1) > 5)
            {
                s.notaAdmitereTaxa -= 1;
            }
            else
            {
                s.notaAdmitereTaxa = 5;
            }
            return s;
        }
    }
}
