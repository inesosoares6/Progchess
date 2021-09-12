using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;
using System;

public class BoardSetupLevel2 : MonoBehaviour
{
    public GameObject back2scenesButton;
    public GameObject back2levelsButton;
    public GameObject board;
    public GameObject levels;
    public GameObject king;
    public GameObject knight;
    public GameObject pawn;
    public GameObject tower;
    public GameObject queen;
    public GameObject bishop;
    public AudioSource rightAnswer;
    public AudioSource wrongAnswer;
    private string piece;
    private GameObject objectClicked;

    public void checkAnswer(Vector3 position)
    {
        if (piece == "pawn" && Math.Abs(position.z) == 3.125)
        {
            rightAnswer.Play(0);
            pawn.SetActive(false);
            initiateLevel2();
        }
        else if (piece == "queen" && (position.x == 0.625 && Math.Abs(position.z) == 4.375))
        {
            rightAnswer.Play(0);
            queen.SetActive(false);
            initiateLevel2();
        }
        else if (piece == "king" && (position.x == -0.625 && Math.Abs(position.z) == 4.375))
        {
            rightAnswer.Play(0);
            king.SetActive(false);
            initiateLevel2();
        }
        else if (piece == "knight" && (Math.Abs(position.x) == 3.125 && Math.Abs(position.z) == 4.375))
        {
            rightAnswer.Play(0);
            knight.SetActive(false);
            initiateLevel2();
        }
        else if (piece == "tower" && (Math.Abs(position.x) == 4.375 && Math.Abs(position.z) == 4.375))
        {
            rightAnswer.Play(0);
            tower.SetActive(false);
            initiateLevel2();
        }
        else if (piece == "bishop" && (Math.Abs(position.x) == 1.875 && Math.Abs(position.z) == 4.375))
        {
            rightAnswer.Play(0);
            bishop.SetActive(false);
            initiateLevel2();
        }
        else
        {
            wrongAnswer.Play(0);
        }
    }

    public void clickQueen(GameObject square)
    {
        objectClicked = square;
        piece = "queen";
    }

    public void clickPawn(GameObject square)
    {
        objectClicked = square;
        piece = "pawn";
    }

    public void clickTower(GameObject square)
    {
        objectClicked = square;
        piece = "tower";
    }

    public void clickBishop(GameObject square)
    {
        objectClicked = square;
        piece = "bishop";
    }

    public void clickKnight(GameObject square)
    {
        objectClicked = square;
        piece = "knight";
    }

    public void clickKing(GameObject square)
    {
        objectClicked = square;
        piece = "king";
    }

    public void clickSquare(GameObject square)
    {
        objectClicked.transform.position = square.transform.position;
        checkAnswer(square.transform.position);
    }

    private int randomNumber()
    {
        Random rnd = new Random();
        return rnd.Next(1, 7);
    }

    public void back2levels()
    {
        king.SetActive(false);
        knight.SetActive(false);
        queen.SetActive(false);
        bishop.SetActive(false);
        tower.SetActive(false);
        pawn.SetActive(false);
        levels.SetActive(true);
        board.SetActive(false);
        back2scenesButton.SetActive(true);
        back2levelsButton.SetActive(false);
    }

    public void initiateLevel2()
    {
        back2scenesButton.SetActive(false);
        back2levelsButton.SetActive(true);
        levels.SetActive(false);
        board.SetActive(true);
        switch (randomNumber())
        {
            case 1:
                king.SetActive(true);
                king.transform.position = new Vector3(0.0f, 0.0f, 8.0f);
                break;
            case 2:
                knight.SetActive(true);
                knight.transform.position = new Vector3(0.0f, 0.0f, 8.0f);
                break;
            case 3:
                queen.SetActive(true);
                queen.transform.position = new Vector3(0.0f, 0.0f, 8.0f);
                break;
            case 4:
                tower.SetActive(true);
                tower.transform.position = new Vector3(0.0f, 0.0f, 8.0f);
                break;
            case 5:
                pawn.SetActive(true);
                pawn.transform.position = new Vector3(0.0f, 0.0f, 8.0f);
                break;
            case 6:
                bishop.SetActive(true);
                bishop.transform.position = new Vector3(0.0f, 0.0f, 8.0f);
                break;
        }
    }
}
