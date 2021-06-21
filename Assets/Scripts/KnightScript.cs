using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightScript : MonoBehaviour
{
    public GameObject knight;
    public GameObject cameraRig;
    public GameObject chessBoard;
    public GameObject buttonKnight;
    public GameObject buttonPawn;
    public GameObject buttonKing;
    public GameObject buttonBishop;
    public GameObject buttonQueen;
    public GameObject buttonTower;
    public GameObject sphere1;
    public GameObject sphere2;
    public GameObject sphere3;
    public GameObject sphere4;
    public GameObject sphere5;
    public GameObject sphere6;
    public GameObject sphere7;
    public GameObject sphere8;
    public GameObject back2scenes;
    public GameObject back2pieces;

    private void Start()
    {
        knight.transform.position = new Vector3(15.0f, 0.0f, -21.0f);
    }

    public void clicked()
    {
        verifyPossibilities();
        Debug.Log(knight.transform.position);
    }

    private void verifyPossibilities()
    {
        if (knight.transform.position.z >= -9 && knight.transform.position.z <= 9 && knight.transform.position.x <= 9 && knight.transform.position.x >= -9)
        {
            // every directions possible
            showDirections(true, true, true, true, true, true, true, true);
        }
        else if (knight.transform.position.z >= 21)
        {
            // 1, 8, 2 and 7 not possible
            if (knight.transform.position.x <= -21)
            {
                // 6 and 5 not possible
                showDirections(false, false, true, true, false, false, false, false);
            }
            else if (knight.transform.position.x <= -15)
            {
                // 6 not possible
                showDirections(false, false, true, true, true, false, false, false);
            }
            else if (knight.transform.position.x >= 21)
            {
                // 3 and 4 not possible
                showDirections(false, false, false, false, true, true, false, false);
            }
            else if (knight.transform.position.x >= 15)
            {
                // 3 not possible
                showDirections(false, false, false, true, true, true, false, false);
            }
            else
            {
                showDirections(false, false, true, true, true, true, false, false);
            }
        }
        else if (knight.transform.position.z >= 15)
        {
            // 1 and 8 not possible
            if(knight.transform.position.x <= -21)
            {
                // 7, 6, and 5 not possible
                showDirections(false, true, true, true, false, false, false, false);
            } 
            else if (knight.transform.position.x <= -15)
            {
                // 3 and 2 not possible
                showDirections(false, false, false, true, true, true, true, false);
            } else if (knight.transform.position.x >= 21)
            {
                // 2, 3, and 4 not possible
                showDirections(false, false, false, false, true, true, true, false);
            }
            else if (knight.transform.position.x >= 15)
            {
                // 2 and 3 not possible
                showDirections(false, false, false, true, true, true, true, false);
            }
            else
            {
                showDirections(false, true, true, true, true, true, true, false);
            }
        }
        else if (knight.transform.position.z <= -21)
        {
            // 3, 4, 5 and 6 not possible
            if (knight.transform.position.x <= -21)
            {
                // 7 and 8 not possible
                showDirections(true, true, false, false, false, false, false, false);
            }
            else if (knight.transform.position.x <= -15)
            {
                // 7 not possible
                showDirections(true, true, false, false, false, false, false, true);
            }
            else if (knight.transform.position.x >= 21)
            {
                // 1 and 2 not possible
                showDirections(false, false, false, false, false, false, true, true);
            }
            else if (knight.transform.position.x >= 15)
            {
                // 2 not possible
                showDirections(true, false, false, false, false, false, true, true);
            }
            else
            {
                showDirections(true, true, false, false, false, false, true, true);
            }
        }
        else if (knight.transform.position.z <= -15)
        {
            // 4 and 5 not possible
            if (knight.transform.position.x <= -21)
            {
                // 6, 7 and 8 not possible
                showDirections(true, true, true, false, false, false, false, false);
            }
            else if (knight.transform.position.x <= -15)
            {
                // 6 and 7 not possible
                showDirections(true, true, true, false, false, false, false, true);
            }
            else if (knight.transform.position.x >= 21)
            {
                // 1, 2 and 3 not possible
                showDirections(false, false, false, false, false, true, true, true);
            }
            else if (knight.transform.position.x >= 15)
            {
                // 2 and 3 not possible
                showDirections(true, false, false, false, false, true, true, true);
            }
            else
            {
                showDirections(true, true, true, false, false, true, true, true);
            }
        }
        else
        {
            if (knight.transform.position.x <= -21)
            {
                // 5, 6, 7 and 8 not possible
                showDirections(true, true, true, true, false, false, false, false);
            }
            else if (knight.transform.position.x <= -15)
            {
                // 6 and 7 not possible
                showDirections(true, true, true, true, true, false, false, true);
            }
            else if (knight.transform.position.x >= 21)
            {
                // 1, 2, 3 and 4 not possible
                showDirections(false, false, false, false, true, true, true, true);
            }
            else if (knight.transform.position.x >= 15)
            {
                // 2 and 3 not possible
                showDirections(true, false, false, true, true, true, true, true);
            }
            else
            {
                showDirections(true, true, true, true, false, false, false, false);
            }
        }
    }

    private void showDirections(bool opt1, bool opt2, bool opt3, bool opt4, bool opt5, bool opt6, bool opt7, bool opt8)
    {
        if (opt1)
        {
            sphere1.SetActive(true);
            sphere1.transform.position = knight.transform.position + new Vector3(6.0f, 3.0f, 12.0f);
            sphere1.transform.localScale = new Vector3(3, 3, 3);
        }

        if (opt2)
        {
            sphere2.SetActive(true);
            sphere2.transform.position = knight.transform.position + new Vector3(12.0f, 3.0f, 6.0f);
            sphere2.transform.localScale = new Vector3(3, 3, 3);
        }

        if (opt3)
        {
            sphere3.SetActive(true);
            sphere3.transform.position = knight.transform.position + new Vector3(12.0f, 3.0f, -6.0f);
            sphere3.transform.localScale = new Vector3(3, 3, 3);
        }

        if (opt4)
        {
            sphere4.SetActive(true);
            sphere4.transform.position = knight.transform.position + new Vector3(6.0f, 3.0f, -12.0f);
            sphere4.transform.localScale = new Vector3(3, 3, 3);
        }

        if (opt5)
        {
            sphere5.SetActive(true);
            sphere5.transform.position = knight.transform.position + new Vector3(-6.0f, 3.0f, -12.0f);
            sphere5.transform.localScale = new Vector3(3, 3, 3);
        }

        if (opt6)
        {
            sphere6.SetActive(true);
            sphere6.transform.position = knight.transform.position + new Vector3(-12.0f, 3.0f, -6.0f);
            sphere6.transform.localScale = new Vector3(3, 3, 3);
        }

        if (opt7)
        {
            sphere7.SetActive(true);
            sphere7.transform.position = knight.transform.position + new Vector3(-12.0f, 3.0f, 6.0f);
            sphere7.transform.localScale = new Vector3(3, 3, 3);
        }

        if (opt8)
        {
            sphere8.SetActive(true);
            sphere8.transform.position = knight.transform.position + new Vector3(-6.0f, 3.0f, 12.0f);
            sphere8.transform.localScale = new Vector3(3, 3, 3);
        }

        cameraRig.transform.position = knight.transform.position + new Vector3(0.0f, 20.0f, 0.0f);
        cameraRig.transform.rotation = new Quaternion(90.0f, 0.0f, 0.0f, 180.0f);
        back2pieces.transform.position = cameraRig.transform.position + new Vector3(10.0f, 10.0f, 10.0f);
    }

    public void Move_Right_Front_Front() // #1
    {
        knight.transform.position = knight.transform.position + new Vector3(6.0f, 0.0f, 0.0f);
        knight.transform.position = knight.transform.position + new Vector3(0.0f, 0.0f, 6.0f);
        knight.transform.position = knight.transform.position + new Vector3(0.0f, 0.0f, 6.0f);
        DeleteArrows();
    }

    public void Move_Left_Front_Front() // #8
    {
        knight.transform.position = knight.transform.position + new Vector3(-6.0f, 0.0f, 0.0f);
        knight.transform.position = knight.transform.position + new Vector3(0.0f, 0.0f, 6.0f);
        knight.transform.position = knight.transform.position + new Vector3(0.0f, 0.0f, 6.0f);
        DeleteArrows();
    }

    public void Move_Right_Right_Front() // #2
    {
        knight.transform.position = knight.transform.position + new Vector3(6.0f, 0.0f, 0.0f);
        knight.transform.position = knight.transform.position + new Vector3(6.0f, 0.0f, 0.0f);
        knight.transform.position = knight.transform.position + new Vector3(0.0f, 0.0f, 6.0f);
        DeleteArrows();
    }

    public void Move_Right_Right_Back() // #3
    {
        knight.transform.position = knight.transform.position + new Vector3(6.0f, 0.0f, 0.0f);
        knight.transform.position = knight.transform.position + new Vector3(6.0f, 0.0f, 0.0f);
        knight.transform.position = knight.transform.position + new Vector3(0.0f, 0.0f, -6.0f);
        DeleteArrows();
    }
    public void Move_Right_Back_Back() // #4
    {
        knight.transform.position = knight.transform.position + new Vector3(6.0f, 0.0f, 0.0f);
        knight.transform.position = knight.transform.position + new Vector3(0.0f, 0.0f, -6.0f);
        knight.transform.position = knight.transform.position + new Vector3(0.0f, 0.0f, -6.0f);
        DeleteArrows();
    }
    public void Move_Left_Back_Back() // #5
    {
        knight.transform.position = knight.transform.position + new Vector3(-6.0f, 0.0f, 0.0f);
        knight.transform.position = knight.transform.position + new Vector3(0.0f, 0.0f, -6.0f);
        knight.transform.position = knight.transform.position + new Vector3(0.0f, 0.0f, -6.0f);
        DeleteArrows();
    }
    public void Move_Left_Left_Back() // #6
    {
        knight.transform.position = knight.transform.position + new Vector3(-6.0f, 0.0f, 0.0f);
        knight.transform.position = knight.transform.position + new Vector3(-6.0f, 0.0f, 0.0f);
        knight.transform.position = knight.transform.position + new Vector3(0.0f, 0.0f, -6.0f);
        DeleteArrows();
    }
    public void Move_Left_Left_Front() // #7
    {
        knight.transform.position = knight.transform.position + new Vector3(-6.0f, 0.0f, 0.0f);
        knight.transform.position = knight.transform.position + new Vector3(-6.0f, 0.0f, 0.0f);
        knight.transform.position = knight.transform.position + new Vector3(0.0f, 0.0f, 6.0f);
        DeleteArrows();
    }

    private void DeleteArrows()
    {
        sphere1.SetActive(false);
        sphere2.SetActive(false);
        sphere3.SetActive(false);
        sphere4.SetActive(false);
        sphere5.SetActive(false);
        sphere6.SetActive(false);
        sphere7.SetActive(false);
        sphere8.SetActive(false);
    }

    public void beginKnight()
    {
        knight.SetActive(true);
        buttonKnight.SetActive(false);
        buttonBishop.SetActive(false);
        buttonKing.SetActive(false);
        buttonQueen.SetActive(false);
        buttonTower.SetActive(false);
        buttonPawn.SetActive(false);
        back2scenes.SetActive(false);
        back2pieces.SetActive(true);
    }

    public void endGame()
    {
        DeleteArrows();
        knight.SetActive(false);
        buttonKnight.SetActive(true);
        buttonBishop.SetActive(true);
        buttonKing.SetActive(true);
        buttonQueen.SetActive(true);
        buttonTower.SetActive(true);
        buttonPawn.SetActive(true);
        back2scenes.SetActive(true);
        back2pieces.SetActive(false);
    }
}
