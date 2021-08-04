using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BishopScript2 : MonoBehaviour
{
    private GameObject objectBishop;
    public GameObject bishop;
    public GameObject bishop2;
    public GameObject buttonPieces;
    public GameObject buttonLevels;
    public GameObject back2scenes;
    public GameObject back2pieces;
    private int level;
    public AudioSource rightAnswer;
    public AudioSource levelUp;
    private int count_squares = 0;
    Dictionary<string, GameObject> squares = new Dictionary<string, GameObject>();
    private bool squares_introduced = false;
    private int count_targets = 0;
    Dictionary<string, GameObject> targets = new Dictionary<string, GameObject>();

    private void Start()
    {
        introduce14squares();
        count_squares = 0;
        introduce2targets();
    }

    public void defineLevel_bishop(int num)
    {
        level = num;
        beginBishop();
        moveTarget_bishop(level);
    }

    private void checkTarget_bishop()
    {
        if (bishop2.transform.position.x == targets["target2"].transform.position.x && bishop2.transform.position.z == targets["target2"].transform.position.z && bishop.transform.position.x == targets["target1"].transform.position.x && bishop.transform.position.z == targets["target1"].transform.position.z && level > 17)
        {
            if (level == 20)
            {
                levelUp.Play(0);
                showLevels_bishop();
            }
            else if (level == 24)
            {
                levelUp.Play(0);
                showLevels_bishop();
            }
            else
            {
                rightAnswer.Play(0);
                level++;
                moveTarget_bishop(level);
            }
        }
        else if (bishop.transform.position.x == targets["target1"].transform.position.x && bishop.transform.position.z == targets["target1"].transform.position.z && level < 18)
        {
            if (level == 5)
            {
                showLevels_bishop();
                levelUp.Play(0);
            }
            else if (level == 11)
            {
                levelUp.Play(0);
                showLevels_bishop();
            }
            else if (level == 17)
            {
                levelUp.Play(0);
                showLevels_bishop();
            }
            else
            {
                rightAnswer.Play(0);
                level++;
                moveTarget_bishop(level);
            }
        }
    }

    private void moveTarget_bishop(int levelNum)
    {
        switch (levelNum)
        {
            case 1: // LEVEL I - x1
                bishop.transform.position = new Vector3(-1.875f, 0.0f, -4.375f);
                targets["target1"].SetActive(true);
                targets["target2"].SetActive(false);
                targets["target1"].transform.position = new Vector3(-3.125f, 0.1f, -3.125f);
                break;
            case 2: // LEVEL I - x2
                targets["target1"].transform.position = new Vector3(-4.375f, 0.1f, -1.875f);
                break;
            case 3: // LEVEL I - x3
                targets["target1"].transform.position = new Vector3(-1.875f, 0.1f, 0.625f);
                break;
            case 4: // LEVEL I - x4
                targets["target1"].transform.position = new Vector3(0.625f, 0.1f, -1.875f);
                break;
            case 5: // LEVEL I - x5
                targets["target1"].transform.position = new Vector3(3.125f, 0.1f, -4.375f);
                break;
            case 6: // LEVEL II - x1
                bishop.transform.position = new Vector3(-0.625f, 0.0f, -0.625f);
                targets["target1"].SetActive(true);
                targets["target2"].SetActive(false);
                targets["target1"].transform.position = new Vector3(-3.125f, 0.1f, 1.875f);
                break;
            case 7: // LEVEL II - x2
                targets["target1"].transform.position = new Vector3(0.625f, 0.1f, -1.875f);
                break;
            case 8: // LEVEL II - x3
                targets["target1"].transform.position = new Vector3(-1.875f, 0.1f, -4.375f);
                break;
            case 9: // LEVEL II - x4
                targets["target1"].transform.position = new Vector3(4.375f, 0.1f, 1.875f);
                break;
            case 10: // LEVEL II - x5
                targets["target1"].transform.position = new Vector3(3.125f, 0.1f, 3.125f);
                break;
            case 11: // LEVEL II - x6
                targets["target1"].transform.position = new Vector3(-4.375f, 0.1f, -4.375f);
                break;
            case 12: // LEVEL III - x1
                bishop.transform.position = new Vector3(-1.875f, 0.0f, -0.625f);
                targets["target1"].SetActive(true);
                targets["target2"].SetActive(false);
                targets["target1"].transform.position = new Vector3(-3.125f, 0.1f, -1.875f);
                break;
            case 13: // LEVEL III - x2
                targets["target1"].transform.position = new Vector3(-4.375f, 0.1f, -0.625f);
                break;
            case 14: // LEVEL III - x3
                targets["target1"].transform.position = new Vector3(-1.875f, 0.1f, -3.125f);
                break;
            case 15: // LEVEL III - x4
                targets["target1"].transform.position = new Vector3(-3.125f, 0.1f, -4.375f);
                break;
            case 16: // LEVEL III - x5
                targets["target1"].transform.position = new Vector3(-0.625f, 0.1f, -1.875f);
                break;
            case 17: // LEVEL III - x6
                targets["target1"].transform.position = new Vector3(0.625f, 0.1f, -3.125f);
                break;
            // --------------- 2 bishops // 2 targets ---------------------------
            case 18: // LEVEL IV - x1
                bishop2.SetActive(true);
                bishop.SetActive(true);
                bishop2.transform.position = new Vector3(1.875f, 0.0f, -4.375f);
                bishop.transform.position = new Vector3(-1.875f, 0.0f, -4.375f);
                targets["target1"].SetActive(true);
                targets["target2"].SetActive(true);
                targets["target1"].transform.position = new Vector3(0.625f, 0.1f, -1.875f);
                targets["target2"].transform.position = new Vector3(-0.625f, 0.1f, -1.875f);
                break;
            case 19: // LEVEL IV - x2
                targets["target1"].transform.position = new Vector3(-0.625f, 0.1f, -0.625f);
                targets["target2"].transform.position = new Vector3(0.625f, 0.1f, -0.625f);
                break;
            case 20: // LEVEL IV - x3
                targets["target1"].transform.position = new Vector3(0.625f, 0.1f, 0.625f);
                targets["target2"].transform.position = new Vector3(-0.625f, 0.1f, 0.625f);
                break;
            case 21: // LEVEL V - x1
                bishop2.SetActive(true);
                bishop.SetActive(true);
                bishop.transform.position = new Vector3(-0.625f, 0.0f, 3.125f);
                bishop2.transform.position = new Vector3(-1.875f, 0.0f, -1.875f);
                targets["target1"].SetActive(true);
                targets["target2"].SetActive(true);
                targets["target1"].transform.position = new Vector3(1.875f, 0.1f, 0.625f);
                targets["target2"].transform.position = new Vector3(1.875f, 0.1f, 1.875f);
                break;
            case 22: // LEVEL V - x2
                targets["target1"].transform.position = new Vector3(-1.875f, 0.1f, -3.125f);
                targets["target2"].transform.position = new Vector3(4.375f, 0.1f, -0.625f);
                break;
            case 23: // LEVEL V - x3
                targets["target1"].transform.position = new Vector3(4.375f, 0.1f, 3.125f);
                targets["target2"].transform.position = new Vector3(0.625f, 0.1f, 3.125f);
                break;
            case 24: // LEVEL V - x4
                targets["target1"].transform.position = new Vector3(3.125f, 0.1f, 4.375f);
                targets["target2"].transform.position = new Vector3(-4.375f, 0.1f, -1.875f);
                break;
        }
    }

    public void clicked_bishop(GameObject bishopNum)
    {
        objectBishop = bishopNum;
        count_squares = 0;
        verifyPossibilities_bishop(bishopNum);
        count_squares = 0;
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

    private void introduce14squares()
    {
        while (count_squares < 14)
        {
            count_squares++;
            squares.Add("square" + count_squares, createSquare());
            squares["square" + count_squares].SetActive(false);
        }
        squares_introduced = true;
    }
    private void introduce2targets()
    {
        while (count_targets < 2)
        {
            count_targets++;
            targets.Add("target" + count_targets, createTarget());
            targets["target" + count_targets].SetActive(false);
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
            Move_bishop(square_aux);
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

    private GameObject createTarget()
    {
        GameObject target;
        target = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        target.GetComponent<Renderer>().material.color = Color.red;
        target.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
        target.SetActive(false);

        return target;
    }

    private void showDirections_bishop(float axisX, float axisZ)
    {
        count_squares++;
        squares["square" + count_squares].SetActive(true);
        squares["square" + count_squares].transform.position = new Vector3(axisX, 0.0101f, axisZ);
    }

    public void Move_bishop(GameObject bishopDirection)
    {
        objectBishop.transform.position = bishopDirection.transform.position;
        DeleteArrows_bishop();
        checkTarget_bishop();
    }

    private void DeleteArrows_bishop()
    {
        for (int j = 1; j < 15; j++)
        {
            squares["square" + j].SetActive(false);
        }
    }

    public void beginBishop()
    {
        buttonLevels.SetActive(false);
        back2pieces.SetActive(false);
    }

    public void showLevels_bishop()
    {
        buttonLevels.SetActive(true);
        buttonPieces.SetActive(false);
        back2scenes.SetActive(false);
        back2pieces.SetActive(true);
        if (squares_introduced)
        {
            DeleteArrows_bishop();
            targets["target1"].SetActive(false);
            targets["target2"].SetActive(false);
        }
        bishop2.SetActive(false);
        bishop.transform.position = new Vector3(-4.375f, 0.0f, 4.375f);
    }

    public void endGame_bishop()
    {
        DeleteArrows_bishop();
        buttonLevels.SetActive(false);
        bishop.SetActive(false);
        bishop2.SetActive(false);
        buttonPieces.SetActive(true);
        back2scenes.SetActive(true);
        back2pieces.SetActive(false);
        targets["target1"].SetActive(false);
        targets["target2"].SetActive(false);
    }
}
