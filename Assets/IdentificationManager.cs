using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdentificationManager : MonoBehaviour
{
    public GameObject buttonsLevels;
    public GameObject buttonsPieces;
    public GameObject Pawn;
    public GameObject Tower;
    public GameObject Knight;
    public GameObject King;
    public GameObject Queen;
    public GameObject Bishop;
    public GameObject Board;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Level(int gameLevel)
    {
        Debug.Log("Level "+ gameLevel);
        deactivateLevelButtons();
        switch (gameLevel)
        {
            case 1:
                activatePiecesButtons();
                break;
            case 2:

                break;
            case 3:

                break;
            case 4:

                break;
        }
    }

    public void Piece(string piece)
    {
        switch (piece)
        {
            case "Pawn":
                initiateGame(Pawn);
                break;
            case "Tower":
                initiateGame(Tower);
                break;
            case "Knight":
                initiateGame(Knight);
                break;
            case "King":
                initiateGame(King);
                break;
            case "Queen":
                initiateGame(Queen);
                break;
            case "Bishop":
                initiateGame(Bishop);
                break;
        }
    }

    private void initiateGame(GameObject piece)
    {
        deactivatePiecesButtons();
        piece.SetActive(true);
    }

    private void deactivateLevelButtons()
    {
        buttonsLevels.SetActive(false);
    }

    private void activatePiecesButtons()
    {
        buttonsPieces.SetActive(true);
    }

    private void deactivatePiecesButtons()
    {
        buttonsPieces.SetActive(false);
    }

}
