using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerPieces : MonoBehaviour
{
    public GameObject knight;
    public KnightScript knightScript;
    public GameObject tower;
    public TowerScript towerScript;
    public GameObject bishop;
    public BishopScript bishopScript;

    public void initiateKnight()
    {
        knight.SetActive(true);
        knightScript.showLevels_knight();
    }

    public void initiateTower()
    {
        tower.SetActive(true);
        towerScript.showLevels_tower();
    }

    public void initiatePawn()
    {

    }

    public void initiateKing()
    {

    }

    public void initiateQueen()
    {

    }

    public void initiateBishop()
    {
        bishop.SetActive(true);
        bishopScript.showLevels_bishop();
    }
}
