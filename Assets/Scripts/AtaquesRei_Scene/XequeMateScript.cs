using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.EventSystems;

public class XequeMateScript : MonoBehaviour
{
    private int level;
    public GameObject buttonLevels;
    public GameObject back2pieces;
    public GameObject back2scenes;
    public GameObject buttonPieces;
    public AudioSource levelUp;
    public GameObject king_black;
    public GameObject queen_black;
    public GameObject bishop_black1;
    public GameObject bishop_black2;
    public GameObject knight_black;
    public GameObject tower_black;
    public GameObject pawn_black1;
    public GameObject pawn_black2;
    public GameObject pawn_black3;
    public GameObject pawn_black4;
    public GameObject pawn_black5;
    public GameObject king_white;
    public GameObject queen_white;
    public GameObject bishop_white1;
    public GameObject bishop_white2;
    public GameObject knight_white1;
    public GameObject knight_white2;
    public GameObject tower_white1;
    public GameObject tower_white2;
    public GameObject pawn_white;

    private int count_squares = 0;
    Dictionary<string, GameObject> squares = new Dictionary<string, GameObject>();
    private bool squares_introduced = false;
    private GameObject objectXequeMate;

    private void Start()
    {
        introduce30squares();
        count_squares = 0;
    }

    public void defineLevel_xequeMate(int num)
    {
        level = num;
        beginXequeMate();
        moveTarget_xequeMate(level);
    }

