using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    [Serializable]
    public class Facultate : IEnumerable
    {
        private int id;
        private string numeFacultate;
        private List<Specializare> specializari;

        public Facultate()
        {
        }

        public Facultate(string nume, List<Specializare> specializari,int id)
        {
            this.id = id;
            this.numeFacultate = nume;
            this.specializari = specializari;
        }

        public string NumeFacultate { get => numeFacultate; set => numeFacultate = value; }
        internal List<Specializare> Specializari { get => specializari; set => specializari = value; }
        public int Id { get => id; set => id = value; }

        private void adaugaSpecializare(Specializare specializare)
        {
            this.specializari.Add(specializare);
        }
        public override string ToString()
        {
            string afisare = Id+". "+"Facultatea " + numeFacultate;
            if(specializari.Count > 0)
            {
                afisare += " are urmatoarele specializari:" + Environment.NewLine;
            }
            foreach(Specializare special in specializari) {
                afisare += special.ToString()+ Environment.NewLine;
            }
            return afisare;
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)Specializari).GetEnumerator();
        }

        public Specializare this[int index]
        {
            get
            {
                if (index >= 0 && index < specializari.Count())
                {
                    return specializari[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                specializari[index] = value;
            }
        }
        public static bool operator<(Facultate s1,Facultate s2)
        {
            if(s1.specializari.Count() < s2.specializari.Count())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >(Facultate s1, Facultate s2)
        {
            if (s1.specializari.Count() > s2.specializari.Count())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
