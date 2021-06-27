using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightScript : MonoBehaviour
{
    public GameObject knight;
    public GameObject cameraRig;
    public GameObject buttonPieces;
    public GameObject buttonLevels;
    public GameObject sphere1;
    public GameObject sphere2;
    public GameObject sphere3;
    public GameObject sphere4;
    public GameObject sphere5;
    public GameObject sphere6;
    public GameObject sphere7;
    public GameObject sphere8;
    public GameObject target;
    public GameObject back2scenes;
    public GameObject back2pieces;
    private int level;
    public AudioSource rightAnswer;
    public AudioSource levelUp;

    public void defineLevel_knight(int num)
    {
        level = num;
        beginKnight();
        moveTarget_knight(level);
    }

    private void checkTarget_knight()
    {
        if(knight.transform.position.x == target.transform.position.x && knight.transform.position.z == target.transform.position.z)
        {
            if(level == 7)
            {
                showLevels_knight();
                levelUp.Play(0);
            }
            else if(level == 12)
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
                knight.transform.position = new Vector3(-15.0f, 0.0f, -21.0f);
                target.SetActive(true);
                target.transform.position = new Vector3(-9.0f, 0.2f, -9.0f);
                cameraRig.transform.position = new Vector3(2.03f, 9.11f, -32.28f);
                break;
            case 2: // LEVEL I - x2
                target.transform.position = new Vector3(3.0f, 0.2f, -15.0f);
                break;
            case 3: // LEVEL I - x3
                target.transform.position = new Vector3(-3.0f, 0.2f, -3.0f);
                break;
            case 4: // LEVEL I - x4
                target.transform.position = new Vector3(9.0f, 0.2f, -9.0f);
                break;
            case 5: // LEVEL I - x5
                target.transform.position = new Vector3(15.0f, 0.2f, 3.0f);
                break;
            case 6: // LEVEL I - x6
                target.transform.position = new Vector3(9.0f, 0.2f, 15.0f);
                break;
            case 7: // LEVEL I - x7
                target.transform.position = new Vector3(21.0f, 0.2f, 21.0f);
                break;
            case 8: // LEVEL II - x1
                knight.transform.position = new Vector3(-9.0f, 0.0f, 15.0f);
                target.SetActive(true);
                target.transform.position = new Vector3(3.0f, 0.2f, 9.0f);
                cameraRig.transform.position = knight.transform.position + new Vector3(0.0f, 10.0f, -20.0f);
                break;
            case 9: // LEVEL II - x2
                target.transform.position = new Vector3(9.0f, 0.2f, -3.0f);
                break;
            case 10: // LEVEL II - x3
                target.transform.position = new Vector3(-3.0f, 0.2f, 3.0f);
                break;
            case 11: // LEVEL II - x4
                target.transform.position = new Vector3(-15.0f, 0.2f, 9.0f);
                break;
            case 12: // LEVEL II - x5
                target.transform.position = new Vector3(-3.0f, 0.2f, 15.0f);
                break;
            case 13: // LEVEL III - x1
                knight.transform.position = new Vector3(9.0f, 0.0f, -3.0f);
                target.SetActive(true);
                target.transform.position = new Vector3(15.0f, 0.2f, -9.0f);
                cameraRig.transform.position = knight.transform.position + new Vector3(0.0f, 10.0f, -20.0f);
                break;
            case 14: // LEVEL III - x2
                target.transform.position = new Vector3(9.0f, 0.2f, 3.0f);
                break;
            case 15: // LEVEL III - x3
                target.transform.position = new Vector3(3.0f, 0.2f, -9.0f);
                break;
            case 16: // LEVEL III - x4
                target.transform.position = new Vector3(15.0f, 0.2f, -3.0f);
                break;
            case 17: // LEVEL III - x5
                target.transform.position = new Vector3(3.0f, 0.2f, 3.0f);
                break;
            case 18: // LEVEL III - x6
                target.transform.position = new Vector3(9.0f, 0.2f, -9.0f);
                break;
            case 19: // LEVEL III - x7
                target.transform.position = new Vector3(15.0f, 0.2f, 3.0f);
                break;
            case 20: // LEVEL III - x8
                target.transform.position = new Vector3(3.0f, 0.2f, -3.0f);
                break;
            case 21: // LEVEL IV - x1
                knight.transform.position = new Vector3(-3.0f, 0.0f, -9.0f);
                target.SetActive(true);
                target.transform.position = new Vector3(9.0f, 0.2f, -15.0f);
                cameraRig.transform.position = knight.transform.position + new Vector3(0.0f, 10.0f, -20.0f);
                break;
            case 22: // LEVEL IV - x2
                target.transform.position = new Vector3(3.0f, 0.2f, -3.0f);
                break;
            case 23: // LEVEL IV - x3
                target.transform.position = new Vector3(-9.0f, 0.2f, -9.0f);
                break;
            case 24: // LEVEL IV - x4
                target.transform.position = new Vector3(3.0f, 0.2f, -15.0f);
                break;
            case 25: // LEVEL IV - x5
                target.transform.position = new Vector3(9.0f, 0.2f, -3.0f);
                break;
            case 26: // LEVEL IV - x6
                target.transform.position = new Vector3(15.0f, 0.2f, 9.0f);
                break;
            case 27: // LEVEL V - x1
                knight.transform.position = new Vector3(-9.0f, 0.0f, 15.0f);
                target.SetActive(true);
                target.transform.position = new Vector3(-15.0f, 0.2f, 3.0f);
                cameraRig.transform.position = knight.transform.position + new Vector3(0.0f, 10.0f, -20.0f);
                break;
            case 28: // LEVEL V - x2
                target.transform.position = new Vector3(-3.0f, 0.2f, -3.0f);
                break;
            case 29: // LEVEL V - x3
                target.transform.position = new Vector3(9.0f, 0.2f, 3.0f);
                break;
            case 30: // LEVEL V - x4
                target.transform.position = new Vector3(3.0f, 0.2f, -9.0f);
                break;
            case 31: // LEVEL V - x5
                target.transform.position = new Vector3(-3.0f, 0.2f, 3.0f);
                break;
            case 32: // LEVEL V - x6
                target.transform.position = new Vector3(-15.0f, 0.2f, -3.0f);
                break;
            case 33: // LEVEL V - x7
                target.transform.position = new Vector3(-9.0f, 0.2f, 9.0f);
                break;
            case 34: // LEVEL V - x8
                target.transform.position = new Vector3(3.0f, 0.2f, 15.0f);
                break;
            case 35: // LEVEL V - x9
                target.transform.position = new Vector3(-9.0f, 0.2f, 21.0f);
                break;
        }
    }

    public void clicked_knight()
    {
        verifyPossibilities_knight();
    }

    private void verifyPossibilities_knight()
    {
        if (knight.transform.position.z >= -9 && knight.transform.position.z <= 9 && knight.transform.position.x <= 9 && knight.transform.position.x >= -9)
        {
            // every directions possible
            showDirections_knight(true, true, true, true, true, true, true, true);
        }
        else if (knight.transform.position.z >= 21)
        {
            // 1, 8, 2 and 7 not possible
            if (knight.transform.position.x <= -21)
            {
                // 6 and 5 not possible
                showDirections_knight(false, false, true, true, false, false, false, false);
            }
            else if (knight.transform.position.x <= -15)
            {
                // 6 not possible
                showDirections_knight(false, false, true, true, true, false, false, false);
            }
            else if (knight.transform.position.x >= 21)
            {
                // 3 and 4 not possible
                showDirections_knight(false, false, false, false, true, true, false, false);
            }
            else if (knight.transform.position.x >= 15)
            {
                // 3 not possible
                showDirections_knight(false, false, false, true, true, true, false, false);
            }
            else
            {
                showDirections_knight(false, false, true, true, true, true, false, false);
            }
        }
        else if (knight.transform.position.z >= 15)
        {
            // 1 and 8 not possible
            if(knight.transform.position.x <= -21)
            {
                // 7, 6, and 5 not possible
                showDirections_knight(false, true, true, true, false, false, false, false);
            } 
            else if (knight.transform.position.x <= -15)
            {
                // 3 and 2 not possible
                showDirections_knight(false, false, false, true, true, true, true, false);
            } else if (knight.transform.position.x >= 21)
            {
                // 2, 3, and 4 not possible
                showDirections_knight(false, false, false, false, true, true, true, false);
            }
            else if (knight.transform.position.x >= 15)
            {
                // 2 and 3 not possible
                showDirections_knight(false, false, false, true, true, true, true, false);
            }
            else
            {
                showDirections_knight(false, true, true, true, true, true, true, false);
            }
        }
        else if (knight.transform.position.z <= -21)
        {
            // 3, 4, 5 and 6 not possible
            if (knight.transform.position.x <= -21)
            {
                // 7 and 8 not possible
                showDirections_knight(true, true, false, false, false, false, false, false);
            }
            else if (knight.transform.position.x <= -15)
            {
                // 7 not possible
                showDirections_knight(true, true, false, false, false, false, false, true);
            }
            else if (knight.transform.position.x >= 21)
            {
                // 1 and 2 not possible
                showDirections_knight(false, false, false, false, false, false, true, true);
            }
            else if (knight.transform.position.x >= 15)
            {
                // 2 not possible
                showDirections_knight(true, false, false, false, false, false, true, true);
            }
            else
            {
                showDirections_knight(true, true, false, false, false, false, true, true);
            }
        }
        else if (knight.transform.position.z <= -15)
        {
            // 4 and 5 not possible
            if (knight.transform.position.x <= -21)
            {
                // 6, 7 and 8 not possible
                showDirections_knight(true, true, true, false, false, false, false, false);
            }
            else if (knight.transform.position.x <= -15)
            {
                // 6 and 7 not possible
                showDirections_knight(true, true, true, false, false, false, false, true);
            }
            else if (knight.transform.position.x >= 21)
            {
                // 1, 2 and 3 not possible
                showDirections_knight(false, false, false, false, false, true, true, true);
            }
            else if (knight.transform.position.x >= 15)
            {
                // 2 and 3 not possible
                showDirections_knight(true, false, false, false, false, true, true, true);
            }
            else
            {
                showDirections_knight(true, true, true, false, false, true, true, true);
            }
        }
        else
        {
            if (knight.transform.position.x <= -21)
            {
                // 5, 6, 7 and 8 not possible
                showDirections_knight(true, true, true, true, false, false, false, false);
            }
            else if (knight.transform.position.x <= -15)
            {
                // 6 and 7 not possible
                showDirections_knight(true, true, true, true, true, false, false, true);
            }
            else if (knight.transform.position.x >= 21)
            {
                // 1, 2, 3 and 4 not possible
                showDirections_knight(false, false, false, false, true, true, true, true);
            }
            else if (knight.transform.position.x >= 15)
            {
                // 2 and 3 not possible
                showDirections_knight(true, false, false, true, true, true, true, true);
            }
            else
            {
                showDirections_knight(true, true, true, true, false, false, false, false);
            }
        }
    }

    private void showDirections_knight(bool opt1, bool opt2, bool opt3, bool opt4, bool opt5, bool opt6, bool opt7, bool opt8)
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
    }

    public void Move_Right_Front_Front() // #1
    {
        knight.transform.position = knight.transform.position + new Vector3(6.0f, 0.0f, 0.0f);
        knight.transform.position = knight.transform.position + new Vector3(0.0f, 0.0f, 6.0f);
        knight.transform.position = knight.transform.position + new Vector3(0.0f, 0.0f, 6.0f);
        DeleteArrows_knight();
        checkTarget_knight();
    }

    public void Move_Left_Front_Front() // #8
    {
        knight.transform.position = knight.transform.position + new Vector3(-6.0f, 0.0f, 0.0f);
        knight.transform.position = knight.transform.position + new Vector3(0.0f, 0.0f, 6.0f);
        knight.transform.position = knight.transform.position + new Vector3(0.0f, 0.0f, 6.0f);
        DeleteArrows_knight();
        checkTarget_knight();
    }

    public void Move_Right_Right_Front() // #2
    {
        knight.transform.position = knight.transform.position + new Vector3(6.0f, 0.0f, 0.0f);
        knight.transform.position = knight.transform.position + new Vector3(6.0f, 0.0f, 0.0f);
        knight.transform.position = knight.transform.position + new Vector3(0.0f, 0.0f, 6.0f);
        DeleteArrows_knight();
        checkTarget_knight();
    }

    public void Move_Right_Right_Back() // #3
    {
        knight.transform.position = knight.transform.position + new Vector3(6.0f, 0.0f, 0.0f);
        knight.transform.position = knight.transform.position + new Vector3(6.0f, 0.0f, 0.0f);
        knight.transform.position = knight.transform.position + new Vector3(0.0f, 0.0f, -6.0f);
        DeleteArrows_knight();
        checkTarget_knight();
    }
    public void Move_Right_Back_Back() // #4
    {
        knight.transform.position = knight.transform.position + new Vector3(6.0f, 0.0f, 0.0f);
        knight.transform.position = knight.transform.position + new Vector3(0.0f, 0.0f, -6.0f);
        knight.transform.position = knight.transform.position + new Vector3(0.0f, 0.0f, -6.0f);
        DeleteArrows_knight();
        checkTarget_knight();
    }
    public void Move_Left_Back_Back() // #5
    {
        knight.transform.position = knight.transform.position + new Vector3(-6.0f, 0.0f, 0.0f);
        knight.transform.position = knight.transform.position + new Vector3(0.0f, 0.0f, -6.0f);
        knight.transform.position = knight.transform.position + new Vector3(0.0f, 0.0f, -6.0f);
        DeleteArrows_knight();
        checkTarget_knight();
    }
    public void Move_Left_Left_Back() // #6
    {
        knight.transform.position = knight.transform.position + new Vector3(-6.0f, 0.0f, 0.0f);
        knight.transform.position = knight.transform.position + new Vector3(-6.0f, 0.0f, 0.0f);
        knight.transform.position = knight.transform.position + new Vector3(0.0f, 0.0f, -6.0f);
        DeleteArrows_knight();
        checkTarget_knight();
    }
    public void Move_Left_Left_Front() // #7
    {
        knight.transform.position = knight.transform.position + new Vector3(-6.0f, 0.0f, 0.0f);
        knight.transform.position = knight.transform.position + new Vector3(-6.0f, 0.0f, 0.0f);
        knight.transform.position = knight.transform.position + new Vector3(0.0f, 0.0f, 6.0f);
        DeleteArrows_knight();
        checkTarget_knight();
    }

    private void DeleteArrows_knight()
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
        buttonLevels.SetActive(false);
        back2pieces.SetActive(false);
    }

    public void showLevels_knight()
    {
        buttonLevels.SetActive(true);
        buttonPieces.SetActive(false);
        back2scenes.SetActive(false);
        back2pieces.SetActive(true);
        DeleteArrows_knight();
        target.SetActive(false);
        cameraRig.transform.position = new Vector3(2.03f, 9.11f, -32.28f);
        cameraRig.transform.rotation = new Quaternion(0.0f, 0.0f, 0.0f, 0.0f);
    }

    public void endGame_knight()
    {
        DeleteArrows_knight();
        buttonLevels.SetActive(false);
        knight.SetActive(false);
        buttonPieces.SetActive(true);
        back2scenes.SetActive(true);
        back2pieces.SetActive(false);
        target.SetActive(false);
        cameraRig.transform.position = new Vector3(2.03f, 9.11f, -32.28f);
    }
}
