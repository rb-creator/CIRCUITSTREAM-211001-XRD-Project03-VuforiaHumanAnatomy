using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seethrough : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (GetComponent<Renderer>())
        {
            GetComponent<Renderer>().material.renderQueue = 3002;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
