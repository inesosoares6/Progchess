using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Script : MonoBehaviour
{
    private int count;
    public AudioSource audioData;
    public GameObject piece;
    private int aux;
    private float angle;
    private float curPos;
    private float prevPos;
    private float speed;
    public GameObject cameraRig;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        aux = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void performMove()
    {
        switch (count)
        {
            case 1:
                audioData.Play(0);
                break;
            case 2:
                rotate360();
                count = 0;
                break;
        }
    }

    private void rotate360()
    {
        
    }

    public void clicked()
    {
        count++;
        performMove();
    }
}
