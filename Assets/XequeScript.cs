using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XequeScript : MonoBehaviour
{
    public GameObject tower_white;
    public GameObject tower_black;
    public GameObject king_black;
    public GameObject queen_white;
    public GameObject queen_black;
    public GameObject knight_black;
    public GameObject knight_white;
    public GameObject bishop_white;
    public GameObject bishop_black;
    public GameObject pawn1_black;
    public GameObject pawn2_black;
    public GameObject pawn3_black;
    public GameObject pawn4_black;
    public GameObject pawn1_white;
    public GameObject pawn2_white;
    private int level;
    public GameObject buttonLevels;
    public GameObject back2pieces;
    public GameObject back2scenes;
    public GameObject buttonPieces;

    public void defineLevel_xeque(int num)
    {
        level = num;
        beginXeque();
        moveTarget_xeque(level);
    }

    private void moveTarget_xeque(int level)
    {
        throw new NotImplementedException();
    }

    private void beginXeque()
    {
        buttonLevels.SetActive(false);
        back2pieces.SetActive(false);
    }
}
