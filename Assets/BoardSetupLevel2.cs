using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardSetupLevel2 : MonoBehaviour
{
    public GameObject piecesButtons;
    public GameObject back2scenesButton;
    public GameObject back2levelsButton;
    public GameObject board;
    public GameObject levels;
    public GameObject pieces;
    public GameObject restartButton;
    public GameObject w_king;
    public GameObject w_knight1;
    public GameObject w_knight2;
    public GameObject w_pawn1;
    public GameObject w_pawn2;
    public GameObject w_pawn3;
    public GameObject w_pawn4;
    public GameObject w_pawn5;
    public GameObject w_pawn6;
    public GameObject w_pawn7;
    public GameObject w_pawn8;
    public GameObject w_tower1;
    public GameObject w_tower2;
    public GameObject w_queen;
    public GameObject w_bishop1;
    public GameObject w_bishop2;

    public void back2levels()
    {
        pieces.SetActive(false);
        levels.SetActive(true);
        board.SetActive(false);
        restartButton.SetActive(false);
        back2scenesButton.SetActive(true);
        back2levelsButton.SetActive(false);
    }

    public void showPiecesButtons()
    {
        piecesButtons.SetActive(true);
    }
}
