using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BoardSetupLevel3 : MonoBehaviour
{
    public GameObject pieces;
    public GameObject levels;
    public GameObject king;
    public GameObject knight1;
    public GameObject knight2;
    public GameObject pawn1;
    public GameObject pawn2;
    public GameObject pawn3;
    public GameObject pawn4;
    public GameObject pawn5;
    public GameObject pawn6;
    public GameObject pawn7;
    public GameObject pawn8;
    public GameObject tower1;
    public GameObject tower2;
    public GameObject queen;
    public GameObject bishop1;
    public GameObject bishop2;
    public GameObject restartButton;
    private GameObject objectClicked;
    public AudioSource rightAnswer;
    public AudioSource wrongAnswer;
    private string piece;
    public GameObject back2scenesButton;
    public GameObject back2levelsButton;

    public void checkAnswer(Vector3 position)
    {
        if(piece == "pawn" && Math.Abs(position.z) == 3.125)
        {
            rightAnswer.Play(0);
        }
        else if (piece == "queen" && (position.x == 0.625 && Math.Abs(position.z) == 4.375))
        {
            rightAnswer.Play(0);
        }
        else if (piece == "king" && (position.x == -0.625 && Math.Abs(position.z) == 4.375))
        {
            rightAnswer.Play(0);
        }
        else if (piece == "knight" && (Math.Abs(position.x) == 3.125 && Math.Abs(position.z) == 4.375))
        {
            rightAnswer.Play(0);
        }
        else if (piece == "tower" && (Math.Abs(position.x) == 4.375 && Math.Abs(position.z) == 4.375))
        {
            rightAnswer.Play(0);
        }
        else if (piece == "bishop" && (Math.Abs(position.x) == 1.875 && Math.Abs(position.z) == 4.375))
        {
            rightAnswer.Play(0);
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

    public void resetPieces()
    {
        king.transform.position = new Vector3(-3.73f, 0.0f, 13.0f);
        knight1.transform.position = new Vector3(-2.03f, 0.0f, 13.0f);
        knight2.transform.position = new Vector3(-2.03f, 0.0f, 13.0f);
        pawn1.transform.position = new Vector3(4.22f, 0.0f, 13.0f);
        pawn2.transform.position = new Vector3(4.22f, 0.0f, 13.0f);
        pawn3.transform.position = new Vector3(4.22f, 0.0f, 13.0f);
        pawn4.transform.position = new Vector3(4.22f, 0.0f, 13.0f);
        pawn5.transform.position = new Vector3(4.22f, 0.0f, 13.0f);
        pawn6.transform.position = new Vector3(4.22f, 0.0f, 13.0f);
        pawn7.transform.position = new Vector3(4.22f, 0.0f, 13.0f);
        pawn8.transform.position = new Vector3(4.22f, 0.0f, 13.0f);
        tower1.transform.position = new Vector3(-0.35f, 0.0f, 13.0f);
        tower2.transform.position = new Vector3(-0.35f, 0.0f, 13.0f);
        queen.transform.position = new Vector3(1.28f, 0.0f, 13.0f);
        bishop1.transform.position = new Vector3(2.9f, 0.0f, 13.0f);
        bishop2.transform.position = new Vector3(2.9f, 0.0f, 13.0f);
    }

    public void showPieces()
    {
        pieces.SetActive(true);
        levels.SetActive(false);
        restartButton.SetActive(true);
        back2scenesButton.SetActive(false);
        back2levelsButton.SetActive(true);
    }

    public void back2levels()
    {
        pieces.SetActive(false);
        levels.SetActive(true);
        restartButton.SetActive(false);
        back2scenesButton.SetActive(true);
        back2levelsButton.SetActive(false);
    }
}
