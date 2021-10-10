using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerScript : MonoBehaviour
{
    public void sceneIdentifyPieces()
    {
        Debug.Log("Scene -> Identificar Peças");
        SceneManager.LoadScene("Identification");
    }

    public void sceneMovementsPieces()
    {
        Debug.Log("Scene -> Movimentos das Peças");
        SceneManager.LoadScene("Movements2.0");
    }

    public void sceneBoardSetup()
    {
        Debug.Log("Scene -> Board Setup");
        SceneManager.LoadScene("BoardSetup");
    }

    public void sceneAtaquesRei()
    {
        Debug.Log("Scene -> Ataques Rei");
        SceneManager.LoadScene("AtaquesRei");
    }
}
