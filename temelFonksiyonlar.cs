using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temelFonksiyonlar : MonoBehaviour
{  

    /*
    void Start()
    {
        Debug.Log("start fonksiyonundan geliyorum");
    }


    //ilk cal�san, 1 kez cal�s�r
     private void Awake()
     {
         Debug.Log("Awake fonksiyonundan geliyorum");
     }
    */
    
    /*
    private void OnEnable()
    {
        Debug.Log("OnEnable fonksiyonundan geliyorum");
    }
    
    
    private void OnDisable()
    {
    Debug.Log("OnDisable fonksiyonundan geliyorum");
    }
    */

    
     // UpDateler surekli cal�s�r
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate fonksiyonundan geliyorum");
    }
    void Update()
    {
        Debug.Log("Update fonksiyonundan geliyorum");
    }

    private void LateUpdate()
    {
        Debug.Log("LateUpdate fonksiyonundan geliyorum");
    }
    

}
