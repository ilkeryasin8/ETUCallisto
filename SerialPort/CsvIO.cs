using System;

namespace Csv
{
    public class CsvIO
    {
        int takimNo;
        int paketNumarasi;
        string gondermeSaati;
        double basinc1;
        double basinc2;
        double yukseklik1;
        double yukseklik2;
        double irtifaFarkı;
        double inisHizi;
        double sicaklik;
        double pilGerilimi;
        double GPS1_latitude;
        double GPS1_longitude;
        double GPS1_altitude;
        double GPS2_latitude;
        double GPS2_longitude;
        double GPS2_altitude;
        int uyduStatus;
        double pitch;
        double roll;
        double yaw;
        int donusSayisi;
        private string videoAktarimBilgisi;

        public CsvIO(string line)
        {
            string[] list = line.Split(',');

            takimNo = int.Parse(list[0].Substring(1, list[0].Length - 1));
            paketNumarasi = int.Parse(list[1].Substring(1, list[1].Length - 1));
            gondermeSaati = list[2].Substring(1, list[1].Length - 1);
            basinc1 = double.Parse(list[3].Substring(1, list[3].Length - 1));
            basinc2 = double.Parse(list[4].Substring(1, list[4].Length - 1));
            yukseklik1 = double.Parse(list[5].Substring(1, list[5].Length - 1));
            yukseklik2 = double.Parse(list[6].Substring(1, list[6].Length - 1));
            irtifaFarkı = double.Parse(list[7].Substring(1, list[7].Length - 1));
            inisHizi = double.Parse(list[8].Substring(1, list[8].Length - 1));
            sicaklik = double.Parse(list[9].Substring(1, list[9].Length - 1));
            pilGerilimi = double.Parse(list[10].Substring(1, list[10].Length - 1));
            GPS1_latitude = double.Parse(list[11].Substring(1, list[11].Length - 1));
            GPS1_longitude = double.Parse(list[12].Substring(1, list[12].Length - 1));
            GPS1_altitude = double.Parse(list[13].Substring(1, list[13].Length - 1));
            GPS2_latitude = double.Parse(list[14].Substring(1, list[14].Length - 1));
            GPS2_longitude = double.Parse(list[15].Substring(1, list[15].Length - 1));
            GPS2_altitude = double.Parse(list[16].Substring(1, list[16].Length - 1));
        }

        
    }
}