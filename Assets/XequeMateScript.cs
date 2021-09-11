using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class XequeMateScript : MonoBehaviour
{
    private int level;
    public GameObject buttonLevels;
    public GameObject back2pieces;
    public GameObject back2scenes;
    public GameObject buttonPieces;
    public AudioSource levelUp;
    public void defineLevel_xequemate(int num)
    {
        level = num;
        beginXequeMate();
        moveTarget_xequemate(level);
    }

    private void moveTarget_xequemate(int level)
    {
        throw new NotImplementedException();
    }

    public void showLevels_xequemate()
    {
        buttonLevels.SetActive(true);
        buttonPieces.SetActive(false);
        back2scenes.SetActive(false);
        back2pieces.SetActive(true);
        //if (squares_introduced)
        //{
        //    DeleteSquares_tower();
        //    targets["target1"].SetActive(false);
        //    targets["target2"].SetActive(false);
        //}
        //tower2.SetActive(false);
        //tower.transform.position = new Vector3(-4.375f, 0.0f, 4.375f);
    }

    public void beginXequeMate()
    {
        buttonLevels.SetActive(false);
        back2pieces.SetActive(false);
    }
}
