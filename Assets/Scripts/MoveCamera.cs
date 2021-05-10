using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{

    public GameObject cameraRig;

    public void MoveCameraForward()
    {
        cameraRig.transform.position = cameraRig.transform.position + new Vector3(0.0f, 0.0f, 6.0f);
    }

    public void MoveCameraBackwards()
    {
        cameraRig.transform.position = cameraRig.transform.position + new Vector3(0.0f, 0.0f, -6.0f);
    }

    public void MoveCameraLeft()
    {
        cameraRig.transform.position = cameraRig.transform.position + new Vector3(-6.0f, 0.0f, 0.0f);
    }

    public void MoveCameraRight()
    {
        cameraRig.transform.position = cameraRig.transform.position + new Vector3(6.0f, 0.0f, 6.0f);
    }
}
