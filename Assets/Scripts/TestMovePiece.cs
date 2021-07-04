using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMovePiece : MonoBehaviour
{
    public GameObject square;

    // Start is called before the first frame update
    void Start()
    {
        square.transform.position = new Vector3(-4.375f, 0.01f, -4.375f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void moveRight()
    {
        square.transform.position = square.transform.position + new Vector3(1.25f, 0.0f, 0.0f);
    }
}
