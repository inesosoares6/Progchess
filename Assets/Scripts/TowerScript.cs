using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerScript : MonoBehaviour
{
    private int count;
    public AudioSource audioData;
    public GameObject tower;
    public GameObject cameraRig;
    public GameObject chessBoard;
    public GameObject buttonKnight;
    public GameObject buttonPawn;
    public GameObject buttonKing;
    public GameObject buttonBishop;
    public GameObject buttonQueen;
    public GameObject buttonTower;
    private GameObject spherePath;
    public Material redMaterial;
    // Start is called before the first frame update
    void Start()
    {
        tower.transform.position = new Vector3(21, 0, -21);
        cameraRig.transform.position = tower.transform.position + new Vector3(0.0f, 10.0f, -15.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void chooseAction()
    {
        switch (count)
        {
            case 1:
                createSphere();
                cameraRig.transform.position = tower.transform.position + new Vector3(0.0f, 20.0f, 0.0f);
                cameraRig.transform.rotation = new Quaternion(90.0f, 0.0f, 0.0f, 180.0f);
                break;
            case 2:
                showDirections();
                count = 0;
                break;
            case 3:
                //endGame();
                break;
        }
    }

    public void clicked()
    {
        count++;
        chooseAction();
    }

    private void createSphere()
    {
        spherePath = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        spherePath.transform.position = tower.transform.position + new Vector3(-6.0f, 0.0f, 0.0f);
        spherePath.transform.localScale = new Vector3(2.0f, 2.0f, 2.0f);
        spherePath.GetComponent<Renderer>().material = redMaterial;
        spherePath.AddComponent<BoxCollider>();
        //spherePath.AddComponent<GvrAllEventsTrigger>().OnPointerClick = moveTower();
    }


    private void showDirections()
    {
        
    }

    private void DeleteArrows()
    {
        
    }

    private void moveTower()
    {

    }

    public void beginTower()
    {
        chessBoard.SetActive(true);
        tower.SetActive(true);
        buttonKnight.SetActive(false);
        buttonBishop.SetActive(false);
        buttonKing.SetActive(false);
        buttonQueen.SetActive(false);
        buttonTower.SetActive(false);
        buttonPawn.SetActive(false);
    }
}