    private void moveTarget_xequeMate(int levelNum)
    {
        switch (levelNum)
        {
            case 1: // LEVEL I
                king_black.SetActive(true);
                queen_black.SetActive(true);
                pawn_black1.SetActive(true);
                pawn_black2.SetActive(true);
                pawn_black3.SetActive(true);
                bishop_white1.SetActive(true);
                queen_white.SetActive(true);
                king_black.transform.position = new Vector3(0.625f, 0.0f, 4.375f);
                queen_black.transform.position = new Vector3(-0.625f, 0.0f, 4.375f);
                pawn_black1.transform.position = new Vector3(-0.625f, 0.0f, 3.125f);
                pawn_black2.transform.position = new Vector3(0.625f, 0.0f, 3.125f);
                pawn_black3.transform.position = new Vector3(1.875f, 0.0f, 3.125f);
                bishop_white1.transform.position = new Vector3(-1.875f, 0.0f, -0.625f);
                queen_white.transform.position = new Vector3(1.875f, 0.0f, -1.875f);
                break;
            case 2: // LEVEL II
                king_black.SetActive(true);
                pawn_black1.SetActive(true);
                pawn_black2.SetActive(true);
                tower_black.SetActive(true);
                pawn_white.SetActive(true);
                knight_white1.SetActive(true);
                king_black.transform.position = new Vector3(4.375f, 0.0f, 4.375f);
                tower_black.transform.position = new Vector3(3.125f, 0.0f, 4.375f);
                pawn_black1.transform.position = new Vector3(3.125f, 0.0f, 3.125f);
                pawn_black2.transform.position = new Vector3(4.375f, 0.0f, 3.125f);
                pawn_white.transform.position = new Vector3(4.375f, 0.0f, 1.875f);
                knight_white1.transform.position = new Vector3(3.125f, 0.0f, 0.625f);
                break;
            case 3: // LEVEL III
                king_black.SetActive(true);
                tower_black.SetActive(true);
                knight_black.SetActive(true);
                tower_white1.SetActive(true);
                queen_white.SetActive(true);
                king_black.transform.position = new Vector3(4.375f, 0.0f, 1.875f);
                tower_black.transform.position = new Vector3(-1.875f, 0.0f, 0.625f);
                knight_black.transform.position = new Vector3(1.875f, 0.0f, -0.625f);
                tower_white1.transform.position = new Vector3(-4.375f, 0.0f, 4.375f);
                queen_white.transform.position = new Vector3(3.125f, 0.0f, -3.125f);
                break;
            case 4: // LEVEL IV
                king_black.SetActive(true);
                tower_black.SetActive(true);
                bishop_black1.SetActive(true);
                knight_white1.SetActive(true);
                queen_white.SetActive(true);
                king_black.transform.position = new Vector3(-1.875f, 0.0f, 3.125f);
                tower_black.transform.position = new Vector3(-1.875f, 0.0f, 4.375f);
                bishop_black1.transform.position = new Vector3(-0.625f, 0.0f, 4.375f);
                knight_white1.transform.position = new Vector3(1.875f, 0.0f, 1.875f);
                queen_white.transform.position = new Vector3(-3.125f, 0.0f, 0.625f);
                break;
            case 5: // LEVEL V
                tower_black.SetActive(true);
                king_black.SetActive(true);
                bishop_black1.SetActive(true);
                pawn_black1.SetActive(true);
                pawn_black2.SetActive(true);
                pawn_black3.SetActive(true);
                pawn_black4.SetActive(true);
                pawn_black5.SetActive(true);
                bishop_white1.SetActive(true);
                pawn_white.SetActive(true);
                knight_white1.SetActive(true);
                bishop_white2.SetActive(true);
                tower_white1.SetActive(true);
                tower_black.transform.position = new Vector3(-3.125f, 0.0f, 4.375f);
                king_black.transform.position = new Vector3(0.625f, 0.0f, 4.375f);
                bishop_black1.transform.position = new Vector3(1.875f, 0.0f, 4.375f);
                pawn_black1.transform.position = new Vector3(-4.375f, 0.0f, 3.125f);
                pawn_black2.transform.position = new Vector3(-3.125f, 0.0f, 3.125f);
                pawn_black3.transform.position = new Vector3(0.625f, 0.0f, 3.125f);
                pawn_black4.transform.position = new Vector3(1.875f, 0.0f, 1.875f);
                pawn_black5.transform.position = new Vector3(-1.875f, 0.0f, 0.625f);
                bishop_white1.transform.position = new Vector3(-1.875f, 0.0f, 3.125f);
                pawn_white.transform.position = new Vector3(-1.875f, 0.0f, 1.875f);
                knight_white1.transform.position = new Vector3(0.625f, 0.0f, 0.625f);
                bishop_white2.transform.position = new Vector3(-4.375f, 0.0f, -0.625f);
                tower_white1.transform.position = new Vector3(-0.625f, 0.0f, -4.375f);
                break;
            case 6: // LEVEL VI
                pawn_black1.SetActive(true);
                king_black.SetActive(true);
                knight_black.SetActive(true);
                bishop_black1.SetActive(true);
                tower_black.SetActive(true);
                bishop_black2.SetActive(true);
                knight_white1.SetActive(true);
                bishop_white1.SetActive(true);
                tower_white1.SetActive(true);
                tower_white2.SetActive(true);
                pawn_black1.transform.position = new Vector3(-4.375f, 0.0f, 3.125f);
                king_black.transform.position = new Vector3(-3.125f, 0.0f, 3.125f);
                knight_black.transform.position = new Vector3(-4.375f, 0.0f, 1.875f);
                bishop_black1.transform.position = new Vector3(-4.375f, 0.0f, 0.625f);
                tower_black.transform.position = new Vector3(-3.125f, 0.0f, -1.875f);
                bishop_black2.transform.position = new Vector3(1.875f, 0.0f, -1.875f);
                knight_white1.transform.position = new Vector3(-0.625f, 0.0f, 3.125f);
                bishop_white1.transform.position = new Vector3(3.125f, 0.0f, -0.625f);
                tower_white1.transform.position = new Vector3(-3.125f, 0.0f, -4.375f);
                tower_white2.transform.position = new Vector3(-1.875f, 0.0f, -4.375f);
                break;
            case 7: // LEVEL VII
                tower_black.SetActive(true);
                king_black.SetActive(true);
                bishop_black1.SetActive(true);
                pawn_black1.SetActive(true);
                pawn_black2.SetActive(true);
                pawn_black3.SetActive(true);
                pawn_black4.SetActive(true);
                knight_white1.SetActive(true);
                knight_white2.SetActive(true);
                queen_white.SetActive(true);
                bishop_white1.SetActive(true);
                tower_black.transform.position = new Vector3(-4.375f, 0.0f, 4.375f);
                king_black.transform.position = new Vector3(1.875f, 0.0f, 1.875f);
                bishop_black1.transform.position = new Vector3(-1.875f, 0.0f, 4.375f);
                pawn_black1.transform.position = new Vector3(-4.375f, 0.0f, 3.125f);
                pawn_black2.transform.position = new Vector3(-3.125f, 0.0f, 3.125f);
                pawn_black3.transform.position = new Vector3(-1.875f, 0.0f, 3.125f);
                pawn_black4.transform.position = new Vector3(3.125f, 0.0f, 1.875f);
                knight_white1.transform.position = new Vector3(-1.875f, 0.0f, 1.875f);
                knight_white2.transform.position = new Vector3(4.375f, 0.0f, 1.875f);
                queen_white.transform.position = new Vector3(-4.375f, 0.0f, -1.875f);
                bishop_white1.transform.position = new Vector3(0.625f, 0.0f, -4.375f);
                break;
        }
    }

