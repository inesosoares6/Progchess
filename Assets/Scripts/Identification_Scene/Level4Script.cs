using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class Level4Script : MonoBehaviour
{
    public GameObject pieces;
    public GameObject names;
    public AudioSource rightAnswer;
    public AudioSource wrongAnswer;
    private int piece;
    private int button;
    public GameObject Pawn;
    public GameObject Tower;
    public GameObject Knight;
    public GameObject King;
    public GameObject Queen;
    public GameObject Bishop;
    public GameObject PawnButton;
    public GameObject TowerButton;
    public GameObject KnightButton;
    public GameObject KingButton;
    public GameObject QueenButton;
    public GameObject BishopButton;
    public LineRenderer lineRenderer1;
    public LineRenderer lineRenderer2;
    public LineRenderer lineRenderer3;
    public LineRenderer lineRenderer4;
    public LineRenderer lineRenderer5;
    public LineRenderer lineRenderer6;
    public GameObject backButtonLevels;
    public GameObject backButtonScene;
    public IdentificationManager manager;
    private Vector3 positionPiece1;
    private Vector3 positionPiece2;
    private Vector3 positionPiece3;
    private Vector3 positionPiece4;
    private Vector3 positionPiece5;
    private Vector3 positionPiece6;
    private int pieceNum = 0;
    private int[] aux = new int[6] { 0, 0, 0, 0, 0, 0};
    private int corrects = 0;
    private int aux_pos = 0;

    private void Start()
    {
        positionPiece1 = Pawn.transform.position;
        positionPiece2 = King.transform.position;
        positionPiece3 = Queen.transform.position;
        positionPiece4 = Knight.transform.position;
        positionPiece5 = Tower.transform.position;
        positionPiece6 = Bishop.transform.position;
    }

    public void initiateLevel()
    {
        pieces.SetActive(true);
        names.SetActive(true);
        backButtonLevels.SetActive(true);
    }

    private void reorderPieces()
    {
        placePiece(Pawn);
        placePiece(Tower);
        placePiece(Knight);
        placePiece(King);
        placePiece(Queen);
        placePiece(Bishop);
        aux = new int[6] { 0, 0, 0, 0, 0, 0 };
        corrects = 0;
        aux_pos = 0;
    }

    private void placePiece(GameObject piece)
    {
        switch (GenerateRandom())
        {
            case 1:
                piece.transform.position = positionPiece1;
                break;
            case 2:
                piece.transform.position = positionPiece2;
                break;
            case 3:
                piece.transform.position = positionPiece3;
                break;
            case 4:
                piece.transform.position = positionPiece4;
                break;
            case 5:
                piece.transform.position = positionPiece5;
                break;
            case 6:
                piece.transform.position = positionPiece6;
                break;
        }
    }

    private int GenerateRandom()
    {
        pieceNum = randomNumber();
        while (checkRepeated(pieceNum))
        {
            pieceNum = randomNumber();
        }
        return pieceNum;
    }

    private bool checkRepeated(int num)
    {
        for(int i=0; i < aux.Length; i++)
        {
            if(num == aux[i])
            {
                return true;
            }
        }
        aux[aux_pos] = num;
        aux_pos++;
        return false;
    }

    private int randomNumber()
    {
        Random rnd = new Random();
        return rnd.Next(1, 7);
    }

    public void giveName(int buttonName)
    {
        button = buttonName;
        if(piece != 0)
        {
            verifyMatch();
        }
    }

    public void givePiece(int pieceNum)
    {
        piece = pieceNum;
        if (button != 0)
        {
            verifyMatch();
        }
    }

    private void verifyMatch()
    {
        if(piece == button) // CORRECT
        {
            rightAnswer.Play(0);
            choosePiece(piece);
            corrects++;
            if(corrects == 6)
            {
                reorderPieces();
                deleteLines();
                corrects = 0;
            }
        }
        else // INCORRECT
        {
            wrongAnswer.Play(0);
        }
        piece = 0;
        button = 0;
    }

    private void choosePiece(int num)
    {
        switch (num)
        {
            case 1:
                insertLine(lineRenderer1, Pawn.transform.position, PawnButton.transform.position);
                break;
            case 2:
                insertLine(lineRenderer2, Tower.transform.position, TowerButton.transform.position);
                break;
            case 3:
                insertLine(lineRenderer3, King.transform.position, KingButton.transform.position);
                break;
            case 4:
                insertLine(lineRenderer4, Queen.transform.position, QueenButton.transform.position);
                break;
            case 5:
                insertLine(lineRenderer5, Knight.transform.position, KnightButton.transform.position);
                break;
            case 6:
                insertLine(lineRenderer6, Bishop.transform.position, BishopButton.transform.position);
                break;
        }
    }

    private void insertLine(LineRenderer lineRenderer, Vector3 start, Vector3 finish)
    {
        lineRenderer.startWidth = 0.1f;
        lineRenderer.endWidth = 0.1f;
        lineRenderer.positionCount=2;
        lineRenderer.SetPosition(0, start);
        lineRenderer.SetPosition(1, finish);
    }

    private void deactivateNamesButtons()
    {
        pieces.SetActive(false);
        names.SetActive(false);
    }

    private void deleteLines()
    {
        lineRenderer1.positionCount = 0;
        lineRenderer2.positionCount = 0;
        lineRenderer3.positionCount = 0;
        lineRenderer4.positionCount = 0;
        lineRenderer5.positionCount = 0;
        lineRenderer6.positionCount = 0;
    }

    public void back2Levels()
    {
        deactivateNamesButtons();
        manager.activateLevelButtons();
        backButtonScene.SetActive(true);
        deleteLines();
    }
}
