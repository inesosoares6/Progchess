using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightScript : MonoBehaviour
{
    private int count;
    public AudioSource audioData;
    public GameObject knight;
    public GameObject cameraRig;
    public GameObject chessBoard;
    public GameObject buttonKnight;
    public GameObject buttonPawn;
    public GameObject buttonKing;
    public GameObject buttonBishop;
    public GameObject buttonQueen;
    public GameObject buttonTower;
    public GameObject arrowL1;
    public GameObject arrowL2;
    public GameObject arrowT1;
    public GameObject arrowT2;

    private void chooseAction()
    {
        switch (count)
        {
            case 1:
                audioData.Play(0);
                if(knight.transform.position.z >= 12)
                {
                    count = 2;
                }
                break;
            case 2:
                showDirections();
                count = 0;
                break;
            case 3:
                endGame();
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
        arrowL1.SetActive(true);
        arrowL1.transform.position = knight.transform.position + new Vector3(6.0f,0.0f,7.0f);

        arrowL2.SetActive(true);
        arrowL2.transform.position = knight.transform.position + new Vector3(-6.0f, 0.0f, 7.0f);

        arrowT1.SetActive(true);
        arrowT1.transform.position = knight.transform.position + new Vector3(-2.0f, 0.0f, 12.0f);

        arrowT2.SetActive(true);
        arrowT2.transform.position = knight.transform.position + new Vector3(2.0f, 0.0f, 12.0f);

        cameraRig.transform.position = knight.transform.position + new Vector3(0.0f, 20.0f, 0.0f);
        cameraRig.transform.rotation = new Quaternion(90.0f, 0.0f, 0.0f, 180.0f);
    }

    public void MoveRightFront()
    {
        knight.transform.position = knight.transform.position + new Vector3(6.0f, 0.0f, 0.0f);
        knight.transform.position = knight.transform.position + new Vector3(0.0f, 0.0f, 6.0f);
        knight.transform.position = knight.transform.position + new Vector3(0.0f, 0.0f, 6.0f);
        DeleteArrows();
    }

    public void MoveLeftFront()
    {
        knight.transform.position = knight.transform.position + new Vector3(-6.0f, 0.0f, 0.0f);
        knight.transform.position = knight.transform.position + new Vector3(0.0f, 0.0f, 6.0f);
        knight.transform.position = knight.transform.position + new Vector3(0.0f, 0.0f, 6.0f);
        DeleteArrows();
    }

    public void MoveFrontRight()
    {
        knight.transform.position = knight.transform.position + new Vector3(0.0f, 0.0f, 6.0f);
        knight.transform.position = knight.transform.position + new Vector3(0.0f, 0.0f, 6.0f);
        knight.transform.position = knight.transform.position + new Vector3(6.0f, 0.0f, 0.0f);
        DeleteArrows();
    }

    public void MoveFrontLeft()
    {
        knight.transform.position = knight.transform.position + new Vector3(0.0f, 0.0f, 6.0f);
        knight.transform.position = knight.transform.position + new Vector3(0.0f, 0.0f, 6.0f);
        knight.transform.position = knight.transform.position + new Vector3(-6.0f, 0.0f, 0.0f);
        DeleteArrows();
    }

    private void DeleteArrows()
    {
        arrowL1.SetActive(false);
        arrowL2.SetActive(false);
        arrowT1.SetActive(false);
        arrowT2.SetActive(false);
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

    private void endGame()
    {

    }

}
