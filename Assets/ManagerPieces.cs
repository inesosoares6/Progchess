using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerPieces : MonoBehaviour
{
    public GameObject knight;
    public GameObject tower;
    public KnightScript knightScript;
    public TowerScript towerScript;

    public void initiateKnight()
    {
        knight.SetActive(true);
        knightScript.showLevels_knight();
    }

    public void initiateTower()
    {
        tower.SetActive(true);
        towerScript.showLevels_tower();
        Debug.Log("Initiated Tower");
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

    }
}