    private void checkTarget_xequeMate()
    {
        if (level == 1 && Math.Round(queen_white.transform.position.x, 3) == 1.875f && Math.Round(queen_white.transform.position.z, 3) == 3.125f)
        {
            king_black.SetActive(false);
            queen_black.SetActive(false);
            pawn_black1.SetActive(false);
            pawn_black2.SetActive(false);
            pawn_black3.SetActive(false);
            bishop_white1.SetActive(false);
            queen_white.SetActive(false);
            levelUp.Play(0);
            showLevels_xequeMate();
        }
        else if (level == 2 && Math.Round(knight_white1.transform.position.x, 3) == 1.875f && Math.Round(knight_white1.transform.position.z, 3) == 3.125f)
        {
            king_black.SetActive(false);
            pawn_black1.SetActive(false);
            pawn_black2.SetActive(false);
            tower_black.SetActive(false);
            pawn_white.SetActive(false);
            knight_white1.SetActive(false);
            levelUp.Play(0);
            showLevels_xequeMate();
        }
        else if (level == 3 && Math.Round(tower_white1.transform.position.x, 3) == 4.375f && Math.Round(tower_white1.transform.position.z, 3) == 4.375f)
        {
            king_black.SetActive(false);
            tower_black.SetActive(false);
            knight_black.SetActive(false);
            tower_white1.SetActive(false);
            queen_white.SetActive(false);
            levelUp.Play(0);
            showLevels_xequeMate();
        }
        else if (level == 4 && Math.Round(knight_white1.transform.position.x, 3) == 0.625f && Math.Round(knight_white1.transform.position.z, 3) == 4.375f)
        {
            king_black.SetActive(false);
            tower_black.SetActive(false);
            bishop_black1.SetActive(false);
            knight_white1.SetActive(false);
            queen_white.SetActive(false);
            levelUp.Play(0);
            showLevels_xequeMate();
        }
        else if (level == 5 && Math.Round(pawn_white.transform.position.x, 3) == -3.125f && Math.Round(pawn_white.transform.position.z, 3) == 3.125f)
        {
            tower_black.SetActive(false);
            king_black.SetActive(false);
            bishop_black1.SetActive(false);
            pawn_black1.SetActive(false);
            pawn_black2.SetActive(false);
            pawn_black3.SetActive(false);
            pawn_black4.SetActive(false);
            pawn_black5.SetActive(false);
            bishop_white1.SetActive(false);
            pawn_white.SetActive(false);
            knight_white1.SetActive(false);
            bishop_white2.SetActive(false);
            tower_white1.SetActive(false);
            levelUp.Play(0);
            showLevels_xequeMate();
        }
        else if (level == 6 && Math.Round(bishop_white1.transform.position.x, 3) == 1.875f && Math.Round(bishop_white1.transform.position.z, 3) == -1.875f)
        {
            pawn_black1.SetActive(false);
            king_black.SetActive(false);
            knight_black.SetActive(false);
            bishop_black1.SetActive(false);
            tower_black.SetActive(false);
            bishop_black2.SetActive(false);
            knight_white1.SetActive(false);
            bishop_white1.SetActive(false);
            tower_white1.SetActive(false);
            tower_white2.SetActive(false);
            levelUp.Play(0);
            showLevels_xequeMate();
        }
        else if (level == 7 && Math.Round(queen_white.transform.position.x, 3) == 0.625f && Math.Round(queen_white.transform.position.z, 3) == 3.125f)
        {
            tower_black.SetActive(false);
            king_black.SetActive(false);
            bishop_black1.SetActive(false);
            pawn_black1.SetActive(false);
            pawn_black2.SetActive(false);
            pawn_black3.SetActive(false);
            pawn_black4.SetActive(false);
            knight_white1.SetActive(false);
            knight_white2.SetActive(false);
            queen_white.SetActive(false);
            bishop_white1.SetActive(false);
            levelUp.Play(0);
            showLevels_xequeMate();
        }
    }

