using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baba : dede
{
    public int babayaMirasKalanAlt�n = 500;
    public string babayaKalandigerMiras = "saray,koyunlar";
    public int mirasB�rak�lanAlt�n = 10;
    private int bag�slananAlt�n = 490;
    private string bag�slananDigerMiraslar = "saray,koyunlar";
    void Start()
    {

        Debug.Log("baba; 500 tane alt�n al�r: " + babayaMirasKalanAlt�n);
        Debug.Log("baba; saray ve koyunlar� al�r: " + babayaKalandigerMiras);
        Debug.Log("miras olmayanlardan almaz.." +
            "tum serveti bag�s yapar ve cocuguna sadece 10 alt�n b�rak�r.. sonrada geberir.");
    }

   
}
