using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    internal class ProcesAdmitereMedie : IProcesAdmitere
    {
        public List<Candidat> AdmitereCandidati(List<Candidat> listaCandidati, double s)
        {
            List<Candidat> listaAdmisi = new List<Candidat>();
            foreach(Candidat c in listaCandidati)
            {
                if (EvalueazaStudent(this.calcul(c.NoteBac), s) == true)
                {
                    listaAdmisi.Add(c);
                }
            }
            return listaAdmisi;
        }

        public double calcul(double[] noteBac)
        {
            float medie = 0;
            foreach (float notaBac in noteBac)
            {
                medie += notaBac;
            }
            return medie / noteBac.Length;
        }

       

        public bool EvalueazaStudent(double medie, double nota)
        {
            if (medie > nota)
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
