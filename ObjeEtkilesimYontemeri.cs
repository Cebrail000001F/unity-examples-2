using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjeEtkilesimYontemeri : MonoBehaviour
{
    public bool yarısArabasıMı;
    public int MotorGucu = 80;
    public string[] arabaRenkleri;
    void Start()
    {
        /*
        if (MotorGucu>50)
        {
            yarısArabasıMı = true;                
        }
        else
        {
            yarısArabasıMı = false;
        }
        */
        /*
        foreach (var item in arabaRenkleri)
        {
            Debug.Log(item);
        }
        */
        /*
        GetComponent<BoxCollider>().isTrigger = true;
        GetComponent<BoxCollider>().enabled = false;
        */
        //GetComponentInParent<Rigidbody>().isKinematic = true;
        //GetComponentInChildren<Rigidbody>().isKinematic = true;



    }

    
    void Update()
    {
        
    }
}
