using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class amca : dede
{
    public int amcayaMirasKalanAltýn = 500;
    public string amcayaKalandigerMiras = "ev,araba,okuzler";
    void Start()
    {
        Debug.Log("amca; 500 tane altýn alýr: " + amcayaMirasKalanAltýn);
        Debug.Log("amca; 1 ev, 1 araba ve okuzleri alýr: " + amcayaKalandigerMiras);
        Debug.Log("miras olmayanlardan almaz.. tam bir pust..." +
            " ve tum serveti karý kýzla yer ve krallar gibi yasar");

    }

    
}
