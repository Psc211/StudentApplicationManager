using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    internal class ProcesAdmiterePonderat : IProcesAdmitere
    {
        public List<Candidat> AdmitereCandidati(List<Candidat> listaCandidati, double s)
        {
            List<Candidat> listaAdmisi = new List<Candidat>();
            foreach (Candidat c in listaCandidati)
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
            double medie = 0;
            medie += noteBac[0] * 50;
            medie += noteBac[1] * 30;
            medie += noteBac[2] * 20;
            return medie/100;
        }

        

        public bool EvalueazaStudent(double medie, double nota)
        {
            if (medie  > nota)
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
