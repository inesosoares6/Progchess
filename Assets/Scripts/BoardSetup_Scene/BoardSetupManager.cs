using UnityEngine;
using UnityEngine.SceneManagement;

public class BoardSetupManager : MonoBehaviour
{
    public BoardSetupLevel1 boardSetupLevel1;
    public BoardSetupLevel2 boardSetupLevel2;
    public BoardSetupLevel3 boardSetupLevel3;
    public BoardSetupLevel4 boardSetupLevel4;
    public GameObject manager;

    public void initiateLevel1()
    {
        manager.GetComponent<BoardSetupLevel1>().enabled = true;
        boardSetupLevel1.initiatelevel1();
    }

    public void initiateLevel2()
    {
        boardSetupLevel2.initiateLevel2();
    }

    public void initiateLevel3()
    {
        boardSetupLevel3.showPieces();
    }

    public void initiateLevel4()
    {
        boardSetupLevel4.showPieces();
    }

    public void initiateBatalhaNaval()
    {
        SceneManager.LoadScene("BatalhaNaval");
    }
}
