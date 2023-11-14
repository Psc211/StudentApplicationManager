using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    internal interface IProcesAdmitere
    {
        bool EvalueazaStudent(double medie, double nota);
        List<Candidat> AdmitereCandidati(List<Candidat> listaCandidati,double s);
        double calcul(double[] noteBac);
    }
}
