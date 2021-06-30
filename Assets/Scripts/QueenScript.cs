using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class QueenScript : MonoBehaviour
{
    private GameObject objectQueen;
    public GameObject queen;
    public GameObject cameraRig;
    public GameObject buttonPieces;
    public GameObject buttonLevels;
    public GameObject target;
    public GameObject back2scenes;
    public GameObject back2pieces;
    private int level;
    public AudioSource rightAnswer;
    public AudioSource levelUp;
    private int count_spheres = 0;
    Dictionary<string, GameObject> spheres = new Dictionary<string, GameObject>();
    private bool spheres_introduced = false;

    private void Start()
    {
        introduce27spheres();
        count_spheres = 0;
    }

    public void defineLevel_queen(int num)
    {
        level = num;
        beginQueen();
        moveTarget_queen(level);
    }

    private void checkTarget_queen()
    {
        if (queen.transform.position.x == target.transform.position.x && queen.transform.position.z == target.transform.position.z)
        {
            if (level == 2)
            {
                showLevels_queen();
                levelUp.Play(0);
            }
            else if (level == 6)
            {
                levelUp.Play(0);
                showLevels_queen();
            }
            else if (level == 12)
            {
                levelUp.Play(0);
                showLevels_queen();
            }
            else if (level == 19)
            {
                levelUp.Play(0);
                showLevels_queen();
            }
            else if (level == 27)
            {
                levelUp.Play(0);
                showLevels_queen();
            }
            else
            {
                rightAnswer.Play(0);
                level++;
                moveTarget_queen(level);
            }
        }
    }

    private void moveTarget_queen(int levelNum)
    {
        switch (levelNum)
        {
            case 1: // LEVEL I - x1
                queen.transform.position = new Vector3(-3.0f, 0.0f, -21.0f);
                target.SetActive(true);
                target.transform.position = new Vector3(-3.0f, 0.2f, 3.0f);
                cameraRig.transform.position = new Vector3(-2.03f, 9.11f, -32.28f);
                break;
            case 2: // LEVEL I - x2
                target.transform.position = new Vector3(-21.0f, 0.2f, 21.0f);
                break;
            case 3: // LEVEL II - x1
                queen.transform.position = new Vector3(-3.0f, 0.0f, -3.0f);
                target.SetActive(true);
                target.transform.position = new Vector3(9.0f, 0.2f, -15.0f);
                cameraRig.transform.position = queen.transform.position + new Vector3(0.0f, 10.0f, -20.0f);
                break;
            case 4: // LEVEL II - x2
                target.transform.position = new Vector3(9.0f, 0.2f, 21.0f);
                break;
            case 5: // LEVEL II - x3
                target.transform.position = new Vector3(-21.0f, 0.2f, -9.0f);
                break;
            case 6: // LEVEL II - x4
                target.transform.position = new Vector3(21.0f, 0.2f, -9.0f);
                break;
            case 7: // LEVEL III - x1
                queen.transform.position = new Vector3(-9.0f, 0.0f, -3.0f);
                target.SetActive(true);
                target.transform.position = new Vector3(9.0f, 0.2f, -21.0f);
                cameraRig.transform.position = queen.transform.position + new Vector3(0.0f, 10.0f, -20.0f);
                break;
            case 8: // LEVEL III - x2
                target.transform.position = new Vector3(9.0f, 0.2f, 21.0f);
                break;
            case 9: // LEVEL III - x3
                target.transform.position = new Vector3(21.0f, 0.2f, 9.0f);
                break;
            case 10: // LEVEL III - x4
                target.transform.position = new Vector3(-3.0f, 0.2f, 9.0f);
                break;
            case 11: // LEVEL III - x5
                target.transform.position = new Vector3(-21.0f, 0.2f, -9.0f);
                break;
            case 12: // LEVEL III - x6
                target.transform.position = new Vector3(15.0f, 0.2f, -9.0f);
                break;
            case 13: // LEVEL IV - x1
                queen.transform.position = new Vector3(15.0f, 0.0f, 15.0f);
                target.SetActive(true);
                target.transform.position = new Vector3(15.0f, 0.2f, -21.0f);
                cameraRig.transform.position = new Vector3(2.03f, 9.11f, 0.28f);
                break;
            case 14: // LEVEL IV - x2
                target.transform.position = new Vector3(15.0f, 0.2f, 21.0f);
                break;
            case 15: // LEVEL IV - x3
                target.transform.position = new Vector3(-21.0f, 0.2f, -15.0f);
                break;
            case 16: // LEVEL IV - x4
                target.transform.position = new Vector3(21.0f, 0.2f, -15.0f);
                break;
            case 17: // LEVEL IV - x5
                target.transform.position = new Vector3(21.0f, 0.2f, 3.0f);
                break;
            case 18: // LEVEL IV - x6
                target.transform.position = new Vector3(-15.0f, 0.2f, 3.0f);
                break;
            case 19: // LEVEL IV - x7
                target.transform.position = new Vector3(-3.0f, 0.2f, -9.0f);
                break;
            case 20: // LEVEL V - x1
                queen.transform.position = new Vector3(3.0f, 0.0f, -21.0f);
                target.SetActive(true);
                target.transform.position = new Vector3(-3.0f, 0.2f, -21.0f);
                cameraRig.transform.position = queen.transform.position + new Vector3(0.0f, 10.0f, -20.0f);
                break;
            case 21: // LEVEL V - x2
                target.transform.position = new Vector3(21.0f, 0.2f, -21.0f);
                break;
            case 22: // LEVEL V - x3
                target.transform.position = new Vector3(21.0f, 0.2f, -3.0f);
                break;
            case 23: // LEVEL V - x4
                target.transform.position = new Vector3(9.0f, 0.2f, -15.0f);
                break;
            case 24: // LEVEL V - x5
                target.transform.position = new Vector3(9.0f, 0.2f, 9.0f);
                break;
            case 25: // LEVEL V - x6
                target.transform.position = new Vector3(-21.0f, 0.2f, 9.0f);
                break;
            case 26: // LEVEL V - x7
                target.transform.position = new Vector3(15.0f, 0.2f, 9.0f);
                break;
            case 27: // LEVEL V - x8
                target.transform.position = new Vector3(15.0f, 0.2f, 21.0f);
                break;
        }
    }

    public void clicked_queen(GameObject queenNum)
    {
        objectQueen = queenNum;
        count_spheres = 0;
        verifyPossibilities_bishop(queenNum);
        verifyPossibilities_tower(queenNum, queenNum.transform.position.x, 1);
        verifyPossibilities_tower(queenNum, queenNum.transform.position.z, 2);
        count_spheres = 0;
        cameraRig.transform.position = target.transform.position + new Vector3(0.0f, 20.0f, 0.0f);
        cameraRig.transform.rotation = new Quaternion(90.0f, 0.0f, 0.0f, 180.0f);
    }

    private void verifyPossibilities_tower(GameObject towerNum, float positionAxis, int axis)
    {
        int i = -21;
        while (i < 22)
        {
            if (positionAxis != i)
            {
                showDirections_tower(towerNum, axis, i);
            }
            i = i + 6;
        }
    }

    private void verifyPossibilities_bishop(GameObject queenNum)
    {
        int i = (int)queenNum.transform.position.x;
        int j = (int)queenNum.transform.position.z;
        while (i < 21 && j < 21)
        {
            i = i + 6;
            j = j + 6;
            showDirections_bishop(i, j);
        }

        i = (int)queenNum.transform.position.x;
        j = (int)queenNum.transform.position.z;
        while (i > -21 && j < 21)
        {
            i = i - 6;
            j = j + 6;
            showDirections_bishop(i, j);
        }

        i = (int)queenNum.transform.position.x;
        j = (int)queenNum.transform.position.z;
        while (i < 21 && j > -21)
        {
            i = i + 6;
            j = j - 6;
            showDirections_bishop(i, j);
        }

        i = (int)queenNum.transform.position.x;
        j = (int)queenNum.transform.position.z;
        while (i > -21 && j > -21)
        {
            i = i - 6;
            j = j - 6;
            showDirections_bishop(i, j);
        }
    }

    private void introduce27spheres()
    {
        while (count_spheres < 27)
        {
            count_spheres++;
            spheres.Add("sphere" + count_spheres, createSphere());
            spheres["sphere" + count_spheres].SetActive(false);
        }
        spheres_introduced = true;
    }

    private GameObject createSphere()
    {
        GameObject sphere_aux;
        sphere_aux = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere_aux.GetComponent<Renderer>().material.color = Color.red;
        sphere_aux.GetComponent<SphereCollider>().enabled = true;
        sphere_aux.AddComponent<ChangeColor>().enabled = true;
        sphere_aux.AddComponent<EventTrigger>().enabled = true;

        EventTrigger trigger = sphere_aux.GetComponent<EventTrigger>();
        EventTrigger.Entry entry_click = new EventTrigger.Entry();
        entry_click.eventID = EventTriggerType.PointerClick;
        entry_click.callback.AddListener((data) => {
            sphere_aux.GetComponent<ChangeColor>().Red();
            Move_queen(sphere_aux);
        });
        trigger.triggers.Add(entry_click);

        EventTrigger.Entry entry_enter = new EventTrigger.Entry();
        entry_enter.eventID = EventTriggerType.PointerEnter;
        entry_enter.callback.AddListener((data) => {
            sphere_aux.GetComponent<ChangeColor>().Green();
        });
        trigger.triggers.Add(entry_enter);

        EventTrigger.Entry entry_exit = new EventTrigger.Entry();
        entry_exit.eventID = EventTriggerType.PointerExit;
        entry_exit.callback.AddListener((data) => {
            sphere_aux.GetComponent<ChangeColor>().Red();
        });
        trigger.triggers.Add(entry_exit);

        return sphere_aux;
    }

    private void showDirections_tower(GameObject towerNum, int axis, float pos)
    {
        count_spheres++;
        spheres["sphere" + count_spheres].SetActive(true);
        if (axis == 1)
        {
            spheres["sphere" + count_spheres].transform.position = new Vector3(pos, 3.0f, towerNum.transform.position.z);
        }
        else if (axis == 2)
        {
            spheres["sphere" + count_spheres].transform.position = new Vector3(towerNum.transform.position.x, 3.0f, pos);
        }
        spheres["sphere" + count_spheres].transform.localScale = new Vector3(3, 3, 3);
    }

    private void showDirections_bishop(int axisX, int axisZ)
    {
        count_spheres++;
        spheres["sphere" + count_spheres].SetActive(true);
        spheres["sphere" + count_spheres].transform.position = new Vector3(axisX, 3.0f, axisZ);
        spheres["sphere" + count_spheres].transform.localScale = new Vector3(3, 3, 3);
    }

    public void Move_queen(GameObject queenDirection)
    {
        objectQueen.transform.position = queenDirection.transform.position;
        DeleteArrows_queen();
        checkTarget_queen();
    }

    private void DeleteArrows_queen()
    {
        for (int j = 1; j < 28; j++)
        {
            spheres["sphere" + j].SetActive(false);
        }
    }

    public void beginQueen()
    {
        buttonLevels.SetActive(false);
        back2pieces.SetActive(false);
    }

    public void showLevels_queen()
    {
        buttonLevels.SetActive(true);
        buttonPieces.SetActive(false);
        back2scenes.SetActive(false);
        back2pieces.SetActive(true);
        if (spheres_introduced)
        {
            DeleteArrows_queen();
        }
        target.SetActive(false);
        cameraRig.transform.position = new Vector3(2.03f, 9.11f, -32.28f);
        cameraRig.transform.rotation = new Quaternion(0.0f, 0.0f, 0.0f, 0.0f);
        queen.transform.position = new Vector3(-21.0f, 0.0f, 21.0f);
    }

    public void endGame_queen()
    {
        DeleteArrows_queen();
        buttonLevels.SetActive(false);
        queen.SetActive(false);
        buttonPieces.SetActive(true);
        back2scenes.SetActive(true);
        back2pieces.SetActive(false);
        target.SetActive(false);
        cameraRig.transform.position = new Vector3(2.03f, 9.11f, -32.28f);
    }
}
