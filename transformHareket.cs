using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformHareket : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // transform.position = new Vector3(2f, 5f, 7f);
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(2f, 5f, 7f);
        transform.Translate(new Vector3(2f, 3f, 4f)*Time.deltaTime* 5f);
    }
}
