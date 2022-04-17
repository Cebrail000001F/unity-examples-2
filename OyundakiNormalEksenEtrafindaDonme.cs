using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyundakiNormalEksenEtrafindaDonme : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(5f, 3f, 7f, Space.World);
    }
}
