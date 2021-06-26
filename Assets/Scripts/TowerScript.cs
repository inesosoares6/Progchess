using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TowerScript : MonoBehaviour
{
    private GameObject objectTower;
    public GameObject tower;
    public GameObject tower2;
    public GameObject cameraRig;
    public GameObject chessBoard;
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

    public void defineLevel_tower(int num)
    {
        level = num;
        beginTower();
        moveTarget_tower(level);
    }

    private void checkTarget_tower()
    {
        if (tower2.transform.position.x == target2.transform.position.x && tower2.transform.position.z == target2.transform.position.z && tower.transform.position.x == target.transform.position.x && tower.transform.position.z == target.transform.position.z && level > 10)
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
        else if (tower.transform.position.x == target.transform.position.x && tower.transform.position.z == target.transform.position.z && level < 11)
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
        else if (tower2.transform.position.x == target2.transform.position.x && tower2.transform.position.z == target2.transform.position.z && level > 10)
        {
            cameraRig.transform.position = tower.transform.position + new Vector3(0.0f, 20.0f, 0.0f);
            cameraRig.transform.rotation = new Quaternion(90.0f, 0.0f, 0.0f, 180.0f);
        }
        else if (tower.transform.position.x == target.transform.position.x && tower.transform.position.z == target.transform.position.z && level > 10)
        {
            cameraRig.transform.position = tower2.transform.position + new Vector3(0.0f, 20.0f, 0.0f);
            cameraRig.transform.rotation = new Quaternion(90.0f, 0.0f, 0.0f, 180.0f);
        }
    }

    private void moveTarget_tower(int levelNum)
    {
        switch (levelNum)
        {
            case 1: // LEVEL I - x1
                tower.transform.position = new Vector3(-21.0f, 0.0f, -21.0f);
                target.SetActive(true);
                target2.SetActive(false);
                target.transform.position = new Vector3(-21.0f, 0.2f, 9.0f);
                cameraRig.transform.position = new Vector3(-2.03f, 9.11f, -32.28f);
                break;
            case 2: // LEVEL I - x2
                target.transform.position = new Vector3(3.0f, 0.2f, 9.0f);
                break;
            case 3: // LEVEL II - x1
                tower.transform.position = new Vector3(-3.0f, 0.0f, -3.0f);
                target.SetActive(true);
                target2.SetActive(false);
                target.transform.position = new Vector3(-21.0f, 0.2f, -3.0f);
                cameraRig.transform.position = tower.transform.position + new Vector3(0.0f, 10.0f, -20.0f);
                break;
            case 4: // LEVEL II - x2
                target.transform.position = new Vector3(15.0f, 0.2f, -3.0f);
                break;
            case 5: // LEVEL II - x3
                target.transform.position = new Vector3(15.0f, 0.2f, -9.0f);
                break;
            case 6: // LEVEL III - x1
                tower.transform.position = new Vector3(21.0f, 0.0f, 21.0f);
                target.SetActive(true);
                target2.SetActive(false);
                target.transform.position = new Vector3(21.0f, 0.2f, 15.0f);
                cameraRig.transform.position = tower.transform.position + new Vector3(0.0f, 10.0f, -20.0f);
                break;
            case 7: // LEVEL III - x2
                target.transform.position = new Vector3(15.0f, 0.2f, 15.0f);
                break;
            case 8: // LEVEL III - x3
                target.transform.position = new Vector3(15.0f, 0.2f, -21.0f);
                break;
            case 9: // LEVEL III - x4
                target.transform.position = new Vector3(15.0f, 0.2f, 21.0f);
                break;
            case 10: // LEVEL III - x5
                target.transform.position = new Vector3(9.0f, 0.2f, 21.0f);
                break;
            // --------------- 2 towers // 2 targets ---------------------------
            case 11: // LEVEL IV - x1
                tower2.SetActive(true);
                tower.SetActive(true);
                tower2.transform.position = new Vector3(-3.0f, 0.0f, -3.0f);
                tower.transform.position = new Vector3(-15.0f, 0.0f, 15.0f);
                target.SetActive(true);
                target2.SetActive(true);
                target.transform.position = new Vector3(15.0f, 0.2f, 15.0f);
                target2.transform.position = new Vector3(21.0f, 0.2f, -3.0f);
                cameraRig.transform.position = new Vector3(0.0f, 20.0f, 0.0f);
                cameraRig.transform.rotation = new Quaternion(90.0f, 0.0f, 0.0f, 180.0f);
                break;
            case 12: // LEVEL IV - x2
                target.transform.position = new Vector3(15.0f, 0.2f, -9.0f);
                target2.transform.position = new Vector3(-21.0f, 0.2f, -3.0f);
                break;
            case 13: // LEVEL V - x1
                tower2.SetActive(true);
                tower.SetActive(true);
                tower.transform.position = new Vector3(-21.0f, 0.0f, -21.0f);
                tower2.transform.position = new Vector3(9.0f, 0.0f, -9.0f);
                target.SetActive(true);
                target2.SetActive(true);
                target.transform.position = new Vector3(-3.0f, 0.2f, -21.0f);
                target2.transform.position = new Vector3(9.0f, 0.2f, -15.0f);
                cameraRig.transform.position = tower.transform.position + new Vector3(0.0f, 10.0f, -20.0f);
                break;
            case 14: // LEVEL V - x2
                target.transform.position = new Vector3(-3.0f, 0.2f, 3.0f);
                target2.transform.position = new Vector3(9.0f, 0.2f, 15.0f);
                break;
            case 15: // LEVEL V - x3
                target.transform.position = new Vector3(15.0f, 0.2f, -3.0f);
                target2.transform.position = new Vector3(-15.0f, 0.2f, 15.0f);
                break;
            case 16: // LEVEL V - x4
                target.transform.position = new Vector3(15.0f, 0.2f, 15.0f);
                break;
        }
    }

    public void clicked_tower(GameObject towerNum)
    {
        objectTower = towerNum;
        count_spheres = 0;
        verifyPossibilities_tower(towerNum, towerNum.transform.position.x, 1);
        verifyPossibilities_tower(towerNum, towerNum.transform.position.z, 2);
        count_spheres = 0;
        if (towerNum == tower)
        {
            cameraRig.transform.position = target.transform.position + new Vector3(0.0f, 20.0f, 0.0f);
        }
        else if (towerNum == tower2)
        {
            cameraRig.transform.position = target2.transform.position + new Vector3(0.0f, 20.0f, 0.0f);
        }
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
            Move_tower(sphere_aux);
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

    private void showDirections_tower(GameObject towerNum, int axis, float pos)
    {
        count_spheres++;
        spheres["sphere" + count_spheres].SetActive(true);
        if (axis == 1)
        {
            spheres["sphere"+ count_spheres].transform.position = new Vector3(pos, 3.0f, towerNum.transform.position.z);
        }
        else if (axis == 2)
        {
            spheres["sphere" + count_spheres].transform.position = new Vector3(towerNum.transform.position.x, 3.0f, pos);
        }
        spheres["sphere" + count_spheres].transform.localScale = new Vector3(3, 3, 3);
    }

    public void Move_tower(GameObject towerDirection)
    {
        objectTower.transform.position = towerDirection.transform.position;
        DeleteArrows_tower();
        checkTarget_tower();
    }

    private void DeleteArrows_tower()
    {
        for(int j=1; j < 15; j++)
        {
            spheres["sphere" + j].SetActive(false);
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
        if (spheres_introduced)
        {
            DeleteArrows_tower();
        }
        target.SetActive(false);
        target2.SetActive(false);
        tower2.SetActive(false);
        cameraRig.transform.position = new Vector3(2.03f, 9.11f, -32.28f);
        cameraRig.transform.rotation = new Quaternion(0.0f, 0.0f, 0.0f, 0.0f);
    }

    public void endGame_tower()
    {
        DeleteArrows_tower();
        buttonLevels.SetActive(false);
        tower.SetActive(false);
        tower2.SetActive(false);
        buttonPieces.SetActive(true);
        back2scenes.SetActive(true);
        back2pieces.SetActive(false);
        target.SetActive(false);
        target2.SetActive(false);
        cameraRig.transform.position = new Vector3(2.03f, 9.11f, -32.28f);
    }
}