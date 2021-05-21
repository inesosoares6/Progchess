using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void sceneIdentifyPieces()
    {
        Debug.Log("Scene -> Identificar Peças");
        SceneManager.LoadScene("Cubes");
    }

    public void sceneBatalhaNaval()
    {
        Debug.Log("Scene -> Batalha Naval");
        SceneManager.LoadScene("BatalhaNaval");
    }

    public void sceneMovementsPieces()
    {
        Debug.Log("Scene -> Movimentos das Peças");
        SceneManager.LoadScene("Movements");
    }
}
