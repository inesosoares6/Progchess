using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SaidaXequeScript : MonoBehaviour
{
    private int level;
    public GameObject buttonLevels;
    public GameObject back2pieces;
    public GameObject back2scenes;
    public GameObject buttonPieces;
    public AudioSource levelUp;
    public GameObject king_white;
    public GameObject queen_black;
    public GameObject bishop_black;
    public GameObject knight_black;
    public GameObject bishop_white;
    public GameObject knight_white;
    public GameObject tower_black1;
    public GameObject tower_black2;
    public GameObject tower_white;
    public GameObject pawn_white1;
    public GameObject pawn_white2;
    public GameObject pawn_black;

    public void defineLevel_saidaxeque(int num)
    {
        level = num;
        beginSaidaXeque();
        moveTarget_saidaxeque(level);
    }

    private void moveTarget_saidaxeque(int level)
    {
        throw new NotImplementedException();
    }

    public void showLevels_saidaxeque()
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

    public void beginSaidaXeque()
    {
        buttonLevels.SetActive(false);
        back2pieces.SetActive(false);
    }
}
