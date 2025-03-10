using System;
using System.Collections.Generic;

public class KodePos
{

    String[] dataDaerah =
        {
            "Batununggal",
            "Kujangsari",
            "Mengger",
            "Wates",
            "Cijawura",
            "Jatisari",
            "Margasari",
            "Sekejati",
            "Kebonwaru",
            "Maleer",
            "Samoja"
        };

    String[] dataCodePos =
    {
            "40266",
            "40287",
            "40267",
            "40256",
            "40287",
            "40286",
            "40286",
            "40286",
            "40272",
            "40274",
            "40273"
        };


    // Method untuk mengembalikan kode pos berdasarkan kelurahan
    public string GetKodePos(string kelurahan)
    {
        for (int i = 0; i < dataDaerah.Length; i++)
        {
            if (dataDaerah[i].Equals(kelurahan, StringComparison.OrdinalIgnoreCase))
            {
                return dataCodePos[i];
            }
        }
        return $"Kode pos tidak ditemukan untuk kelurahan: {kelurahan}";
    }

}
