using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BoardSetupLevel4 : MonoBehaviour
{
    public GameObject pieces;
    public GameObject levels;
    public GameObject b_king;
    public GameObject b_knight1;
    public GameObject b_knight2;
    public GameObject b_pawn1;
    public GameObject b_pawn2;
    public GameObject b_pawn3;
    public GameObject b_pawn4;
    public GameObject b_pawn5;
    public GameObject b_pawn6;
    public GameObject b_pawn7;
    public GameObject b_pawn8;
    public GameObject b_tower1;
    public GameObject b_tower2;
    public GameObject b_queen;
    public GameObject b_bishop1;
    public GameObject b_bishop2;
    public GameObject w_king;
    public GameObject w_knight1;
    public GameObject w_knight2;
    public GameObject w_pawn1;
    public GameObject w_pawn2;
    public GameObject w_pawn3;
    public GameObject w_pawn4;
    public GameObject w_pawn5;
    public GameObject w_pawn6;
    public GameObject w_pawn7;
    public GameObject w_pawn8;
    public GameObject w_tower1;
    public GameObject w_tower2;
    public GameObject w_queen;
    public GameObject w_bishop1;
    public GameObject w_bishop2;
    public GameObject restartButton;
    private GameObject objectClicked;
    public AudioSource rightAnswer;
    public AudioSource wrongAnswer;
    private string piece;
    private string material;
    public GameObject back2scenesButton;
    public GameObject back2levelsButton;
    public Material blackPieces;
    public Material whitePieces;

    public void checkAnswer_white(Vector3 position)
    {
        if (piece == "pawn" && position.z == -3.125)
        {
            rightAnswer.Play(0);
        }
        else if (piece == "queen" && (position.x == 0.625 && position.z == -4.375))
        {
            rightAnswer.Play(0);
        }
        else if (piece == "king" && (position.x == -0.625 && position.z == -4.375))
        {
            rightAnswer.Play(0);
        }
        else if (piece == "knight" && (Math.Abs(position.x) == 3.125 && position.z == -4.375))
        {
            rightAnswer.Play(0);
        }
        else if (piece == "tower" && (Math.Abs(position.x) == 4.375 && position.z == -4.375))
        {
            rightAnswer.Play(0);
        }
        else if (piece == "bishop" && (Math.Abs(position.x) == 1.875 && position.z == -4.375))
        {
            rightAnswer.Play(0);
        }
        else
        {
            wrongAnswer.Play(0);
        }
    }

    public void checkAnswer_black(Vector3 position)
    {
        if (piece == "pawn" && position.z == 3.125)
        {
            rightAnswer.Play(0);
        }
        else if (piece == "queen" && (position.x == 0.625 && position.z == 4.375))
        {
            rightAnswer.Play(0);
        }
        else if (piece == "king" && (position.x == -0.625 && position.z == 4.375))
        {
            rightAnswer.Play(0);
        }
        else if (piece == "knight" && (Math.Abs(position.x) == 3.125 && position.z == 4.375))
        {
            rightAnswer.Play(0);
        }
        else if (piece == "tower" && (Math.Abs(position.x) == 4.375 && position.z == 4.375))
        {
            rightAnswer.Play(0);
        }
        else if (piece == "bishop" && (Math.Abs(position.x) == 1.875 && position.z == 4.375))
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
        if(square.GetComponent<Material>() == blackPieces)
        {
            material = "black";
        }
        else if(square.GetComponent<Material>() == whitePieces)
        {
            material = "white";
        }
    }

    public void clickPawn(GameObject square)
    {
        objectClicked = square;
        piece = "pawn";
        if (square.GetComponent<Material>() == blackPieces)
        {
            material = "black";
        }
        else if (square.GetComponent<Material>() == whitePieces)
        {
            material = "white";
        }
    }

    public void clickTower(GameObject square)
    {
        objectClicked = square;
        piece = "tower";
        if (square.GetComponent<Material>() == blackPieces)
        {
            material = "black";
        }
        else if (square.GetComponent<Material>() == whitePieces)
        {
            material = "white";
        }
    }

    public void clickBishop(GameObject square)
    {
        objectClicked = square;
        piece = "bishop";
        if (square.GetComponent<Material>() == blackPieces)
        {
            material = "black";
        }
        else if (square.GetComponent<Material>() == whitePieces)
        {
            material = "white";
        }
    }

    public void clickKnight(GameObject square)
    {
        objectClicked = square;
        piece = "knight";
        if (square.GetComponent<Material>() == blackPieces)
        {
            material = "black";
        }
        else if (square.GetComponent<Material>() == whitePieces)
        {
            material = "white";
        }
    }

    public void clickKing(GameObject square)
    {
        objectClicked = square;
        piece = "king";
        if (square.GetComponent<Material>() == blackPieces)
        {
            material = "black";
            Debug.Log("Black Piece");
        }
        else if (square.GetComponent<Material>() == whitePieces)
        {
            material = "white";
            Debug.Log("White Piece");
        }
    }

    public void clickSquare(GameObject square)
    {
        objectClicked.transform.position = square.transform.position;
        if(material == "black")
        {
            checkAnswer_black(square.transform.position);
        }
        else if(material == "white")
        {
            checkAnswer_white(square.transform.position);
        }
    }

    public void resetPieces()
    {
        b_king.transform.position = new    Vector3(-4.97f, 6.0f, 5.0f);
        b_knight1.transform.position = new Vector3(-2.74f, 6.0f, 5.0f);
        b_knight2.transform.position = new Vector3(-2.74f, 6.0f, 5.0f);
        b_pawn1.transform.position = new   Vector3(4.94f,  6.0f, 5.0f);
        b_pawn2.transform.position = new   Vector3(4.94f,  6.0f, 5.0f);
        b_pawn3.transform.position = new   Vector3(4.94f,  6.0f, 5.0f);
        b_pawn4.transform.position = new   Vector3(4.94f,  6.0f, 5.0f);
        b_pawn5.transform.position = new   Vector3(4.94f,  6.0f, 5.0f);
        b_pawn6.transform.position = new   Vector3(4.94f,  6.0f, 5.0f);
        b_pawn7.transform.position = new   Vector3(4.94f,  6.0f, 5.0f);
        b_pawn8.transform.position = new   Vector3(4.94f,  6.0f, 5.0f);
        b_tower1.transform.position = new  Vector3(-0.71f, 6.0f, 5.0f);
        b_tower2.transform.position = new  Vector3(-0.71f, 6.0f, 5.0f);
        b_queen.transform.position = new   Vector3(1.28f,  6.0f, 5.0f);
        b_bishop1.transform.position = new Vector3(3.15f,  6.0f, 5.0f);
        b_bishop2.transform.position = new Vector3(3.15f,  6.0f, 5.0f);

        w_king.transform.position =    new Vector3(-4.97f, 3.0f, 5.0f);
        w_knight1.transform.position = new Vector3(-2.74f, 3.0f, 5.0f);
        w_knight2.transform.position = new Vector3(-2.74f, 3.0f, 5.0f);
        w_pawn1.transform.position =   new Vector3(4.94f,  3.0f, 5.0f);
        w_pawn2.transform.position =   new Vector3(4.94f,  3.0f, 5.0f);
        w_pawn3.transform.position =   new Vector3(4.94f,  3.0f, 5.0f);
        w_pawn4.transform.position =   new Vector3(4.94f,  3.0f, 5.0f);
        w_pawn5.transform.position =   new Vector3(4.94f,  3.0f, 5.0f);
        w_pawn6.transform.position =   new Vector3(4.94f,  3.0f, 5.0f);
        w_pawn7.transform.position =   new Vector3(4.94f,  3.0f, 5.0f);
        w_pawn8.transform.position =   new Vector3(4.94f,  3.0f, 5.0f);
        w_tower1.transform.position =  new Vector3(-0.71f, 3.0f, 5.0f);
        w_tower2.transform.position =  new Vector3(-0.71f, 3.0f, 5.0f);
        w_queen.transform.position =   new Vector3(1.28f,  3.0f, 5.0f);
        w_bishop1.transform.position = new Vector3(3.15f,  3.0f, 5.0f);
        w_bishop2.transform.position = new Vector3(3.15f,  3.0f, 5.0f);
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
