using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class KingScript : MonoBehaviour
{
    private GameObject objectKing;
    public GameObject king;
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
        introduce8spheres();
        count_spheres = 0;
    }

    public void defineLevel_king(int num)
    {
        level = num;
        beginKing();
        moveTarget_king(level);
    }

    private void checkTarget_king()
    {
        if (king.transform.position.x == target.transform.position.x && king.transform.position.z == target.transform.position.z)
        {
            if (level == 1)
            {
                showLevels_king();
                levelUp.Play(0);
            }
            else if (level == 5)
            {
                levelUp.Play(0);
                showLevels_king();
            }
            else if (level == 10)
            {
                levelUp.Play(0);
                showLevels_king();
            }
            else if (level == 15)
            {
                levelUp.Play(0);
                showLevels_king();
            }
            else if (level == 21)
            {
                levelUp.Play(0);
                showLevels_king();
            }
            else
            {
                rightAnswer.Play(0);
                level++;
                moveTarget_king(level);
            }
        }
    }

    private void moveTarget_king(int levelNum)
    {
        switch (levelNum)
        {
            case 1: // LEVEL I - x1
                king.transform.position = new Vector3(3.0f, 0.0f, -21.0f);
                target.SetActive(true);
                target.transform.position = new Vector3(-3.0f, 0.2f, -3.0f);
                cameraRig.transform.position = new Vector3(-2.03f, 9.11f, -32.28f);
                break;
            case 2: // LEVEL II - x1
                king.transform.position = new Vector3(3.0f, 0.0f, -21.0f);
                target.SetActive(true);
                target.transform.position = new Vector3(3.0f, 0.2f, -15.0f);
                cameraRig.transform.position = king.transform.position + new Vector3(0.0f, 10.0f, -20.0f);
                break;
            case 3: // LEVEL II - x2
                target.transform.position = new Vector3(3.0f, 0.2f, -9.0f);
                break;
            case 4: // LEVEL II - x3
                target.transform.position = new Vector3(-3.0f, 0.2f, -9.0f);
                break;
            case 5: // LEVEL II - x4
                target.transform.position = new Vector3(-9.0f, 0.2f, -15.0f);
                break;
            case 6: // LEVEL III - x1
                king.transform.position = new Vector3(3.0f, 0.0f, 3.0f);
                target.SetActive(true);
                target.transform.position = new Vector3(-3.0f, 0.2f, 9.0f);
                cameraRig.transform.position = king.transform.position + new Vector3(0.0f, 10.0f, -20.0f);
                break;
            case 7: // LEVEL III - x2
                target.transform.position = new Vector3(-9.0f, 0.2f, 3.0f);
                break;
            case 8: // LEVEL III - x3
                target.transform.position = new Vector3(-15.0f, 0.2f, 3.0f);
                break;
            case 9: // LEVEL III - x4
                target.transform.position = new Vector3(3.0f, 0.2f, -15.0f);
                break;
            case 10: // LEVEL III - x5
                target.transform.position = new Vector3(9.0f, 0.2f, -15.0f);
                break;
            case 11: // LEVEL IV - x1
                king.transform.position = new Vector3(-9.0f, 0.0f, -15.0f);
                target.SetActive(true);
                target.transform.position = new Vector3(-3.0f, 0.2f, -3.0f);
                cameraRig.transform.position = new Vector3(-2.03f, 9.11f, -32.28f);
                break;
            case 12: // LEVEL IV - x2
                target.transform.position = new Vector3(3.0f, 0.2f, 3.0f);
                break;
            case 13: // LEVEL IV - x3
                target.transform.position = new Vector3(9.0f, 0.2f, 9.0f);
                break;
            case 14: // LEVEL IV - x4
                target.transform.position = new Vector3(9.0f, 0.2f, 3.0f);
                break;
            case 15: // LEVEL IV - x5
                target.transform.position = new Vector3(21.0f, 0.2f, 15.0f);
                break;
            case 16: // LEVEL V - x1
                king.transform.position = new Vector3(-15.0f, 0.0f, -15.0f);
                target.SetActive(true);
                target.transform.position = new Vector3(-9.0f, 0.2f, -3.0f);
                cameraRig.transform.position = king.transform.position + new Vector3(0.0f, 10.0f, -20.0f);
                break;
            case 17: // LEVEL V - x2
                target.transform.position = new Vector3(-15.0f, 0.2f, -3.0f);
                break;
            case 18: // LEVEL V - x3
                target.transform.position = new Vector3(-21.0f, 0.2f, 9.0f);
                break;
            case 19: // LEVEL V - x4
                target.transform.position = new Vector3(-21.0f, 0.2f, 15.0f);
                break;
            case 20: // LEVEL V - x5
                target.transform.position = new Vector3(-9.0f, 0.2f, 15.0f);
                break;
            case 21: // LEVEL V - x6
                target.transform.position = new Vector3(-3.0f, 0.2f, 15.0f);
                break;
        }
    }

    public void clicked_king(GameObject kingNum)
    {
        objectKing = kingNum;
        count_spheres = 0;
        verifyPossibilities_king(kingNum);
        count_spheres = 0;
        cameraRig.transform.position = kingNum.transform.position + new Vector3(0.0f, 20.0f, 0.0f);
        cameraRig.transform.rotation = new Quaternion(90.0f, 0.0f, 0.0f, 180.0f);
    }

    private void verifyPossibilities_king(GameObject kingNum)
    {
        if(kingNum.transform.position.x < 21 && kingNum.transform.position.x > -21 && kingNum.transform.position.z < 21 && kingNum.transform.position.z > -21)
        {
            showDirections_king(kingNum.transform.position.x, kingNum.transform.position.z + 6);
            showDirections_king(kingNum.transform.position.x, kingNum.transform.position.z - 6);
            showDirections_king(kingNum.transform.position.x + 6, kingNum.transform.position.z);
            showDirections_king(kingNum.transform.position.x - 6, kingNum.transform.position.z);
            showDirections_king(kingNum.transform.position.x + 6, kingNum.transform.position.z + 6);
            showDirections_king(kingNum.transform.position.x - 6, kingNum.transform.position.z - 6);
            showDirections_king(kingNum.transform.position.x + 6, kingNum.transform.position.z - 6);
            showDirections_king(kingNum.transform.position.x - 6, kingNum.transform.position.z + 6);
        }
        else if(kingNum.transform.position.x == 21 && kingNum.transform.position.x > -22 && kingNum.transform.position.z < 22 && kingNum.transform.position.z > -22)
        {
            showDirections_king(kingNum.transform.position.x, kingNum.transform.position.z + 6);
            showDirections_king(kingNum.transform.position.x, kingNum.transform.position.z - 6);
            showDirections_king(kingNum.transform.position.x - 6, kingNum.transform.position.z);
            showDirections_king(kingNum.transform.position.x - 6, kingNum.transform.position.z - 6);
            showDirections_king(kingNum.transform.position.x - 6, kingNum.transform.position.z + 6);
        }
        else if (kingNum.transform.position.x < 21 && kingNum.transform.position.x == -21 && kingNum.transform.position.z < 22 && kingNum.transform.position.z > -22)
        {
            showDirections_king(kingNum.transform.position.x, kingNum.transform.position.z + 6);
            showDirections_king(kingNum.transform.position.x, kingNum.transform.position.z - 6);
            showDirections_king(kingNum.transform.position.x + 6, kingNum.transform.position.z);
            showDirections_king(kingNum.transform.position.x + 6, kingNum.transform.position.z - 6);
            showDirections_king(kingNum.transform.position.x + 6, kingNum.transform.position.z + 6);
        }
        else if (kingNum.transform.position.x < 21 && kingNum.transform.position.x > -21 && kingNum.transform.position.z == 21 && kingNum.transform.position.z > -21)
        {
            showDirections_king(kingNum.transform.position.x, kingNum.transform.position.z - 6);
            showDirections_king(kingNum.transform.position.x + 6, kingNum.transform.position.z);
            showDirections_king(kingNum.transform.position.x - 6, kingNum.transform.position.z);
            showDirections_king(kingNum.transform.position.x - 6, kingNum.transform.position.z - 6);
            showDirections_king(kingNum.transform.position.x + 6, kingNum.transform.position.z - 6);
        }
        else if (kingNum.transform.position.x < 21 && kingNum.transform.position.x > -21 && kingNum.transform.position.z < 21 && kingNum.transform.position.z == -21)
        {
            showDirections_king(kingNum.transform.position.x, kingNum.transform.position.z + 6);
            showDirections_king(kingNum.transform.position.x + 6, kingNum.transform.position.z);
            showDirections_king(kingNum.transform.position.x - 6, kingNum.transform.position.z);
            showDirections_king(kingNum.transform.position.x + 6, kingNum.transform.position.z + 6);
            showDirections_king(kingNum.transform.position.x - 6, kingNum.transform.position.z + 6);
        }
    }

    private void introduce8spheres()
    {
        while (count_spheres < 8)
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
            Move_king(sphere_aux);
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

    private void showDirections_king(float axisX, float axisZ)
    {
        count_spheres++;
        spheres["sphere" + count_spheres].SetActive(true);
        spheres["sphere" + count_spheres].transform.position = new Vector3(axisX, 3.0f, axisZ);
        spheres["sphere" + count_spheres].transform.localScale = new Vector3(3, 3, 3);
    }

    public void Move_king(GameObject kingDirection)
    {
        objectKing.transform.position = kingDirection.transform.position;
        DeleteArrows_king();
        checkTarget_king();
    }

    private void DeleteArrows_king()
    {
        for (int j = 1; j < 9; j++)
        {
            spheres["sphere" + j].SetActive(false);
        }
    }

    public void beginKing()
    {
        buttonLevels.SetActive(false);
        back2pieces.SetActive(false);
    }

    public void showLevels_king()
    {
        buttonLevels.SetActive(true);
        buttonPieces.SetActive(false);
        back2scenes.SetActive(false);
        back2pieces.SetActive(true);
        if (spheres_introduced)
        {
            DeleteArrows_king();
        }
        target.SetActive(false);
        cameraRig.transform.position = new Vector3(2.03f, 9.11f, -32.28f);
        cameraRig.transform.rotation = new Quaternion(0.0f, 0.0f, 0.0f, 0.0f);
        king.transform.position = new Vector3(-21.0f, 0.0f, 21.0f);
    }

    public void endGame_king()
    {
        DeleteArrows_king();
        buttonLevels.SetActive(false);
        king.SetActive(false);
        buttonPieces.SetActive(true);
        back2scenes.SetActive(true);
        back2pieces.SetActive(false);
        target.SetActive(false);
        cameraRig.transform.position = new Vector3(2.03f, 9.11f, -32.28f);
    }
}