    public void clicked_xequeMate(GameObject object_clicked)
    {
        objectXequeMate = object_clicked;
        if (level == 1 && object_clicked == queen_white)
        {
            count_squares = 0;
            verifyPossibilities_bishop(queen_white);
            verifyPossibilities_tower(queen_white, queen_white.transform.position.x, 1);
            verifyPossibilities_tower(queen_white, queen_white.transform.position.z, 2);
        }
        else if (level == 2 && object_clicked == knight_white1)
        {
            count_squares = 0;
            showDirections_knight(knight_white1);
        }
        else if (level == 3 && object_clicked == tower_white1)
        {
            count_squares = 0;
            verifyPossibilities_tower(tower_white1, tower_white1.transform.position.x, 1);
            verifyPossibilities_tower(tower_white1, tower_white1.transform.position.z, 2);
        }
        else if (level == 4 && object_clicked == knight_white1)
        {
            count_squares = 0;
            showDirections_knight(knight_white1);
        }
        else if (level == 5 && object_clicked == pawn_white)
        {
            count_squares = 0;
            verifyPossibilities_pawn(pawn_white);
        }
        else if (level == 6 && object_clicked == bishop_white1)
        {
            count_squares = 0;
            verifyPossibilities_bishop(bishop_white1);
        }
        else if (level == 7 && object_clicked == queen_white)
        {
            count_squares = 0;
            verifyPossibilities_bishop(queen_white);
            verifyPossibilities_tower(queen_white, queen_white.transform.position.x, 1);
            verifyPossibilities_tower(queen_white, queen_white.transform.position.z, 2);
        }
    }

    private void showDirections_knight(GameObject knight)
    {
        List<Vector3> possibilities = new List<Vector3>();
        possibilities.Add(new Vector3(1.25f, 0.0101f, 2.5f));
        possibilities.Add(new Vector3(2.5f, 0.0101f, 1.25f));
        possibilities.Add(new Vector3(2.5f, 0.0101f, -1.25f));
        possibilities.Add(new Vector3(1.25f, 0.0101f, -2.5f));
        possibilities.Add(new Vector3(-1.25f, 0.0101f, -2.5f));
        possibilities.Add(new Vector3(-2.5f, 0.0101f, -1.25f));
        possibilities.Add(new Vector3(-2.5f, 0.0101f, 1.25f));
        possibilities.Add(new Vector3(-1.25f, 0.0101f, 2.5f));

        Vector3 aux;
        for (int i = 0; i < 8; i++)
        {
            aux = knight.transform.position + possibilities[i];
            if (insideBoundaries(aux))
            {
                count_squares++;
                squares["square" + count_squares].SetActive(true);
                squares["square" + count_squares].transform.position = aux;
            }
        }
    }

    private bool insideBoundaries(Vector3 aux)
    {
        if (aux.x > -4.4f && aux.x < 4.4f && aux.z > -4.4f && aux.z < 4.4f)
        {
            return true;
        }

        return false;
    }

    private void verifyPossibilities_pawn(GameObject pawnNum)
    {
        showDirections_pawn(pawnNum.transform.position.x - 1.25f, pawnNum.transform.position.z + 1.25f);
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
            Move_xequeMate(square_aux);
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

    private void introduce30squares()
    {
        while (count_squares < 30)
        {
            count_squares++;
            squares.Add("square" + count_squares, createSquare());
            squares["square" + count_squares].SetActive(false);
        }
        squares_introduced = true;
    }

    public void Move_xequeMate(GameObject object_clicked)
    {
        objectXequeMate.transform.position = object_clicked.transform.position;
        DeleteSquares_xequeMate();
        checkTarget_xequeMate();
    }

    private void DeleteSquares_xequeMate()
    {
        for (int j = 1; j < 31; j++)
        {
            squares["square" + j].SetActive(false);
        }
    }

    public void showLevels_xequeMate()
    {
        buttonLevels.SetActive(true);
        buttonPieces.SetActive(false);
        back2scenes.SetActive(false);
        back2pieces.SetActive(true);
        if (squares_introduced)
        {
            DeleteSquares_xequeMate();
        }
    }

    public void beginXequeMate()
    {
        buttonLevels.SetActive(false);
        back2pieces.SetActive(false);
    }

    public void endGame_xequeMate()
    {
        buttonLevels.SetActive(false);
        buttonPieces.SetActive(true);
        back2scenes.SetActive(true);
        back2pieces.SetActive(false);
    }
}
