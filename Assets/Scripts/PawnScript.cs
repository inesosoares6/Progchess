using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PawnScript : MonoBehaviour
{
    private GameObject objectPawn;
    public GameObject pawn;
    public GameObject pawn2;
    public GameObject pawn3;
    public GameObject pawn4;
    public GameObject cameraRig;
    public GameObject buttonPieces;
    public GameObject buttonLevels;
    public GameObject target;
    public GameObject target2;
    public GameObject target3;
    public GameObject target4;
    public GameObject target5;
    public GameObject back2scenes;
    public GameObject back2pieces;
    private bool firstMove = true;
    private int level;
    public AudioSource rightAnswer;
    public AudioSource levelUp;
    private int count_spheres = 0;
    Dictionary<string, GameObject> spheres = new Dictionary<string, GameObject>();
    private bool spheres_introduced = false;

    private void Start()
    {
        introduce3spheres();
        count_spheres = 0;
    }

    public void defineLevel_pawn(int num)
    {
        level = num;
        beginPawn();
        moveTarget_pawn(level);
    }

    private void checkTarget_pawn()
    {
        if (level == 14 && target_level14())
        {
            levelUp.Play(0);
            showLevels_pawn();
            target2.SetActive(false);
            target3.SetActive(false);
            target4.SetActive(false);
            target5.SetActive(false);
            pawn2.SetActive(false);
            pawn3.SetActive(false);
            pawn4.SetActive(false);
        }
        else if (pawn.transform.position.x == target.transform.position.x && pawn.transform.position.z == target.transform.position.z)
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
            else if (level == 13)
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
    }

    private bool target_level14()
    {
        // TODO check targets
        return false;
    }

    private void moveTarget_pawn(int levelNum)
    {
        switch (levelNum)
        {
            case 1: // LEVEL I - x1
                firstMove = true;
                pawn.transform.position = new Vector3(-9.0f, 0.0f, -15.0f);
                target.SetActive(true);
                target.transform.position = new Vector3(-15.0f, 0.2f, -3.0f);
                cameraRig.transform.position = new Vector3(-2.03f, 9.11f, -32.28f);
                break;
            case 2: // LEVEL I - x2
                firstMove = false;
                target.transform.position = new Vector3(-9.0f, 0.2f, 3.0f);
                break;
            case 3: // LEVEL I - x3
                target.transform.position = new Vector3(-15.0f, 0.2f, 9.0f);
                break;
            case 4: // LEVEL II - x1
                firstMove = true;
                pawn.transform.position = new Vector3(-15.0f, 0.0f, -15.0f);
                target.SetActive(true);
                target.transform.position = new Vector3(-9.0f, 0.2f, -9.0f);
                cameraRig.transform.position = pawn.transform.position + new Vector3(0.0f, 10.0f, -20.0f);
                break;
            case 5: // LEVEL II - x2
                firstMove = false;
                target.transform.position = new Vector3(-3.0f, 0.2f, 3.0f);
                break;
            case 6: // LEVEL II - x3
                target.transform.position = new Vector3(-9.0f, 0.2f, 9.0f);
                break;
            case 7: // LEVEL II - x4
                target.transform.position = new Vector3(-3.0f, 0.2f, 21.0f);
                break;
            case 8: // LEVEL III - x1
                firstMove = true;
                pawn.transform.position = new Vector3(-3.0f, 0.0f, -9.0f);
                target.SetActive(true);
                target.transform.position = new Vector3(-9.0f, 0.2f, -3.0f);
                cameraRig.transform.position = pawn.transform.position + new Vector3(0.0f, 10.0f, -20.0f);
                break;
            case 9: // LEVEL III - x2
                firstMove = false;
                target.transform.position = new Vector3(-3.0f, 0.2f, 3.0f);
                break;
            case 10: // LEVEL III - x3
                target.transform.position = new Vector3(3.0f, 0.2f, 9.0f);
                break;
            case 11: // LEVEL III - x4
                target.transform.position = new Vector3(-3.0f, 0.2f, 15.0f);
                break;
            case 12: // LEVEL III - x5
                target.transform.position = new Vector3(-9.0f, 0.2f, 21.0f);
                break;
            // --------------- 4 pawns // 5 targets ---------------------------
            case 13: // LEVEL IV - x1
                firstMove = true;
                pawn2.SetActive(true);
                pawn3.SetActive(true);
                pawn4.SetActive(true);
                pawn.transform.position = new Vector3(-21.0f, 0.0f, -15.0f);
                pawn2.transform.position = new Vector3(-9.0f, 0.0f, -15.0f);
                pawn3.transform.position = new Vector3(-3.0f, 0.0f, -15.0f);
                pawn4.transform.position = new Vector3(21.0f, 0.0f, -15.0f);
                target.SetActive(true);
                target2.SetActive(true);
                target3.SetActive(true);
                target4.SetActive(true);
                target5.SetActive(true);
                target.transform.position = new Vector3(-15.0f, 0.2f, -3.0f);
                target2.transform.position = new Vector3(-9.0f, 0.2f, -3.0f);
                target3.transform.position = new Vector3(3.0f, 0.2f, -3.0f);
                target4.transform.position = new Vector3(15.0f, 0.2f, -9.0f);
                target5.transform.position = new Vector3(-3.0f, 0.2f, -9.0f);
                cameraRig.transform.position = new Vector3(-2.03f, 9.11f, -32.28f);
                break;
            case 14: // LEVEL V - x1
                firstMove = true;
                pawn.transform.position = new Vector3(3.0f, 0.0f, -15.0f);
                target.SetActive(true);
                target.transform.position = new Vector3(-3.0f, 0.2f, 9.0f);
                cameraRig.transform.position = pawn.transform.position + new Vector3(0.0f, 10.0f, -20.0f);
                break;
        }
    }

    public void clicked_pawn(GameObject pawnNum)
    {
        objectPawn = pawnNum;
        count_spheres = 0;
        verifyPossibilities_pawn(pawnNum);
        count_spheres = 0;
        cameraRig.transform.position = pawnNum.transform.position + new Vector3(0.0f, 20.0f, 0.0f);
        cameraRig.transform.rotation = new Quaternion(90.0f, 0.0f, 0.0f, 180.0f);
    }

    private void verifyPossibilities_pawn(GameObject pawnNum)
    {
        if (target.transform.position.z != pawnNum.transform.position.z + 6 && target.transform.position.x != pawn.transform.position.x)
        {
            showDirections_pawn(pawn.transform.position.x, pawn.transform.position.z + 6);
            if (target.transform.position.z != pawnNum.transform.position.z + 12 && target.transform.position.x != pawn.transform.position.x && firstMove)
            {
                showDirections_pawn(pawn.transform.position.x, pawn.transform.position.z + 12);
            }
        }
        if (target.transform.position.z == pawnNum.transform.position.z + 6 && target.transform.position.x == pawn.transform.position.x + 6)
        {
            showDirections_pawn(pawn.transform.position.x + 6, pawn.transform.position.z + 6);
        }
        if (target.transform.position.z == pawnNum.transform.position.z + 6 && target.transform.position.x == pawn.transform.position.x - 6)
        {
            showDirections_pawn(pawn.transform.position.x - 6, pawn.transform.position.z + 6);
        }
    }

    private void introduce3spheres()
    {
        while (count_spheres < 3)
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
            Move_pawn(sphere_aux);
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

    private void showDirections_pawn(float axisX, float axisZ)
    {
        count_spheres++;
        spheres["sphere" + count_spheres].SetActive(true);
        spheres["sphere" + count_spheres].transform.position = new Vector3(axisX, 3.0f, axisZ);
        spheres["sphere" + count_spheres].transform.localScale = new Vector3(3, 3, 3);
    }

    public void Move_pawn(GameObject pawnDirection)
    {
        objectPawn.transform.position = pawnDirection.transform.position;
        DeleteArrows_pawn();
        checkTarget_pawn();
    }

    private void DeleteArrows_pawn()
    {
        for (int j = 1; j < 4; j++)
        {
            spheres["sphere" + j].SetActive(false);
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
        if (spheres_introduced)
        {
            DeleteArrows_pawn();
        }
        target.SetActive(false);
        cameraRig.transform.position = new Vector3(2.03f, 9.11f, -32.28f);
        cameraRig.transform.rotation = new Quaternion(0.0f, 0.0f, 0.0f, 0.0f);
        pawn.transform.position = new Vector3(-21.0f, 0.0f, 21.0f);
    }

    public void endGame_pawn()
    {
        DeleteArrows_pawn();
        buttonLevels.SetActive(false);
        pawn.SetActive(false);
        buttonPieces.SetActive(true);
        back2scenes.SetActive(true);
        back2pieces.SetActive(false);
        target.SetActive(false);
        cameraRig.transform.position = new Vector3(2.03f, 9.11f, -32.28f);
    }
}
