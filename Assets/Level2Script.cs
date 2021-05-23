using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class Level2Script : MonoBehaviour
{
    public GameObject buttonsNames;
    private int pieceNum = 0;
    public GameObject Pawn;
    public GameObject Tower;
    public GameObject Knight;
    public GameObject King;
    public GameObject Queen;
    public GameObject Bishop;
    public GameObject backButtonLevels;
    public GameObject backButtonScene;
    public IdentificationManager manager;

    public void initiateLevel()
    {
        erasePieces();
        pieceNum = randomNumber();
        switch (pieceNum)
        {
            case 1:
                Pawn.SetActive(true);
                break;
            case 2:
                Tower.SetActive(true);
                break;
            case 3:
                King.SetActive(true);
                break;
            case 4:
                Queen.SetActive(true);
                break;
            case 5:
                Knight.SetActive(true);
                break;
            case 6:
                Bishop.SetActive(true);
                break;
        }
        activateNamesButtons();
    }

    public void verifyAnswer(int pieceNumber)
    {
        if(pieceNumber == pieceNum) // CORRECT
        {
            initiateLevel();
        }
        else // INCORRECT
        {

        }
    }

    private int randomNumber()
    {
        Random rnd = new Random();
        return rnd.Next(1, 7);
    }

    public void activateNamesButtons()
    {
        buttonsNames.SetActive(true);
        backButtonLevels.SetActive(true);
    }

    public void deactivateNamesButtons()
    {
        buttonsNames.SetActive(false);
        backButtonLevels.SetActive(false);
    }

    public void back2Levels()
    {
        deactivateNamesButtons();
        manager.activateLevelButtons();
        backButtonScene.SetActive(true);
        erasePieces();
    }

    private void erasePieces()
    {
        Pawn.SetActive(false);
        Tower.SetActive(false);
        Knight.SetActive(false);
        Queen.SetActive(false);
        King.SetActive(false);
        Bishop.SetActive(false);
    }
}
