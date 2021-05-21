using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint3WPF
{
    class CatiaConnection
    {
       
        INFITF.Application hsp_catiaApp;
        MECMOD.PartDocument hsp_catiaPart;
        MECMOD.Sketch hsp_catiaProfil;

    }
    public bool CatiaLaeuft()
    {
        try
        {
            object catiaObj = System.Runtime.InteropServices.Marshal.GetActiveObject("CATIA.Application");
            hsp_catiaApp = (INFITF.Application)catiaObj;
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
    public void ErzeugePart() 
    {
        Documents catDocuments = hsp_catiaApp.Documents;
        hsp_catiaPart = (PartDocument)catDocuments.Add("Part");
        return true;
    }
    public void ErstelleLeereSkizze()
    {
        //geometrisches set auswählen und umbenennen
        HybridBodies catHybridBodies1 = hsp_catiaPart.Part.HybridBodies;
        HybridBody catHybridBody1;

        try
        {
            catHybridBody1 = catHybridBodies1.Item("Geometrisches Set.1");
        }
        catch (Exception)
        {
            MessageBox.Show("Kein geometrisches Set gefunden!\nEin PART manuell erzeugen und darauf achten, dass ein 'Geometisches Set' aktiviert ist.", "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }




    }
