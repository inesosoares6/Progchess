using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class KingScript2 : MonoBehaviour
{
    private GameObject objectKing;
    public GameObject king;
    public GameObject buttonPieces;
    public GameObject buttonLevels;
    private GameObject target;
    public GameObject back2scenes;
    public GameObject back2pieces;
    private int level;
    public AudioSource rightAnswer;
    public AudioSource levelUp;
    private int count_squares = 0;
    Dictionary<string, GameObject> squares = new Dictionary<string, GameObject>();
    private bool squares_introduced = false;

    private void Start()
    {
        introduce8squares();
        count_squares = 0;
        createTarget();
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
                king.transform.position = new Vector3(0.625f, 0.0f, -4.375f);
                target.SetActive(true);
                target.transform.position = new Vector3(-0.625f, 0.1f, -0.625f);
                break;
            case 2: // LEVEL II - x1
                king.transform.position = new Vector3(0.625f, 0.0f, -4.375f);
                target.SetActive(true);
                target.transform.position = new Vector3(0.625f, 0.1f, -3.125f);
                break;
            case 3: // LEVEL II - x2
                target.transform.position = new Vector3(0.625f, 0.1f, -1.875f);
                break;
            case 4: // LEVEL II - x3
                target.transform.position = new Vector3(-0.625f, 0.1f, -1.875f);
                break;
            case 5: // LEVEL II - x4
                target.transform.position = new Vector3(-1.875f, 0.1f, -3.125f);
                break;
            case 6: // LEVEL III - x1
                king.transform.position = new Vector3(0.625f, 0.0f, 0.625f);
                target.SetActive(true);
                target.transform.position = new Vector3(-0.625f, 0.1f, 1.875f);
                break;
            case 7: // LEVEL III - x2
                target.transform.position = new Vector3(-1.875f, 0.1f, 0.625f);
                break;
            case 8: // LEVEL III - x3
                target.transform.position = new Vector3(-3.125f, 0.1f, 0.625f);
                break;
            case 9: // LEVEL III - x4
                target.transform.position = new Vector3(0.625f, 0.1f, -3.125f);
                break;
            case 10: // LEVEL III - x5
                target.transform.position = new Vector3(1.875f, 0.1f, -3.125f);
                break;
            case 11: // LEVEL IV - x1
                king.transform.position = new Vector3(-1.875f, 0.0f, -3.125f);
                target.SetActive(true);
                target.transform.position = new Vector3(-0.625f, 0.1f, -0.625f);
                break;
            case 12: // LEVEL IV - x2
                target.transform.position = new Vector3(0.625f, 0.1f, 0.625f);
                break;
            case 13: // LEVEL IV - x3
                target.transform.position = new Vector3(1.875f, 0.1f, 1.875f);
                break;
            case 14: // LEVEL IV - x4
                target.transform.position = new Vector3(1.875f, 0.1f, 0.625f);
                break;
            case 15: // LEVEL IV - x5
                target.transform.position = new Vector3(4.375f, 0.1f, 3.125f);
                break;
            case 16: // LEVEL V - x1
                king.transform.position = new Vector3(-3.125f, 0.0f, -3.125f);
                target.SetActive(true);
                target.transform.position = new Vector3(-1.875f, 0.1f, -0.625f);
                break;
            case 17: // LEVEL V - x2
                target.transform.position = new Vector3(-3.125f, 0.1f, -0.625f);
                break;
            case 18: // LEVEL V - x3
                target.transform.position = new Vector3(-4.375f, 0.1f, 1.875f);
                break;
            case 19: // LEVEL V - x4
                target.transform.position = new Vector3(-4.375f, 0.1f, 3.125f);
                break;
            case 20: // LEVEL V - x5
                target.transform.position = new Vector3(-1.875f, 0.1f, 3.125f);
                break;
            case 21: // LEVEL V - x6
                target.transform.position = new Vector3(-0.625f, 0.1f, 3.125f);
                break;
        }
    }

    public void clicked_king(GameObject kingNum)
    {
        objectKing = kingNum;
        count_squares = 0;
        showDirections_king(kingNum);
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

    private void createTarget()
    {
        target = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        target.GetComponent<Renderer>().material.color = Color.red;
        target.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
        target.SetActive(false);
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
            Move_king(square_aux);
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

    private void showDirections_king(GameObject king)
    {
        List<Vector3> possibilities = new List<Vector3>();
        possibilities.Add(new Vector3(1.25f, 0.0101f, 1.25f));
        possibilities.Add(new Vector3(1.25f, 0.0101f, 0.00f));
        possibilities.Add(new Vector3(1.25f, 0.0101f, -1.25f));
        possibilities.Add(new Vector3(0.00f, 0.0101f, -1.25f));
        possibilities.Add(new Vector3(-1.25f, 0.0101f, -1.25f));
        possibilities.Add(new Vector3(-1.25f, 0.0101f, -0.00f));
        possibilities.Add(new Vector3(-1.25f, 0.0101f, 1.25f));
        possibilities.Add(new Vector3(0.00f, 0.0101f, 1.25f));

        Vector3 aux;
        for (int i = 0; i < 8; i++)
        {
            aux = king.transform.position + possibilities[i];
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

    public void Move_king(GameObject kingDirection)
    {
        objectKing.transform.position = kingDirection.transform.position;
        DeleteSquares_king();
        checkTarget_king();
    }

    private void DeleteSquares_king()
    {
        for (int j = 1; j < 9; j++)
        {
            squares["square" + j].SetActive(false);
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
        if (squares_introduced)
        {
            DeleteSquares_king();
        }
        target.SetActive(false);
        king.transform.position = new Vector3(-4.375f, 0.0f, 4.375f);
    }

    public void endGame_king()
    {
        buttonLevels.SetActive(false);
        king.SetActive(false);
        buttonPieces.SetActive(true);
        back2scenes.SetActive(true);
        back2pieces.SetActive(false);
    }
}
