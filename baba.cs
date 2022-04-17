using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baba : dede
{
    public int babayaMirasKalanAltýn = 500;
    public string babayaKalandigerMiras = "saray,koyunlar";
    public int mirasBýrakýlanAltýn = 10;
    private int bagýslananAltýn = 490;
    private string bagýslananDigerMiraslar = "saray,koyunlar";
    void Start()
    {

        Debug.Log("baba; 500 tane altýn alýr: " + babayaMirasKalanAltýn);
        Debug.Log("baba; saray ve koyunlarý alýr: " + babayaKalandigerMiras);
        Debug.Log("miras olmayanlardan almaz.." +
            "tum serveti bagýs yapar ve cocuguna sadece 10 altýn býrakýr.. sonrada geberir.");
    }

   
}
