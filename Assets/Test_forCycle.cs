using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_forCycle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start test");
        //for (int i = -21; i > 21; i = i + 6)
        //{
        //    Debug.Log("i = " + i);
        //}
        int i=-21;
        while (i < 22)
        {
            Debug.Log("i = " + i);
            i = i + 6;
        }

    }

    // Update is called once per frame
    void Update()
    {
    }
}
