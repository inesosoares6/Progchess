using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TowerScript2 : MonoBehaviour
{
    private GameObject objectTower;
    public GameObject tower;
    public GameObject tower2;
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

    public void defineLevel_tower(int num)
    {
        level = num;
        beginTower();
        moveTarget_tower(level);
    }

    private void checkTarget_tower()
    {
        if ((tower2.transform.position.x == targets["target2"].transform.position.x && tower2.transform.position.z == targets["target2"].transform.position.z 
            && tower.transform.position.x == targets["target1"].transform.position.x && tower.transform.position.z == targets["target1"].transform.position.z && level > 10) 
            || (tower2.transform.position.x == targets["target1"].transform.position.x && tower2.transform.position.z == targets["target1"].transform.position.z 
            && tower.transform.position.x == targets["target2"].transform.position.x && tower.transform.position.z == targets["target2"].transform.position.z && level > 10))
        {
            if (level == 12)
            {
                levelUp.Play(0);
                showLevels_tower();
            }
            else if (level == 16)
            {
                levelUp.Play(0);
                showLevels_tower();
            }
            else
            {
                rightAnswer.Play(0);
                level++;
                moveTarget_tower(level);
            }
        }
        else if (tower.transform.position.x == targets["target1"].transform.position.x && tower.transform.position.z == targets["target1"].transform.position.z && level < 11)
        {
            if (level == 2)
            {
                showLevels_tower();
                levelUp.Play(0);
            }
            else if (level == 5)
            {
                levelUp.Play(0);
                showLevels_tower();
            }
            else if (level == 10)
            {
                levelUp.Play(0);
                showLevels_tower();
            }
            else
            {
                rightAnswer.Play(0);
                level++;
                moveTarget_tower(level);
            }
        }
    }

    private void moveTarget_tower(int levelNum)
    {
        switch (levelNum)
        {
            case 1: // LEVEL I - x1
                tower.transform.position = new Vector3(-4.375f, 0.0f, -4.375f);
                targets["target1"].SetActive(true);
                targets["target2"].SetActive(false);
                targets["target1"].transform.position = new Vector3(-4.375f, 0.1f, 1.875f);
                break;
            case 2: // LEVEL I - x2
                targets["target1"].transform.position = new Vector3(0.625f, 0.1f, 1.875f);
                break;
            case 3: // LEVEL II - x1
                tower.transform.position = new Vector3(-0.625f, 0.0f, -0.625f);
                targets["target1"].SetActive(true);
                targets["target2"].SetActive(false);
                targets["target1"].transform.position = new Vector3(-4.375f, 0.1f, -0.625f);
                break;
            case 4: // LEVEL II - x2
                targets["target1"].transform.position = new Vector3(3.125f, 0.1f, -0.625f);
                break;
            case 5: // LEVEL II - x3
                targets["target1"].transform.position = new Vector3(3.125f, 0.1f, -1.875f);
                break;
            case 6: // LEVEL III - x1
                tower.transform.position = new Vector3(4.375f, 0.0f, 4.375f);
                targets["target1"].SetActive(true);
                targets["target2"].SetActive(false);
                targets["target1"].transform.position = new Vector3(4.375f, 0.1f, 3.125f);
                break;
            case 7: // LEVEL III - x2
                targets["target1"].transform.position = new Vector3(3.125f, 0.1f, 3.125f);
                break;
            case 8: // LEVEL III - x3
                targets["target1"].transform.position = new Vector3(3.125f, 0.1f, -4.375f);
                break;
            case 9: // LEVEL III - x4
                targets["target1"].transform.position = new Vector3(3.125f, 0.1f, 4.375f);
                break;
            case 10: // LEVEL III - x5
                targets["target1"].transform.position = new Vector3(1.875f, 0.1f, 4.375f);
                break;
            case 11: // LEVEL IV - x1
                tower2.SetActive(true);
                tower.SetActive(true);
                tower2.transform.position = new Vector3(-0.625f, 0.0f, -0.625f);
                tower.transform.position = new Vector3(-3.125f, 0.0f, 3.125f);
                targets["target1"].SetActive(true);
                targets["target2"].SetActive(true);
                targets["target1"].transform.position = new Vector3(3.125f, 0.1f, 3.125f);
                targets["target2"].transform.position = new Vector3(4.375f, 0.1f, -0.625f);
                break;
            case 12: // LEVEL IV - x2
                targets["target1"].transform.position = new Vector3(3.125f, 0.1f, -1.875f);
                targets["target2"].transform.position = new Vector3(-4.375f, 0.1f, -0.625f);
                break;
            case 13: // LEVEL V - x1
                tower2.SetActive(true);
                tower.SetActive(true);
                tower.transform.position = new Vector3(-4.375f, 0.0f, -4.375f);
                tower2.transform.position = new Vector3(1.875f, 0.0f, -1.875f);
                targets["target1"].SetActive(true);
                targets["target2"].SetActive(true);
                targets["target1"].transform.position = new Vector3(-0.625f, 0.1f, -4.375f);
                targets["target2"].transform.position = new Vector3(1.875f, 0.1f, -3.125f);
                break;
            case 14: // LEVEL V - x2
                targets["target1"].transform.position = new Vector3(-0.625f, 0.1f, 0.625f);
                targets["target2"].transform.position = new Vector3(1.875f, 0.1f, 3.125f);
                break;
            case 15: // LEVEL V - x3
                targets["target1"].transform.position = new Vector3(3.125f, 0.1f, -0.625f);
                targets["target2"].transform.position = new Vector3(-3.125f, 0.1f, 3.125f);
                break;
            case 16: // LEVEL V - x4
                targets["target1"].transform.position = new Vector3(3.125f, 0.1f, 3.125f);
                break;
        }
    }

    public void clicked_tower(GameObject towerNum)
    {
        objectTower = towerNum;
        count_squares = 0;
        verifyPossibilities_tower(towerNum, towerNum.transform.position.x, 1);
        verifyPossibilities_tower(towerNum, towerNum.transform.position.z, 2);
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
            Move_tower(square_aux);
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

    public void Move_tower(GameObject towerDirection)
    {
        objectTower.transform.position = towerDirection.transform.position;
        DeleteSquares_tower();
        checkTarget_tower();
    }

    private void DeleteSquares_tower()
    {
        for (int j = 1; j < 15; j++)
        {
            squares["square" + j].SetActive(false);
        }
    }

    public void beginTower()
    {
        buttonLevels.SetActive(false);
        back2pieces.SetActive(false);
    }

    public void showLevels_tower()
    {
        buttonLevels.SetActive(true);
        buttonPieces.SetActive(false);
        back2scenes.SetActive(false);
        back2pieces.SetActive(true);
        if (squares_introduced)
        {
            DeleteSquares_tower();
            targets["target1"].SetActive(false);
            targets["target2"].SetActive(false);
        }
        tower2.SetActive(false);
        tower.transform.position = new Vector3(-4.375f, 0.0f, 4.375f);
    }

    public void endGame_tower()
    {
        buttonLevels.SetActive(false);
        tower.SetActive(false);
        buttonPieces.SetActive(true);
        back2scenes.SetActive(true);
        back2pieces.SetActive(false);
    }
}