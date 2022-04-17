using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListExamp: MonoBehaviour
{
    public List<string> Arabalar = new List<string>();
    void Start()
    {
        Arabalar.Add("BMWJ");
        Debug.Log(Arabalar.Count);
        Debug.Log(Arabalar[4]);
        

    }
    private void Update()
    {
        //  Debug.Log(Arabalar[4]);
         Arabalar.Insert(4, "BMWJ");
        Arabalar.Clear();
    }

}
