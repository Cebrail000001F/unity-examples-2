using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baba : dede
{
    public int babayaMirasKalanAltın = 500;
    public string babayaKalandigerMiras = "saray,koyunlar";
    public int mirasBırakılanAltın = 10;
    private int bagıslananAltın = 490;
    private string bagıslananDigerMiraslar = "saray,koyunlar";
    void Start()
    {

        Debug.Log("baba; 500 tane altın alır: " + babayaMirasKalanAltın);
        Debug.Log("baba; saray ve koyunları alır: " + babayaKalandigerMiras);
        Debug.Log("miras olmayanlardan almaz.." +
            "tum serveti bagıs yapar ve cocuguna sadece 10 altın bırakır.. sonrada geberir.");
    }

   
}
