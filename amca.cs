using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class amca : dede
{
    public int amcayaMirasKalanAlt�n = 500;
    public string amcayaKalandigerMiras = "ev,araba,okuzler";
    void Start()
    {
        Debug.Log("amca; 500 tane alt�n al�r: " + amcayaMirasKalanAlt�n);
        Debug.Log("amca; 1 ev, 1 araba ve okuzleri al�r: " + amcayaKalandigerMiras);
        Debug.Log("miras olmayanlardan almaz.. tam bir pust..." +
            " ve tum serveti kar� k�zla yer ve krallar gibi yasar");

    }

    
}
