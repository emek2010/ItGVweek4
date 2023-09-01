using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsolePrint : MonoBehaviour
{
    int frameCounter = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        frameCounter = frameCounter + 1;
        Debug.Log(gameObject.name + "" + frameCounter);
    }
}
