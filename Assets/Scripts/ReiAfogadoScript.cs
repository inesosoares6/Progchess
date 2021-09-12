using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.EventSystems;

public class ReiAfogadoScript : MonoBehaviour
{
    private int level;
    public GameObject buttonLevels;
    public GameObject back2pieces;
    public GameObject back2scenes;
    public GameObject buttonPieces;
    public AudioSource levelUp;
    public GameObject king_white;
    public GameObject queen_black;
    public GameObject bishop_black;
    public GameObject knight_black;
    public GameObject bishop_white;
    public GameObject knight_white;
    public GameObject tower_black1;
    public GameObject tower_black2;
    public GameObject tower_white;
    public GameObject pawn_white1;
    public GameObject pawn_white2;
    public GameObject pawn_white3;
    public GameObject pawn_black;
    private int count_squares = 0;
    Dictionary<string, GameObject> squares = new Dictionary<string, GameObject>();
    private bool squares_introduced = false;
    private GameObject objectReiAfogado;

    private void Start()
    {
        introduce30squares();
        count_squares = 0;
    }

    public void defineLevel_ReiAfogado(int num)
    {
        level = num;
        beginReiAfogado();
        moveTarget_ReiAfogado(level);
    }

    private void moveTarget_ReiAfogado(int levelNum)
    {
        switch (levelNum)
        {
            case 1: // LEVEL I
                // TODO
                break;
            case 2: // LEVEL II
                // TODO
                break;
            case 3: // LEVEL III
                // TODO
                break;
            case 4: // LEVEL IV
                // TODO
                break;
            case 5: // LEVEL V
                // TODO
                break;
            case 6: // LEVEL VI
                // TODO
                break;
            case 7: // LEVEL VII
                // TODO
                break;
        }
    }

    private void checkTarget_ReiAfogado()
    {
        if (level == 1) // TODO
        {
            // TODO
            levelUp.Play(0);
            showLevels_ReiAfogado();
        }
        else if (level == 2) // TODO
        {
            // TODO
            levelUp.Play(0);
            showLevels_ReiAfogado();
        }
        else if (level == 3) // TODO
        {
            // TODO
            levelUp.Play(0);
            showLevels_ReiAfogado();
        }
        else if (level == 4) // TODO
        {
            // TODO
            levelUp.Play(0);
            showLevels_ReiAfogado();
        }
        else if (level == 5) // TODO
        {
            // TODO
            levelUp.Play(0);
            showLevels_ReiAfogado();
        }
        else if (level == 6) // TODO
        {
            // TODO
            levelUp.Play(0);
            showLevels_ReiAfogado();
        }
        else if (level == 7) // TODO
        {
            // TODO
            levelUp.Play(0);
            showLevels_ReiAfogado();
        }
    }

    public void clicked_ReiAfogado(GameObject object_clicked)
    {
        objectReiAfogado = object_clicked;
        if (level == 1) // TODO
        {
            count_squares = 0;
            // TODO
        }
        else if (level == 2) // TODO
        {
            count_squares = 0;
            // TODO
        }
        else if (level == 3) // TODO
        {
            count_squares = 0;
            // TODO
        }
        else if (level == 4) // TODO
        {
            count_squares = 0;
            // TODO
        }
        else if (level == 5) // TODO
        {
            count_squares = 0;
            // TODO
        }
        else if (level == 6) // TODO
        {
            count_squares = 0;
            // TODO
        }
        else if (level == 6) // TODO
        {
            count_squares = 0;
            // TODO
        }
        else if (level == 7) // TODO
        {
            count_squares = 0;
            // TODO
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
        showDirections_pawn(pawnNum.transform.position.x, pawnNum.transform.position.z + 1.25f);
        showDirections_pawn(pawnNum.transform.position.x, pawnNum.transform.position.z + 2.5f);
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
            Move_ReiAfogado(square_aux);
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

    public void Move_ReiAfogado(GameObject object_clicked)
    {
        objectReiAfogado.transform.position = object_clicked.transform.position;
        DeleteSquares_ReiAfogado();
        checkTarget_ReiAfogado();
    }

    private void DeleteSquares_ReiAfogado()
    {
        for (int j = 1; j < 31; j++)
        {
            squares["square" + j].SetActive(false);
        }
    }

    public void showLevels_ReiAfogado()
    {
        buttonLevels.SetActive(true);
        buttonPieces.SetActive(false);
        back2scenes.SetActive(false);
        back2pieces.SetActive(true);
        if (squares_introduced)
        {
            DeleteSquares_ReiAfogado();
        }
    }

    public void beginReiAfogado()
    {
        buttonLevels.SetActive(false);
        back2pieces.SetActive(false);
    }
}
