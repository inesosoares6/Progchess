using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class KnightScript2 : MonoBehaviour
{
    public GameObject knight;
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
    public GameObject board;

    private void Start()
    {
        introduce8squares();
        count_squares = 0;
        createTarget();
    }

    public void defineLevel_knight(int num)
    {
        level = num;
        beginKnight();
        moveTarget_knight(level);
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
            Move_knight(square_aux);
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

    private void createTarget()
    {
        target = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        target.GetComponent<Renderer>().material.color = Color.red;
        target.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
        target.SetActive(false);
    }

    private void checkTarget_knight()
    {
        if (knight.transform.position.x == target.transform.position.x && knight.transform.position.z == target.transform.position.z)
        {
            if (level == 7)
            {
                showLevels_knight();
                levelUp.Play(0);
            }
            else if (level == 12)
            {
                levelUp.Play(0);
                showLevels_knight();
            }
            else if (level == 20)
            {
                levelUp.Play(0);
                showLevels_knight();
            }
            else if (level == 26)
            {
                levelUp.Play(0);
                showLevels_knight();
            }
            else if (level == 35)
            {
                levelUp.Play(0);
                showLevels_knight();
            }
            else
            {
                rightAnswer.Play(0);
                level++;
                moveTarget_knight(level);
            }
        }
    }

    private void moveTarget_knight(int levelNum)
    {
        switch (levelNum)
        {
            case 1: // LEVEL I - x1
                knight.transform.position = new Vector3(-3.125f, 0.0f, -4.375f);
                target.SetActive(true);
                target.transform.position = new Vector3(-1.875f, 0.0f, -1.875f);
                break;
            case 2: // LEVEL I - x2
                target.transform.position = new Vector3(0.625f, 0.1f, -3.125f);
                break;
            case 3: // LEVEL I - x3
                target.transform.position = new Vector3(-0.625f, 0.1f, -0.625f);
                break;
            case 4: // LEVEL I - x4
                target.transform.position = new Vector3(1.875f, 0.1f, -1.875f);
                break;
            case 5: // LEVEL I - x5
                target.transform.position = new Vector3(3.125f, 0.1f, 0.625f);
                break;
            case 6: // LEVEL I - x6
                target.transform.position = new Vector3(1.875f, 0.1f, 3.125f);
                break;
            case 7: // LEVEL I - x7
                target.transform.position = new Vector3(4.375f, 0.1f, 4.375f);
                break;
            case 8: // LEVEL II - x1
                knight.transform.position = new Vector3(-1.875f, 0.0f, 3.125f);
                target.SetActive(true);
                target.transform.position = new Vector3(0.625f, 0.1f, 1.875f);
                break;
            case 9: // LEVEL II - x2
                target.transform.position = new Vector3(1.875f, 0.1f, -0.625f);
                break;
            case 10: // LEVEL II - x3
                target.transform.position = new Vector3(-0.625f, 0.1f, 0.625f);
                break;
            case 11: // LEVEL II - x4
                target.transform.position = new Vector3(-3.125f, 0.1f, 1.875f);
                break;
            case 12: // LEVEL II - x5
                target.transform.position = new Vector3(-0.625f, 0.1f, 3.125f);
                break;
            case 13: // LEVEL III - x1
                knight.transform.position = new Vector3(1.875f, 0.0f, -0.625f);
                target.SetActive(true);
                target.transform.position = new Vector3(3.125f, 0.1f, -1.875f);
                break;
            case 14: // LEVEL III - x2
                target.transform.position = new Vector3(1.875f, 0.1f, 0.625f);
                break;
            case 15: // LEVEL III - x3
                target.transform.position = new Vector3(0.625f, 0.1f, -1.875f);
                break;
            case 16: // LEVEL III - x4
                target.transform.position = new Vector3(3.125f, 0.1f, -0.625f);
                break;
            case 17: // LEVEL III - x5
                target.transform.position = new Vector3(0.625f, 0.1f, 0.625f);
                break;
            case 18: // LEVEL III - x6
                target.transform.position = new Vector3(1.875f, 0.1f, -1.875f);
                break;
            case 19: // LEVEL III - x7
                target.transform.position = new Vector3(3.125f, 0.1f, 0.625f);
                break;
            case 20: // LEVEL III - x8
                target.transform.position = new Vector3(0.625f, 0.1f, -0.625f);
                break;
            case 21: // LEVEL IV - x1
                knight.transform.position = new Vector3(-0.625f, 0.0f, -1.875f);
                target.SetActive(true);
                target.transform.position = new Vector3(1.875f, 0.1f, -3.125f);
                break;
            case 22: // LEVEL IV - x2
                target.transform.position = new Vector3(0.625f, 0.1f, -0.625f);
                break;
            case 23: // LEVEL IV - x3
                target.transform.position = new Vector3(-1.875f, 0.1f, -1.875f);
                break;
            case 24: // LEVEL IV - x4
                target.transform.position = new Vector3(0.625f, 0.1f, -3.125f);
                break;
            case 25: // LEVEL IV - x5
                target.transform.position = new Vector3(1.875f, 0.1f, -0.625f);
                break;
            case 26: // LEVEL IV - x6
                target.transform.position = new Vector3(3.125f, 0.1f, 1.875f);
                break;
            case 27: // LEVEL V - x1
                knight.transform.position = new Vector3(-1.875f, 0.0f, 3.125f);
                target.SetActive(true);
                target.transform.position = new Vector3(-3.125f, 0.1f, 0.625f);
                break;
            case 28: // LEVEL V - x2
                target.transform.position = new Vector3(-0.625f, 0.1f, -0.625f);
                break;
            case 29: // LEVEL V - x3
                target.transform.position = new Vector3(1.875f, 0.1f, 0.625f);
                break;
            case 30: // LEVEL V - x4
                target.transform.position = new Vector3(0.625f, 0.1f, -1.875f);
                break;
            case 31: // LEVEL V - x5
                target.transform.position = new Vector3(-0.625f, 0.1f, 0.625f);
                break;
            case 32: // LEVEL V - x6
                target.transform.position = new Vector3(-3.125f, 0.1f, -0.625f);
                break;
            case 33: // LEVEL V - x7
                target.transform.position = new Vector3(-1.875f, 0.1f, 1.875f);
                break;
            case 34: // LEVEL V - x8
                target.transform.position = new Vector3(0.625f, 0.1f, 3.125f);
                break;
            case 35: // LEVEL V - x9
                target.transform.position = new Vector3(-1.875f, 0.1f, 4.375f);
                break;
        }
    }

    public void clicked_knight()
    {
        count_squares = 0;
        showDirections_knight();
    }

    private void showDirections_knight()
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

    public void Move_knight(GameObject knightDirection)
    {
        knight.transform.position = knightDirection.transform.position;
        DeleteSquares_knight();
        checkTarget_knight();
    }

    private void DeleteSquares_knight()
    {
        for (int j = 1; j < 9; j++)
        {
            squares["square" + j].SetActive(false);
        }
    }

    public void beginKnight()
    {
        buttonLevels.SetActive(false);
        back2pieces.SetActive(false);
    }

    public void showLevels_knight()
    {
        buttonLevels.SetActive(true);
        buttonPieces.SetActive(false);
        back2scenes.SetActive(false);
        back2pieces.SetActive(true);
        if (squares_introduced)
        {
            DeleteSquares_knight();
            target.SetActive(false);
        }
        knight.transform.position = new Vector3(-4.375f, 0.0f, 4.375f);
    }

    public void endGame_knight()
    {
        buttonLevels.SetActive(false);
        knight.SetActive(false);
        buttonPieces.SetActive(true);
        back2scenes.SetActive(true);
        back2pieces.SetActive(false);
        board.SetActive(false);
    }
}
