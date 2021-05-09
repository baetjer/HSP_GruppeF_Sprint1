using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2WPF
{
    class Berechnungen
    {
        //Flächenträgheitsmoment
        public double getFlächenträgeitsmoment(double fl_d)
        {
            double fl_ergebnis;

            fl_ergebnis = (Math.PI * Math.Pow(fl_d, 4)) / 64;

            return fl_ergebnis;
        }

        //Volumen
        public double getVolumen(double v_k_d, double v_k_l, double v_s_d, double v_s_l, double v_gw_d, double v_gw_l)
        {
            double v_ergebnis;
            double v_ergebnis_k;
            double v_ergebnis_s;
            double v_ergebnis_gw;

            v_ergebnis_k = Math.PI * (1 / 4) * Math.Pow(v_k_d, 2) * v_k_l;
            v_ergebnis_s = Math.PI * (1 / 4) * Math.Pow(v_s_d, 2) * v_s_l;
            v_ergebnis_gw = Math.PI * (1 / 4) * Math.Pow(v_gw_d, 2) * v_gw_l;

            v_ergebnis = v_ergebnis_k + v_ergebnis_s + v_ergebnis_gw;

            return v_ergebnis;
        }

        //Gewicht 
        public double getMasse(double v_ergebnis, double dichte, double stkzahl)
        {
            double m_packung_ergebnis;

            m_packung_ergebnis = v_ergebnis * dichte * stkzahl;

            return m_packung_ergebnis;
        }

        //Preis
        public double getPreis(double stkzahl, double m_einzel_ergebnis, double wspreis)
        {
            double p_ergebnis;

            p_ergebnis = stkzahl * m_einzel_ergebnis * wspreis;

            return p_ergebnis;
        }
    }
}
