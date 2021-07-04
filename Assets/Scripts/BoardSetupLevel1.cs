using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class BoardSetupLevel1 : MonoBehaviour
{
    private int count=0;
    public float speed;
    public GameObject cameraRig;
    public GameObject Pawn;
    public GameObject Tower;
    public GameObject Knight;
    public GameObject King;
    public GameObject Queen;
    public GameObject Bishop;
    private GameObject chosenPiece;
    public GameObject backButtonLevels;
    public GameObject backButtonScene;
    public GameObject levels;
    public GameObject manager;
    private int aux = 0;
    private int num_random = 0;

    // Update is called once per frame
    void Update()
    {
        switch (count)
        {
            case 0:
                generatePiece();
                break;
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
                chosenPiece.SetActive(false);
                count = 0;
                break;
        }
    }

    public void generatePiece()
    {
        num_random = randomNumber();
        while (num_random == aux)
        {
            num_random = randomNumber();
        }
        aux = num_random;
        switch (num_random)
        {
            case 1:
                chosenPiece = Pawn;
                break;
            case 2:
                chosenPiece = Tower;
                break;
            case 3:
                chosenPiece = Knight;
                break;
            case 4:
                chosenPiece = King;
                break;
            case 5:
                chosenPiece = Queen;
                break;
            case 6:
                chosenPiece = Bishop;
                break;
        }
        count++;
        chosenPiece.SetActive(true);
        chosenPiece.transform.localRotation = new Quaternion(-0.7f, 0.0f, 0.0f, 0.7f);
        backButtonLevels.SetActive(true);
    }

    private int randomNumber()
    {
        Random rnd = new Random();
        return rnd.Next(1, 7);
    }

    public void back2Levels()
    {
        count = 0;
        chosenPiece.SetActive(false);
        levels.SetActive(true);
        backButtonScene.SetActive(true);
        backButtonLevels.SetActive(false);
        manager.GetComponent<BoardSetupLevel1>().enabled = false;
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

    public void initiatelevel1()
    {
        backButtonScene.SetActive(false);
        backButtonLevels.SetActive(true);
        levels.SetActive(false);
        generatePiece();
    }
}
