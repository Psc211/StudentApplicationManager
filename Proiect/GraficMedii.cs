using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Proiect
{
    public partial class GraficMedii : Form
    {
        public GraficMedii(List<Candidat> listaCandidati)
        {
            InitializeComponent();
            chrtMedii.Series[0].Name = "Medii";
            chrtMedii.Series[0].ChartType = SeriesChartType.Column;
            double[] mediiBac = new double[listaCandidati.Count];
            string[]numeCandidati = new string[listaCandidati.Count];
            for(int i=0;i<listaCandidati.Count;i++)
            {
                mediiBac[i] = listaCandidati[i].CalculMedieBac();
                numeCandidati[i] = listaCandidati[i].Nume;
            }
            chrtMedii.Series[0].Points.DataBindXY(numeCandidati, mediiBac);

            chartStat2.Series[0].Name = "Densitate Medii";
            int[] frecvente = new int[10];
            chartStat2.Series[0].ChartType = SeriesChartType.Column;
            foreach (double nota in mediiBac)
            {
                
                if (nota != 10)
                {
                    frecvente[(int)nota % 10]++;
                }
                else
                {
                    frecvente[9]++;
                }
                chartStat2.Series[0].Points.AddXY(Math.Round(nota), nota != 10 ? frecvente[(int)nota % 10] : frecvente[9]);
            }

        }

        private void btnImprimare_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;

            if (printPreviewDialog.ShowDialog() == DialogResult.OK)
            {
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDocument;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bitmap;
            if(rdbDensitate.Checked)
            {
                bitmap = new Bitmap(chartStat2.Width, chartStat2.Height);
                chartStat2.DrawToBitmap(bitmap, new Rectangle(0, 0, chartStat2.Width, chartStat2.Height));
                e.Graphics.DrawImage(bitmap, e.MarginBounds);
            }
            else
            {
                bitmap = new Bitmap(chrtMedii.Width, chrtMedii.Height);
                chrtMedii.DrawToBitmap(bitmap, new Rectangle(0, 0, chrtMedii.Width, chrtMedii.Height));
                e.Graphics.DrawImage(bitmap, e.MarginBounds);
            }
            
        }

        

   
    }
}
