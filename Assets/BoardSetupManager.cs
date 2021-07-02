using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardSetupManager : MonoBehaviour
{
    public BoardSetupLevel3 boardSetupLevel3;

    public void initiateLevel3()
    {
        boardSetupLevel3.showPieces();
    }
}
