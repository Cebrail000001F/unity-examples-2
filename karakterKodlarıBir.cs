using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakterKodlar─▒Bir : MonoBehaviour
{
    
    void Start()
    {
        GameObject.Find("seviye").GetComponent<seviyeBirKodlar>().saglik = 70;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
