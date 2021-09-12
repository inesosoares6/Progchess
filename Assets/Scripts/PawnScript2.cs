using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PawnScript2 : MonoBehaviour
{
    private GameObject objectPawn;
    public GameObject pawn;
    public GameObject pawn2;
    public GameObject pawn3;
    public GameObject pawn4;
    public GameObject buttonPieces;
    public GameObject buttonLevels;
    public GameObject back2scenes;
    public GameObject back2pieces;
    private bool firstMove = true;
    private int level;
    public AudioSource rightAnswer;
    public AudioSource levelUp;
    private int count_squares = 0;
    Dictionary<string, GameObject> squares = new Dictionary<string, GameObject>();
    private bool squares_introduced = false;
    private int count_targets = 0;
    Dictionary<string, GameObject> targets = new Dictionary<string, GameObject>();
    private bool firstTime = true;

    private void Start()
    {
        introduce8squares();
        count_squares = 0;
        introduce4targets();
    }

    public void defineLevel_pawn(int num)
    {
        level = num;
        beginPawn();
        moveTarget_pawn(level);
    }

    private void checkTarget_pawn()
    {
        if (level == 13 && pawn2.transform.position.x == targets["target2"].transform.position.x && pawn2.transform.position.z == targets["target2"].transform.position.z && firstTime)
        {
            firstTime = false;
            rightAnswer.Play(0);
            targets["target2"].transform.position = new Vector3(0.625f, 0.1f, -0.625f);
        }
        else if(level == 13 && target_level13() && !firstTime)
        {
            levelUp.Play(0);
            showLevels_pawn();
            toggleTargets(false);
            pawn2.SetActive(false);
            pawn3.SetActive(false);
            pawn4.SetActive(false);
        }
        else if (pawn.transform.position.x == targets["target1"].transform.position.x && pawn.transform.position.z == targets["target1"].transform.position.z && level != 13)
        {
            if (level == 3)
            {
                showLevels_pawn();
                levelUp.Play(0);
            }
            else if (level == 7)
            {
                levelUp.Play(0);
                showLevels_pawn();
            }
            else if (level == 12)
            {
                levelUp.Play(0);
                showLevels_pawn();
            }
            else if (level == 14)
            {
                levelUp.Play(0);
                showLevels_pawn();
            }
            else
            {
                rightAnswer.Play(0);
                level++;
                moveTarget_pawn(level);
            }
        }
        else
        {
            if (pawn.transform.position.x == targets["target1"].transform.position.x && pawn.transform.position.z == targets["target1"].transform.position.z && level == 13)
            {
                targets["target1"].SetActive(false);
                rightAnswer.Play(0);
            }
            if (pawn2.transform.position.x == targets["target2"].transform.position.x && pawn2.transform.position.z == targets["target2"].transform.position.z && level == 13)
            {
                targets["target2"].SetActive(false);
                rightAnswer.Play(0);
            }
            if (pawn3.transform.position.x == targets["target3"].transform.position.x && pawn3.transform.position.z == targets["target3"].transform.position.z && level == 13)
            {
                targets["target3"].SetActive(false);
                rightAnswer.Play(0);
            }
            if (pawn4.transform.position.x == targets["target4"].transform.position.x && pawn4.transform.position.z == targets["target4"].transform.position.z && level == 13)
            {
                targets["target4"].SetActive(false);
                rightAnswer.Play(0);
            }
        }
    }

    private bool target_level13()
    {
        if((pawn.transform.position.x == targets["target1"].transform.position.x && pawn.transform.position.z == targets["target1"].transform.position.z) &&
           (pawn2.transform.position.x == targets["target2"].transform.position.x && pawn2.transform.position.z == targets["target2"].transform.position.z) &&
           (pawn3.transform.position.x == targets["target3"].transform.position.x && pawn3.transform.position.z == targets["target3"].transform.position.z) &&
           (pawn4.transform.position.x == targets["target4"].transform.position.x && pawn4.transform.position.z == targets["target4"].transform.position.z))
        {
            return true;
        }

        return false;
    }

    private void moveTarget_pawn(int levelNum)
    {
        switch (levelNum)
        {
            case 1: // LEVEL I - x1
                firstMove = true;
                toggleTargets(false);
                pawn.transform.position = new Vector3(-1.875f, 0.0f, -3.125f);
                targets["target1"].SetActive(true);
                targets["target1"].transform.position = new Vector3(-3.125f, 0.1f, -0.625f);
                break;
            case 2: // LEVEL I - x2
                firstMove = false;
                targets["target1"].transform.position = new Vector3(-1.875f, 0.1f, 0.625f);
                break;
            case 3: // LEVEL I - x3
                targets["target1"].transform.position = new Vector3(-3.125f, 0.1f, 1.875f);
                break;
            case 4: // LEVEL II - x1
                firstMove = true;
                toggleTargets(false);
                pawn.transform.position = new Vector3(-3.125f, 0.0f, -3.125f);
                targets["target1"].SetActive(true);
                targets["target1"].transform.position = new Vector3(-1.875f, 0.1f, -1.875f);
                break;
            case 5: // LEVEL II - x2
                firstMove = false;
                targets["target1"].transform.position = new Vector3(-0.625f, 0.1f, 0.625f);
                break;
            case 6: // LEVEL II - x3
                targets["target1"].transform.position = new Vector3(-1.875f, 0.1f, 1.875f);
                break;
            case 7: // LEVEL II - x4
                targets["target1"].transform.position = new Vector3(-0.625f, 0.1f, 4.375f);
                break;
            case 8: // LEVEL III - x1
                firstMove = true;
                toggleTargets(false);
                pawn.transform.position = new Vector3(-0.625f, 0.0f, -1.875f);
                targets["target1"].SetActive(true);
                targets["target1"].transform.position = new Vector3(-1.875f, 0.1f, -0.625f);
                break;
            case 9: // LEVEL III - x2
                firstMove = false;
                targets["target1"].transform.position = new Vector3(-0.625f, 0.1f, 0.625f);
                break;
            case 10: // LEVEL III - x3
                targets["target1"].transform.position = new Vector3(0.625f, 0.1f, 1.875f);
                break;
            case 11: // LEVEL III - x4
                targets["target1"].transform.position = new Vector3(-0.625f, 0.1f, 3.125f);
                break;
            case 12: // LEVEL III - x5
                targets["target1"].transform.position = new Vector3(-1.875f, 0.1f, 4.375f);
                break;
            case 13: // LEVEL IV - x1
                firstMove = true;
                pawn2.SetActive(true);
                pawn3.SetActive(true);
                pawn4.SetActive(true);
                pawn.transform.position = new Vector3(-4.375f, 0.0f, -3.125f);
                pawn2.transform.position = new Vector3(-1.875f, 0.0f, -3.125f);
                pawn3.transform.position = new Vector3(-0.625f, 0.0f, -3.125f);
                pawn4.transform.position = new Vector3(4.375f, 0.0f, -3.125f);
                toggleTargets(true);
                targets["target1"].SetActive(true);
                targets["target1"].transform.position = new Vector3(-3.125f, 0.1f, -0.625f);
                targets["target3"].transform.position = new Vector3(-1.875f, 0.1f, -0.625f);
                targets["target4"].transform.position = new Vector3(3.125f, 0.1f, -1.875f);
                targets["target2"].transform.position = new Vector3(-0.625f, 0.1f, -1.875f);
                break;
            case 14: // LEVEL V - x1
                firstMove = true;
                toggleTargets(false);
                pawn.transform.position = new Vector3(0.625f, 0.0f, -3.125f);
                targets["target1"].SetActive(true);
                targets["target1"].transform.position = new Vector3(-0.625f, 0.1f, 1.875f);
                break;
        }
    }

    public void clicked_pawn(int pawnNum)
    {
        switch (pawnNum)
        {
            case 1:
                objectPawn = pawn;
                break;
            case 2:
                objectPawn = pawn2;
                break;
            case 3:
                objectPawn = pawn3;
                break;
            case 4:
                objectPawn = pawn4;
                break;
        }
        count_squares = 0;
        verifyPossibilities_pawn(objectPawn, pawnNum);
    }

    private void verifyPossibilities_pawn(GameObject pawnNum, int opt)
    {
        if (targets["target" + opt].transform.position.z != pawnNum.transform.position.z + 1.25f && targets["target" + opt].transform.position.x != pawnNum.transform.position.x)
        {
            if ( !(opt == 3 && targets["target2"].transform.position.z == pawn3.transform.position.z + 1.25f && targets["target2"].transform.position.x == pawn3.transform.position.x))
            {
                showDirections_pawn(pawnNum.transform.position.x, pawnNum.transform.position.z + 1.25f);
            }
            if (targets["target" + opt].transform.position.z != pawnNum.transform.position.z + 2.5f && targets["target" + opt].transform.position.x != pawnNum.transform.position.x && firstMove)
            {
                showDirections_pawn(pawnNum.transform.position.x, pawnNum.transform.position.z + 2.5f);
            }
        }
        if (targets["target" + opt].transform.position.z == pawnNum.transform.position.z + 1.25f && targets["target" + opt].transform.position.x == pawnNum.transform.position.x + 1.25f)
        {
            showDirections_pawn(pawnNum.transform.position.x + 1.25f, pawnNum.transform.position.z + 1.25f);
        }
        if (targets["target" + opt].transform.position.z == pawnNum.transform.position.z + 1.25f && targets["target" + opt].transform.position.x == pawnNum.transform.position.x - 1.25f)
        {
            showDirections_pawn(pawnNum.transform.position.x - 1.25f, pawnNum.transform.position.z + 1.25f);
        }
    }

    private void introduce8squares()
    {
        while (count_squares < 8)
        {
            count_squares++;
            squares.Add("square" + count_squares, createSquare());
            squares["square" + count_squares].SetActive(false);
        }
        squares_introduced = true;
    }

    private void introduce4targets()
    {
        while (count_targets < 4)
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
            Move_pawn(square_aux);
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

    private void showDirections_pawn(float axisX, float axisZ)
    {
        count_squares++;
        squares["square" + count_squares].SetActive(true);
        squares["square" + count_squares].transform.position = new Vector3(axisX, 0.0101f, axisZ);
    }

    public void Move_pawn(GameObject pawnDirection)
    {
        objectPawn.transform.position = pawnDirection.transform.position;
        DeleteSquares_pawn();
        checkTarget_pawn();
    }

    private void DeleteSquares_pawn()
    {
        for (int j = 1; j < 4; j++)
        {
            squares["square" + j].SetActive(false);
        }
    }

    private void toggleTargets(bool opt)
    {
        for (int j = 2; j < 5; j++)
        {
            targets["target" + j].SetActive(opt);
        }
    }

    public void beginPawn()
    {
        buttonLevels.SetActive(false);
        back2pieces.SetActive(false);
    }

    public void showLevels_pawn()
    {
        buttonLevels.SetActive(true);
        buttonPieces.SetActive(false);
        back2scenes.SetActive(false);
        back2pieces.SetActive(true);
        if (squares_introduced)
        {
            DeleteSquares_pawn();
            toggleTargets(false);
            targets["target1"].SetActive(false);
        }
        pawn.transform.position = new Vector3(-4.375f, 0.0f, 4.375f);
    }

    public void endGame_pawn()
    {
        buttonLevels.SetActive(false);
        pawn.SetActive(false);
        buttonPieces.SetActive(true);
        back2scenes.SetActive(true);
        back2pieces.SetActive(false);
    }
}
