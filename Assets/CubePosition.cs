using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePosition : MonoBehaviour
{
    public GameObject cube_up;
    public GameObject cube_down;
    public GameObject cube_left;
    public GameObject cube_right;
    public GameObject camera_rig;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cube_up.transform.position = camera_rig.transform.position + new Vector3(0.0f, 5.0f, 8.0f);
        cube_down.transform.position = camera_rig.transform.position + new Vector3(0.0f, 3.5f, 8.0f);
        cube_left.transform.position = camera_rig.transform.position + new Vector3(-1.50f, 4.25f, 8.0f);
        cube_right.transform.position = camera_rig.transform.position + new Vector3(1.50f, 4.25f, 8.0f);
    }
}
