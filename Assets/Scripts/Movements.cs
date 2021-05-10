using UnityEngine;

public class Movements : MonoBehaviour
{
    Rigidbody rb;
    private int jumpspeed = 0;
    private int movespeed = 0;
    private int count = 0;
    public GameObject go;

    private void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(count % 2 == 0)
        {
            movespeed = 0;
        }
        else
        {
            movespeed = 1;
            MoveForward();
        }
    }

    public void Jump()
    {
        Vector3 balljump = new Vector3(0.0f, 1.0f, 0.0f);
        rb.AddForce(balljump * jumpspeed);
    }

    public void MoveForward()
    {
        Vector3 ballmove = new Vector3(0.0f, 1.0f, 0.0f);
        rb.AddForce(ballmove * movespeed);
    }

    public void MoveSideways()
    {
        Vector3 ballmove = new Vector3(1.0f, 0.0f, 0.0f);
        rb.AddForce(ballmove * movespeed);
    }

    public void Move1spaceRight()
    {
        go.transform.position = go.transform.position + new Vector3(6.0f,0.0f,0.0f);
    }

    public void Move1spaceLeft()
    {
        go.transform.position = go.transform.position + new Vector3(-6.0f, 0.0f, 0.0f);
    }

    public void Move1spaceForward()
    {
        go.transform.position = go.transform.position + new Vector3(0.0f, 0.0f, 6.0f);
    }

    public void Move1spaceBackwards()
    {
        go.transform.position = go.transform.position + new Vector3(0.0f, 0.0f, -6.0f);
    }

    public void increaseCount()
    {
        count = count + 1;
    }
}
