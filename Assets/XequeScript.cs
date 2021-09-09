using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class XequeScript : MonoBehaviour
{
    public GameObject tower_white;
    public GameObject tower_black;
    public GameObject king_black;
    public GameObject king_white;
    public GameObject queen_white;
    public GameObject queen_black;
    public GameObject knight_black;
    public GameObject knight_white;
    public GameObject bishop_white;
    public GameObject bishop_black;
    public GameObject pawn1_black;
    public GameObject pawn2_black;
    public GameObject pawn3_black;
    public GameObject pawn4_black;
    public GameObject pawn1_white;
    public GameObject pawn2_white;
    private int level;
    public GameObject buttonLevels;
    public GameObject back2pieces;
    public GameObject back2scenes;
    public GameObject buttonPieces;
    public AudioSource rightAnswer;
    public AudioSource levelUp;
    private int count_squares = 0;
    Dictionary<string, GameObject> squares = new Dictionary<string, GameObject>();
    private bool squares_introduced = false;
    private GameObject objectXeque;

    private void Start()
    {
        introduce24squares();
        count_squares = 0;
    }

    public void defineLevel_xeque(int num)
    {
        level = num;
        beginXeque();
        moveTarget_xeque(level);
    }

    private void moveTarget_xeque(int levelNum)
    {
        switch (levelNum)
        {
            case 1: // LEVEL I
                king_black.SetActive(true);
                tower_white.SetActive(true);
                king_black.transform.position = new Vector3(0.625f, 0.0f, 4.375f);
                tower_white.transform.position = new Vector3(-4.375f, 0.0f, -4.375f);
                break;
            case 2: // LEVEL II
                king_black.SetActive(true);
                knight_black.SetActive(true);
                queen_white.SetActive(true);
                king_black.transform.position = new Vector3(0.625f, 0.0f, 1.875f);
                knight_black.transform.position = new Vector3(-0.625f, 0.0f, -0.625f);
                queen_white.transform.position = new Vector3(-3.125f, 0.0f, -1.875f);
                break;
            case 3: // LEVEL III
                king_black.SetActive(true);
                bishop_white.SetActive(true);
                tower_black.SetActive(true);
                queen_black.SetActive(true);
                pawn1_black.SetActive(true);
                pawn2_black.SetActive(true);
                pawn3_black.SetActive(true);
                pawn4_black.SetActive(true);
                king_black.transform.position = new Vector3(0.625f, 0.0f, 4.375f);
                bishop_white.transform.position = new Vector3(-0.625f, 0.0f, -1.875f);
                tower_black.transform.position = new Vector3(3.125f, 0.0f, -3.125f);
                queen_black.transform.position = new Vector3(-0.625f, 0.0f, 4.375f);
                pawn1_black.transform.position = new Vector3(0.625f, 0.0f, 0.625f);
                pawn2_black.transform.position = new Vector3(-0.625f, 0.0f, 1.875f);
                pawn3_black.transform.position = new Vector3(-1.875f, 0.0f, 3.125f);
                pawn4_black.transform.position = new Vector3(-3.125f, 0.0f, 3.125f);
                break;
            case 4: // LEVEL IV
                king_black.SetActive(true);
                queen_black.SetActive(true);
                knight_white.SetActive(true);
                pawn1_white.SetActive(true);
                pawn2_white.SetActive(true);
                bishop_white.SetActive(true);
                king_black.transform.position = new Vector3(0.625f, 0.0f, 0.625f);
                queen_black.transform.position = new Vector3(3.125f, 0.0f, 4.375f);
                knight_white.transform.position = new Vector3(-1.875f, 0.0f, -1.875f);
                pawn1_white.transform.position = new Vector3(-0.625f, 0.0f, -3.125f);
                pawn2_white.transform.position = new Vector3(0.625f, 0.0f, -1.875f);
                bishop_white.transform.position = new Vector3(3.125f, 0.0f, -3.125f);
                break;
            case 5: // LEVEL V
                king_black.SetActive(true);
                queen_black.SetActive(true);
                knight_black.SetActive(true);
                knight_white.SetActive(true);
                pawn1_black.SetActive(true);
                pawn2_black.SetActive(true);
                bishop_black.SetActive(true);
                king_black.transform.position = new Vector3(-0.625f, 0.0f, 1.875f);
                queen_black.transform.position = new Vector3(0.625f, 0.0f, 3.125f);
                knight_black.transform.position = new Vector3(4.375f, 0.0f, 3.125f);
                knight_white.transform.position = new Vector3(-1.875f, 0.0f, 0.625f);
                pawn1_black.transform.position = new Vector3(-1.875f, 0.0f, 1.875f);
                pawn2_black.transform.position = new Vector3(-3.125f, 0.0f, 1.875f);
                bishop_black.transform.position = new Vector3(-1.875f, 0.0f, 3.125f);
                break;
            case 6: // LEVEL VI
                king_black.SetActive(true);
                knight_black.SetActive(true);
                tower_black.SetActive(true);
                tower_white.SetActive(true);
                queen_white.SetActive(true);
                king_black.transform.position = new Vector3(-3.125f, 0.0f, 3.125f);
                knight_black.transform.position = new Vector3(-1.875f, 0.0f, -1.875f);
                tower_black.transform.position = new Vector3(1.875f, 0.0f, 3.125f);
                tower_white.transform.position = new Vector3(3.125f, 0.0f, 4.375f);
                queen_white.transform.position = new Vector3(0.625f, 0.0f, 0.625f);
                break;
            case 7: // LEVEL VII
                king_black.SetActive(true);
                knight_black.SetActive(true);
                knight_white.SetActive(true);
                tower_black.SetActive(true);
                king_white.SetActive(true);
                tower_white.SetActive(true);
                king_black.transform.position = new Vector3(0.625f, 0.0f, 4.375f);
                knight_black.transform.position = new Vector3(-0.625f, 0.0f, 0.625f);
                knight_white.transform.position = new Vector3(0.625f, 0.0f, -0.625f);
                tower_black.transform.position = new Vector3(4.375f, 0.0f, 4.375f);
                king_white.transform.position = new Vector3(0.625f, 0.0f, -4.375f);
                tower_white.transform.position = new Vector3(-1.875f, 0.0f, -3.125f);
                break;
        }
    }

    private void checkTarget_xeque()
    {
        if(level==1 && tower_white.transform.position.x == king_black.transform.position.x && tower_white.transform.position.z == king_black.transform.position.z - 1.25f)
        {
            tower_white.SetActive(false);
            king_black.SetActive(false);
            levelUp.Play(0);
            showLevels_xeque();
        }
        else if (level == 2 && queen_white.transform.position.x == king_black.transform.position.x + 1.25f && queen_white.transform.position.z == king_black.transform.position.z - 1.25f)
        {
            queen_white.SetActive(false);
            knight_black.SetActive(false);
            king_black.SetActive(false);
            levelUp.Play(0);
            showLevels_xeque();
        }
        else if(level == 3 && bishop_white.transform.position.x == king_black.transform.position.x - 1.25f && bishop_white.transform.position.z == king_black.transform.position.z - 1.25f)
        {
            king_black.SetActive(false);
            bishop_white.SetActive(false);
            tower_black.SetActive(false);
            queen_black.SetActive(false);
            pawn1_black.SetActive(false);
            pawn2_black.SetActive(false);
            pawn3_black.SetActive(false);
            pawn4_black.SetActive(false);
            levelUp.Play(0);
            showLevels_xeque();
        }
        else if(level == 4 && pawn1_white.transform.position.x == king_black.transform.position.x - 1.25f && pawn1_white.transform.position.z == king_black.transform.position.z - 1.25f)
        {
            king_black.SetActive(false);
            queen_black.SetActive(false);
            knight_white.SetActive(false);
            pawn1_white.SetActive(false);
            pawn2_white.SetActive(false);
            bishop_white.SetActive(false);
            levelUp.Play(0);
            showLevels_xeque();
        }
        else if(level == 5 )
        {
            //TODO
        }
        else if(level == 6 && tower_white.transform.position.x == king_black.transform.position.x && tower_white.transform.position.z == king_black.transform.position.z + 1.25f || queen_white.transform.position.x == king_black.transform.position.x && queen_white.transform.position.z == king_black.transform.position.z + 1.25f)
        {
            king_black.SetActive(false);
            knight_black.SetActive(false);
            tower_black.SetActive(false);
            tower_white.SetActive(false);
            queen_white.SetActive(false);
            levelUp.Play(0);
            showLevels_xeque();
        }
        else if(level == 7)
        {
            //TODO
        }

    }

    public void clicked_xeque(GameObject object_clicked)
    {
        objectXeque = object_clicked;
        if(level==1 && object_clicked == tower_white)
        {
            count_squares = 0;
            verifyPossibilities_tower(tower_white, tower_white.transform.position.x, 1);
            verifyPossibilities_tower(tower_white, tower_white.transform.position.z, 2);
            count_squares = 0;
        }
        else if(level==2 && object_clicked == queen_white)
        {
            count_squares = 0;
            verifyPossibilities_bishop(queen_white);
            verifyPossibilities_tower(queen_white, queen_white.transform.position.x, 1);
            verifyPossibilities_tower(queen_white, queen_white.transform.position.z, 2);
            count_squares = 0;
        }
        else if(level==3 && object_clicked == bishop_white)
        {
            count_squares = 0;
            verifyPossibilities_bishop(bishop_white);
            count_squares = 0;
        }
        else if(level==4 && object_clicked == pawn1_white)
        {
            count_squares = 0;
            verifyPossibilities_pawn(pawn1_white);
            count_squares = 0;
        }
        else if (level == 5)
        {
            //TODO
        }
        else if(level == 6 && object_clicked == tower_white)
        {
            count_squares = 0;
            verifyPossibilities_tower(tower_white, tower_white.transform.position.x, 1);
            verifyPossibilities_tower(tower_white, tower_white.transform.position.z, 2);
            count_squares = 0;
        }
        else if(level==6 && object_clicked == queen_white)
        {
            count_squares = 0;
            verifyPossibilities_bishop(queen_white);
            verifyPossibilities_tower(queen_white, queen_white.transform.position.x, 1);
            verifyPossibilities_tower(queen_white, queen_white.transform.position.z, 2);
            count_squares = 0;
        }
        else if(level == 7)
        {
            //TODO
        }
    }

    private void verifyPossibilities_pawn(GameObject pawnNum)
    {
        showDirections_pawn(pawnNum.transform.position.x, pawnNum.transform.position.z + 1.25f);
    }

    private void verifyPossibilities_bishop(GameObject bishopNum)
    {
        float i = bishopNum.transform.position.x;
        float j = bishopNum.transform.position.z;
        while (i < 4.375f && j < 4.375f)
        {
            i = i + 1.25f;
            j = j + 1.25f;
            showDirections_bishop(i, j);
        }

        i = bishopNum.transform.position.x;
        j = bishopNum.transform.position.z;
        while (i > -4.375f && j < 4.375f)
        {
            i = i - 1.25f;
            j = j + 1.25f;
            showDirections_bishop(i, j);
        }

        i = bishopNum.transform.position.x;
        j = bishopNum.transform.position.z;
        while (i < 4.375f && j > -4.375f)
        {
            i = i + 1.25f;
            j = j - 1.25f;
            showDirections_bishop(i, j);
        }

        i = bishopNum.transform.position.x;
        j = bishopNum.transform.position.z;
        while (i > -4.375f && j > -4.375f)
        {
            i = i - 1.25f;
            j = j - 1.25f;
            showDirections_bishop(i, j);
        }
    }

    private void verifyPossibilities_tower(GameObject towerNum, float positionAxis, int axis)
    {
        float i = -4.375f;
        while (i < 4.4)
        {
            if (positionAxis != i)
            {
                showDirections_tower(towerNum, axis, i);
            }
            i = i + 1.25f;
        }
    }

    private void showDirections_pawn(float axisX, float axisZ)
    {
        count_squares++;
        squares["square" + count_squares].SetActive(true);
        squares["square" + count_squares].transform.position = new Vector3(axisX, 0.0101f, axisZ);
    }

    private void showDirections_bishop(float axisX, float axisZ)
    {
        count_squares++;
        squares["square" + count_squares].SetActive(true);
        squares["square" + count_squares].transform.position = new Vector3(axisX, 0.0101f, axisZ);
    }

    private void showDirections_tower(GameObject towerNum, int axis, float pos)
    {
        count_squares++;
        squares["square" + count_squares].SetActive(true);
        if (axis == 1)
        {
            squares["square" + count_squares].transform.position = new Vector3(pos, 0.0101f, towerNum.transform.position.z);
        }
        else if (axis == 2)
        {
            squares["square" + count_squares].transform.position = new Vector3(towerNum.transform.position.x, 0.0101f, pos);
        }
    }

    private GameObject createSquare()
    {
        GameObject square_aux;
        square_aux = GameObject.CreatePrimitive(PrimitiveType.Plane);
        square_aux.GetComponent<Renderer>().material.color = Color.yellow;
        square_aux.AddComponent<BoxCollider>().enabled = true;
        square_aux.AddComponent<ChangeColor>().enabled = true;
        square_aux.AddComponent<EventTrigger>().enabled = true;

        EventTrigger trigger = square_aux.GetComponent<EventTrigger>();
        EventTrigger.Entry entry_click = new EventTrigger.Entry();
        entry_click.eventID = EventTriggerType.PointerClick;
        entry_click.callback.AddListener((data) => {
            square_aux.GetComponent<ChangeColor>().Yellow();
            Move_xeque(square_aux);
        });
        trigger.triggers.Add(entry_click);

        EventTrigger.Entry entry_enter = new EventTrigger.Entry();
        entry_enter.eventID = EventTriggerType.PointerEnter;
        entry_enter.callback.AddListener((data) => {
            square_aux.GetComponent<ChangeColor>().Green();
        });
        trigger.triggers.Add(entry_enter);

        EventTrigger.Entry entry_exit = new EventTrigger.Entry();
        entry_exit.eventID = EventTriggerType.PointerExit;
        entry_exit.callback.AddListener((data) => {
            square_aux.GetComponent<ChangeColor>().Yellow();
        });
        trigger.triggers.Add(entry_exit);

        square_aux.transform.localScale = new Vector3(0.125f, 0.125f, 0.125f);

        return square_aux;
    }

    private void introduce24squares()
    {
        while (count_squares < 24)
        {
            count_squares++;
            squares.Add("square" + count_squares, createSquare());
            squares["square" + count_squares].SetActive(false);
        }
        squares_introduced = true;
    }

    public void Move_xeque(GameObject object_clicked)
    {
        objectXeque.transform.position = object_clicked.transform.position;
        DeleteSquares_xeque();
        checkTarget_xeque();
    }

    private void DeleteSquares_xeque()
    {
        for (int j = 1; j < 25; j++)
        {
            squares["square" + j].SetActive(false);
        }
    }

    public void showLevels_xeque()
    {
        buttonLevels.SetActive(true);
        buttonPieces.SetActive(false);
        back2scenes.SetActive(false);
        back2pieces.SetActive(true);
        if (squares_introduced)
        {
            DeleteSquares_xeque();
        }
    }

    public void beginXeque()
    {
        buttonLevels.SetActive(false);
        back2pieces.SetActive(false);
    }
}
