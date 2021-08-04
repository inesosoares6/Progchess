using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerPieces : MonoBehaviour
{
    public GameObject knight;
    public KnightScript2 knightScript2;
    public GameObject tower;
    public TowerScript2 towerScript2;
    public GameObject bishop;
    public BishopScript2 bishopScript2;
    public GameObject king;
    public KingScript2 kingScript2;
    public GameObject queen;
    public QueenScript2 queenScript2;
    public GameObject pawn;
    public PawnScript2 pawnScript2;

    public void initiateKnight()
    {
        knight.SetActive(true);
        knightScript2.showLevels_knight();
    }

    public void initiateTower()
    {
        tower.SetActive(true);
        towerScript2.showLevels_tower();
    }

    public void initiatePawn()
    {
        pawn.SetActive(true);
        pawnScript2.showLevels_pawn();
    }

    public void initiateKing()
    {
        king.SetActive(true);
        kingScript2.showLevels_king();
    }

    public void initiateQueen()
    {
        queen.SetActive(true);
        queenScript2.showLevels_queen();
    }

    public void initiateBishop()
    {
        bishop.SetActive(true);
        bishopScript2.showLevels_bishop();
    }
}
