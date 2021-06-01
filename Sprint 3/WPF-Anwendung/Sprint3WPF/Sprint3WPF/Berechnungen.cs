using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint3WPF
{
    class Berechnungen
    {
        public Berechnungen()
        {

        }

        //Flächenträgheitsmoment
        public double getFlächenträgeitsmoment(double fl_d)
        {
            double fl_ergebnis;

            fl_ergebnis = (Math.PI * Math.Pow(fl_d, 4)) / 64;

            return Math.Round(fl_ergebnis, 3);
        }

        //Volumen
        public double getVolumen(double v_k_d, double v_k_l, double v_s_d, double v_s_l)
        {
            double v_ergebnis;
            double v_ergebnis_k;
            double v_ergebnis_s;

            v_ergebnis_k = Math.PI * 1 / 4 * Math.Pow(v_k_d, 2) * v_k_l;
            v_ergebnis_s = Math.PI * 1 / 4 * Math.Pow(v_s_d, 2) * v_s_l;

            v_ergebnis = v_ergebnis_k + v_ergebnis_s;

            return v_ergebnis;
        }

        //Gewicht 
        public double getMasse(double v_ergebnis, double dichte, double stkzahl)
        {
            double m_packung_ergebnis;

            m_packung_ergebnis = v_ergebnis * 0.001 * dichte * stkzahl;

            return m_packung_ergebnis;
        }

        //Preis
        public double getPreis(double m_packung_ergebnis, double schraubenart_preis, double festigkeit_preis)
        {
            double p_ergebnis;

            p_ergebnis = m_packung_ergebnis * schraubenart_preis * festigkeit_preis;

            return Math.Round(p_ergebnis, 2);
        }
    }
}
