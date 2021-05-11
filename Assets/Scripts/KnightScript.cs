using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightScript : MonoBehaviour
{
    private int count;
    public AudioSource audioData;
    public GameObject arrow1;
    public GameObject arrow2;
    public GameObject arrow3;
    public GameObject knight;
    public GameObject cameraRig;
    public GameObject chessBoard;
    public GameObject buttonKnight;
    public GameObject buttonPawn;
    public GameObject buttonKing;
    public GameObject buttonBishop;
    public GameObject buttonQueen;
    public GameObject buttonTower;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void chooseAction()
    {
        switch (count)
        {
            case 1:
                audioData.Play(0);
                break;
            case 2:
                showDirections();
                count = 0;
                break;
        }
    }

    public void clicked()
    {
        count++;
        chooseAction();
    }

    private void showDirections()
    {
        arrow1.SetActive(true);
        arrow1.transform.position = knight.transform.position + new Vector3(3.0f,0.0f,0.0f);
        //arrow1.transform.rotation = new Quaternion(45.0f, 0.0f, 0.0f, 0.0f);
        arrow2.SetActive(true);
        arrow2.transform.position = knight.transform.position + new Vector3(6.0f, 0.0f, 3.0f);
        //arrow2.transform.rotation = new Quaternion(1.0f, 0.0f, 0.0f, 0.0f);
        arrow3.SetActive(true);
        arrow3.transform.position = knight.transform.position + new Vector3(6.0f, 0.0f, 9.0f);
        //arrow3.transform.rotation = new Quaternion(1.0f, 0.0f, 0.0f, 0.0f);

        cameraRig.transform.position = knight.transform.position + new Vector3(0.0f, 20.0f, 0.0f);
        cameraRig.transform.rotation = new Quaternion(90.0f, 0.0f, 0.0f, 180.0f);
    }

    public void MoveSideFront()
    {
        knight.transform.position = knight.transform.position + new Vector3(6.0f, 0.0f, 0.0f);
        knight.transform.position = knight.transform.position + new Vector3(0.0f, 0.0f, 6.0f);
        knight.transform.position = knight.transform.position + new Vector3(0.0f, 0.0f, 6.0f);
        DeleteArrows();
    }

    public void MoveFrontSide()
    {

    }

    private void DeleteArrows()
    {
        arrow1.SetActive(false);
        arrow2.SetActive(false);
        arrow3.SetActive(false);
    }

    public void beginKnight()
    {
        chessBoard.SetActive(true);
        knight.SetActive(true);
        buttonKnight.SetActive(false);
        buttonBishop.SetActive(false);
        buttonKing.SetActive(false);
        buttonQueen.SetActive(false);
        buttonTower.SetActive(false);
        buttonPawn.SetActive(false);
    }

}
