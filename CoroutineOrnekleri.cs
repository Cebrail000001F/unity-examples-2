using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineOrnekleri : MonoBehaviour
{
    /* 
     private void Start()
     {       
         StartCoroutine(araba());   
     } 
       IEnumerator araba()
     {
         yield return new WaitForSeconds(4);
         Debug.Log("4 saniye sonra yazar");
     }
     private void LateUpdate()
     {
         Debug.Log(Time.time);
     }
    */
    
     void Start()
    {
        Invoke("atesEt", 1f);
        InvokeRepeating("kac", 1f,2f);
       
    }
    void atesEt()
    {
        Debug.Log("bam");
    }
    void kac()
    {
        Debug.Log("topuk");
    }

}
