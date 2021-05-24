using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using Random = System.Random;

public class Level3Script : MonoBehaviour
{
    public GameObject buttonName;
    private int pieceNum = 0;
    public GameObject pieces;
    public GameObject backButtonLevels;
    public GameObject backButtonScene;
    public IdentificationManager manager;
    public AudioSource rightAnswer;
    public AudioSource wrongAnswer;
    private int aux;

    public void initiateLevel()
    {
        pieceNum = randomNumber();
        while (pieceNum == aux)
        {
            pieceNum = randomNumber();
        }
        switch (pieceNum)
        {
            case 1:
                buttonName.GetComponentInChildren<Text>().text = "Peão";
                break;
            case 2:
                buttonName.GetComponentInChildren<Text>().text = "Torre";
                break;
            case 3:
                buttonName.GetComponentInChildren<Text>().text = "Rei";
                break;
            case 4:
                buttonName.GetComponentInChildren<Text>().text = "Rainha";
                break;
            case 5:
                buttonName.GetComponentInChildren<Text>().text = "Cavalo";
                break;
            case 6:
                buttonName.GetComponentInChildren<Text>().text = "Bispo";
                break;
        }
        aux = pieceNum;
        activateNamesButtons();
    }

    public void verifyAnswer(int pieceNumber)
    {
        if (pieceNumber == pieceNum) // CORRECT
        {
            rightAnswer.Play(0);
            initiateLevel();
        }
        else // INCORRECT
        {
            wrongAnswer.Play(0);
        }
    }

    private int randomNumber()
    {
        Random rnd = new Random();
        return rnd.Next(1, 7);
    }

    public void activateNamesButtons()
    {
        buttonName.SetActive(true);
        backButtonLevels.SetActive(true);
        pieces.SetActive(true);
    }

    public void deactivateNamesButtons()
    {
        buttonName.SetActive(false);
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
        pieces.SetActive(false);
    }
}
