using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsolePrint : MonoBehaviour
{
    int i = 3;
    // Start is called before the first frame update
    void Start()
    {
         
        Debug.Log("GameObject_" + gameObject.name + ":" + i);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("GameObject_" + gameObject.name + ":" + (i + 1));
    }
}
