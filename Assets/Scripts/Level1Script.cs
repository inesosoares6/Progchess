using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Script : MonoBehaviour
{
    private int count;
    public float speed;
    public GameObject cameraRig;
    public GameObject buttonsPieces;
    public GameObject Pawn;
    public GameObject Tower;
    public GameObject Knight;
    public GameObject King;
    public GameObject Queen;
    public GameObject Bishop;
    private GameObject chosenPiece;
    public GameObject backButtonPieces;
    public GameObject backButtonLevels;
    public GameObject backButtonScene;
    public IdentificationManager manager;

    // Update is called once per frame
    void Update()
    {
        switch (count)
        {
            case 1:
                rotateZ();
                break;
            case 2:
                rotateX();
                break;
            case 3:
                rotateY();
                break;
            case 4:
                count = 1;
                break;
        }
    }

    public void Piece(string piece)
    {
        switch (piece)
        {
            case "Pawn":
                chosenPiece = Pawn;
                break;
            case "Tower":
                chosenPiece = Tower;
                break;
            case "Knight":
                chosenPiece = Knight;
                break;
            case "King":
                chosenPiece = King;
                break;
            case "Queen":
                chosenPiece = Queen;
                break;
            case "Bishop":
                chosenPiece = Bishop;
                break;
        }
        chosenPiece.SetActive(true);
        deactivatePiecesButtons();
        backButtonPieces.SetActive(true);
    }

    public void back2pieces()
    {
        chosenPiece.SetActive(false);
        activatePiecesButtons();
    }
    public void back2Levels()
    {
        deactivatePiecesButtons();
        manager.activateLevelButtons();
        backButtonScene.SetActive(true);
    }

    public void activatePiecesButtons()
    {
        count = 0;
        backButtonPieces.SetActive(false);
        buttonsPieces.SetActive(true);
        backButtonLevels.SetActive(true);
    }

    public void deactivatePiecesButtons()
    {
        buttonsPieces.SetActive(false);
        backButtonLevels.SetActive(false);
    }

    private void rotateX()
    {
        chosenPiece.transform.Rotate(speed * Time.deltaTime, 0, 0);
    }

    private void rotateY()
    {
        chosenPiece.transform.Rotate(0, speed * Time.deltaTime, 0);
    }

    private void rotateZ()
    {
        chosenPiece.transform.Rotate(0, 0, speed * Time.deltaTime);
    }

    public void clicked()
    {
        count++;
    }

}
