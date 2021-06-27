using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BishopScript : MonoBehaviour
{
    private GameObject objectBishop;
    public GameObject bishop;
    public GameObject bishop2;
    public GameObject cameraRig;
    public GameObject buttonPieces;
    public GameObject buttonLevels;
    public GameObject target;
    public GameObject target2;
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
        introduce14spheres();
        count_spheres = 0;
    }

    public void defineLevel_bishop(int num)
    {
        level = num;
        beginBishop();
        moveTarget_bishop(level);
    }

    private void checkTarget_bishop()
    {
        if (bishop2.transform.position.x == target2.transform.position.x && bishop2.transform.position.z == target2.transform.position.z && bishop.transform.position.x == target.transform.position.x && bishop.transform.position.z == target.transform.position.z && level > 17)
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
        else if (bishop.transform.position.x == target.transform.position.x && bishop.transform.position.z == target.transform.position.z && level < 18)
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
        else if (bishop2.transform.position.x == target2.transform.position.x && bishop2.transform.position.z == target2.transform.position.z && level > 17)
        {
            cameraRig.transform.position = bishop.transform.position + new Vector3(0.0f, 20.0f, 0.0f);
            cameraRig.transform.rotation = new Quaternion(90.0f, 0.0f, 0.0f, 180.0f);
        }
        else if (bishop.transform.position.x == target.transform.position.x && bishop.transform.position.z == target.transform.position.z && level > 17)
        {
            cameraRig.transform.position = bishop2.transform.position + new Vector3(0.0f, 20.0f, 0.0f);
            cameraRig.transform.rotation = new Quaternion(90.0f, 0.0f, 0.0f, 180.0f);
        }
    }

    private void moveTarget_bishop(int levelNum)
    {
        switch (levelNum)
        {
            case 1: // LEVEL I - x1
                bishop.transform.position = new Vector3(-9.0f, 0.0f, -21.0f);
                target.SetActive(true);
                target2.SetActive(false);
                target.transform.position = new Vector3(-15.0f, 0.2f, -15.0f);
                cameraRig.transform.position = new Vector3(-2.03f, 9.11f, -32.28f);
                break;
            case 2: // LEVEL I - x2
                target.transform.position = new Vector3(-21.0f, 0.2f, -9.0f);
                break;
            case 3: // LEVEL I - x3
                target.transform.position = new Vector3(-9.0f, 0.2f, 3.0f);
                break;
            case 4: // LEVEL I - x4
                target.transform.position = new Vector3(3.0f, 0.2f, -9.0f);
                break;
            case 5: // LEVEL I - x5
                target.transform.position = new Vector3(15.0f, 0.2f, -21.0f);
                break;
            case 6: // LEVEL II - x1
                bishop.transform.position = new Vector3(-3.0f, 0.0f, -3.0f);
                target.SetActive(true);
                target2.SetActive(false);
                target.transform.position = new Vector3(-15.0f, 0.2f, 9.0f);
                cameraRig.transform.position = bishop.transform.position + new Vector3(0.0f, 10.0f, -20.0f);
                break;
            case 7: // LEVEL II - x2
                target.transform.position = new Vector3(3.0f, 0.2f, -9.0f);
                break;
            case 8: // LEVEL II - x3
                target.transform.position = new Vector3(-9.0f, 0.2f, -21.0f);
                break;
            case 9: // LEVEL II - x4
                target.transform.position = new Vector3(21.0f, 0.2f, 9.0f);
                break;
            case 10: // LEVEL II - x5
                target.transform.position = new Vector3(15.0f, 0.2f, 15.0f);
                break;
            case 11: // LEVEL II - x6
                target.transform.position = new Vector3(-21.0f, 0.2f, -21.0f);
                break;
            case 12: // LEVEL III - x1
                bishop.transform.position = new Vector3(-9.0f, 0.0f, -3.0f);
                target.SetActive(true);
                target2.SetActive(false);
                target.transform.position = new Vector3(-15.0f, 0.2f, -9.0f);
                cameraRig.transform.position = bishop.transform.position + new Vector3(0.0f, 10.0f, -20.0f);
                break;
            case 13: // LEVEL III - x2
                target.transform.position = new Vector3(-21.0f, 0.2f, -3.0f);
                break;
            case 14: // LEVEL III - x3
                target.transform.position = new Vector3(-9.0f, 0.2f, -15.0f);
                break;
            case 15: // LEVEL III - x4
                target.transform.position = new Vector3(-15.0f, 0.2f, -21.0f);
                break;
            case 16: // LEVEL III - x5
                target.transform.position = new Vector3(-3.0f, 0.2f, -9.0f);
                break;
            case 17: // LEVEL III - x6
                target.transform.position = new Vector3(3.0f, 0.2f, -15.0f);
                break;
            // --------------- 2 bishops // 2 targets ---------------------------
            case 18: // LEVEL IV - x1
                bishop2.SetActive(true);
                bishop.SetActive(true);
                bishop2.transform.position = new Vector3(9.0f, 0.0f, -21.0f);
                bishop.transform.position = new Vector3(-9.0f, 0.0f, -21.0f);
                target.SetActive(true);
                target2.SetActive(true);
                target.transform.position = new Vector3(3.0f, 0.2f, -9.0f);
                target2.transform.position = new Vector3(-3.0f, 0.2f, -9.0f);
                cameraRig.transform.position = new Vector3(-2.03f, 9.11f, -32.28f);
                break;
            case 19: // LEVEL IV - x2
                target.transform.position = new Vector3(-3.0f, 0.2f, -3.0f);
                target2.transform.position = new Vector3(3.0f, 0.2f, -3.0f);
                break;
            case 20: // LEVEL IV - x3
                target.transform.position = new Vector3(3.0f, 0.2f, 3.0f);
                target2.transform.position = new Vector3(-3.0f, 0.2f, 3.0f);
                break;
            case 21: // LEVEL V - x1
                bishop2.SetActive(true);
                bishop.SetActive(true);
                bishop.transform.position = new Vector3(-3.0f, 0.0f, 15.0f);
                bishop2.transform.position = new Vector3(-9.0f, 0.0f, -9.0f);
                target.SetActive(true);
                target2.SetActive(true);
                target.transform.position = new Vector3(9.0f, 0.2f, 3.0f);
                target2.transform.position = new Vector3(9.0f, 0.2f, 9.0f);
                cameraRig.transform.position = bishop.transform.position + new Vector3(0.0f, 10.0f, -20.0f);
                break;
            case 22: // LEVEL V - x2
                target.transform.position = new Vector3(-9.0f, 0.2f, -15.0f);
                target2.transform.position = new Vector3(21.0f, 0.2f, -3.0f);
                break;
            case 23: // LEVEL V - x3
                target.transform.position = new Vector3(21.0f, 0.2f, 15.0f);
                target2.transform.position = new Vector3(3.0f, 0.2f, 15.0f);
                break;
            case 24: // LEVEL V - x4
                target.transform.position = new Vector3(15.0f, 0.2f, 21.0f);
                target2.transform.position = new Vector3(-21.0f, 0.2f, -9.0f);
                break;
        }
    }

    public void clicked_bishop(GameObject bishopNum)
    {
        objectBishop = bishopNum;
        count_spheres = 0;
        verifyPossibilities_bishop(bishopNum);
        count_spheres = 0;
        if (bishopNum == bishop)
        {
            cameraRig.transform.position = target.transform.position + new Vector3(0.0f, 20.0f, 0.0f);
        }
        else if (bishopNum == bishop2)
        {
            cameraRig.transform.position = target2.transform.position + new Vector3(0.0f, 20.0f, 0.0f);
        }
        cameraRig.transform.rotation = new Quaternion(90.0f, 0.0f, 0.0f, 180.0f);
    }

    private void verifyPossibilities_bishop(GameObject bishopNum)
    {
        int i = (int) bishopNum.transform.position.x;
        int j = (int) bishopNum.transform.position.z;
        while (i < 21 && j < 21)
        {
            i = i + 6;
            j = j + 6;
            showDirections_bishop(i, j);
        }

        i = (int)bishopNum.transform.position.x;
        j = (int)bishopNum.transform.position.z;
        while (i > -21 && j < 21)
        {
            i = i - 6;
            j = j + 6;
            showDirections_bishop(i, j);
        }

        i = (int)bishopNum.transform.position.x;
        j = (int)bishopNum.transform.position.z;
        while (i < 21 && j > -21)
        {
            i = i + 6;
            j = j - 6;
            showDirections_bishop(i, j);
        }

        i = (int)bishopNum.transform.position.x;
        j = (int)bishopNum.transform.position.z;
        while (i > -21 && j > -21)
        {
            i = i - 6;
            j = j - 6;
            showDirections_bishop(i, j);
        }
    }

    private void introduce14spheres()
    {
        while (count_spheres < 14)
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
            Move_bishop(sphere_aux);
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

    private void showDirections_bishop(int axisX, int axisZ)
    {
        count_spheres++;
        spheres["sphere" + count_spheres].SetActive(true);
        spheres["sphere" + count_spheres].transform.position = new Vector3(axisX, 3.0f, axisZ);
        spheres["sphere" + count_spheres].transform.localScale = new Vector3(3, 3, 3);
    }

    public void Move_bishop(GameObject towerDirection)
    {
        objectBishop.transform.position = towerDirection.transform.position;
        DeleteArrows_bishop();
        checkTarget_bishop();
    }

    private void DeleteArrows_bishop()
    {
        for (int j = 1; j < 15; j++)
        {
            spheres["sphere" + j].SetActive(false);
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
        if (spheres_introduced)
        {
            DeleteArrows_bishop();
        }
        target.SetActive(false);
        target2.SetActive(false);
        bishop2.SetActive(false);
        cameraRig.transform.position = new Vector3(2.03f, 9.11f, -32.28f);
        cameraRig.transform.rotation = new Quaternion(0.0f, 0.0f, 0.0f, 0.0f);
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
        target.SetActive(false);
        target2.SetActive(false);
        cameraRig.transform.position = new Vector3(2.03f, 9.11f, -32.28f);
    }
}
