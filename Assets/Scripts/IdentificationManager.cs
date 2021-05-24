using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IdentificationManager : MonoBehaviour
{
    public GameObject buttonsLevels;
    public GameObject manager;
    public Level1Script level1;
    public Level2Script level2;
    public Level3Script level3;
    public Level4Script level4;
    public GameObject backButtonScene;

    public void Level(int gameLevel)
    {
        Debug.Log("Level "+ gameLevel);
        deactivateLevelButtons();
        switch (gameLevel)
        {
            case 1:
                manager.GetComponent<Level1Script>().enabled = true;
                level1.activatePiecesButtons();
                backButtonScene.SetActive(false);
                break;
            case 2:
                manager.GetComponent<Level2Script>().enabled = true;
                level2.initiateLevel();
                backButtonScene.SetActive(false);
                break;
            case 3:
                manager.GetComponent<Level3Script>().enabled = true;
                level3.initiateLevel();
                backButtonScene.SetActive(false);
                break;
            case 4:
                manager.GetComponent<Level4Script>().enabled = true;
                level4.initiateLevel();
                backButtonScene.SetActive(false);
                break;
        }
    }


    private void deactivateLevelButtons()
    {
        buttonsLevels.SetActive(false);
    }

    public void activateLevelButtons()
    {
        buttonsLevels.SetActive(true);
        backButtonScene.SetActive(false);
        manager.GetComponent<Level1Script>().enabled = false;
        manager.GetComponent<Level2Script>().enabled = false;
        manager.GetComponent<Level3Script>().enabled = false;
        manager.GetComponent<Level4Script>().enabled = false;
    }

    public void back2scene()
    {
        SceneManager.LoadScene("Manager");
    }

}
