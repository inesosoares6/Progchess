using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatalhaNavalScript : MonoBehaviour
{
    public GameObject queen;
    public GameObject pawn;
    public GameObject tower;
    public GameObject bishop;
    public GameObject knight;
    public GameObject blackSquares1;
    public GameObject blackSquares2;
    public GameObject blackSquares3;
    public GameObject blackSquares4;
    public GameObject blackSquares5;
    public GameObject blackSquares6;
    public GameObject blackSquares7;
    public GameObject blackSquares8;
    public GameObject blackSquares9;
    public GameObject blackSquares10;
    public GameObject blackSquares11;
    public GameObject blackSquares12;
    public GameObject blackSquares13;
    public GameObject blackSquares14;
    public GameObject blackSquares15;
    public GameObject blackSquares16;
    public GameObject blackSquares17;
    public GameObject blackSquares18;
    public GameObject blackSquares19;
    public GameObject blackSquares20;
    public GameObject blackSquares21;
    public GameObject blackSquares22;
    public GameObject blackSquares23;
    public GameObject blackSquares24;
    public GameObject blackSquares25;
    public GameObject blackSquares26;
    public GameObject blackSquares27;
    public GameObject blackSquares28;
    public GameObject blackSquares29;
    public GameObject blackSquares30;
    public GameObject blackSquares31;
    public GameObject blackSquares32;
    public GameObject whiteSquares1;
    public GameObject whiteSquares2;
    public GameObject whiteSquares3;
    public GameObject whiteSquares4;
    public GameObject whiteSquares5;
    public GameObject whiteSquares6;
    public GameObject whiteSquares7;
    public GameObject whiteSquares8;
    public GameObject whiteSquares9;
    public GameObject whiteSquares10;
    public GameObject whiteSquares11;
    public GameObject whiteSquares12;
    public GameObject whiteSquares13;
    public GameObject whiteSquares14;
    public GameObject whiteSquares15;
    public GameObject whiteSquares16;
    public GameObject whiteSquares17;
    public GameObject whiteSquares18;
    public GameObject whiteSquares19;
    public GameObject whiteSquares20;
    public GameObject whiteSquares21;
    public GameObject whiteSquares22;
    public GameObject whiteSquares23;
    public GameObject whiteSquares24;
    public GameObject whiteSquares25;
    public GameObject whiteSquares26;
    public GameObject whiteSquares27;
    public GameObject whiteSquares28;
    public GameObject whiteSquares29;
    public GameObject whiteSquares30;
    public GameObject whiteSquares31;
    public GameObject whiteSquares32;
    Dictionary<string, GameObject> blackSquares = new Dictionary<string, GameObject>();
    Dictionary<string, GameObject> whiteSquares = new Dictionary<string, GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        blackSquares.Add("blackSquares1", blackSquares1);
        blackSquares.Add("blackSquares2", blackSquares2);
        blackSquares.Add("blackSquares3", blackSquares3);
        blackSquares.Add("blackSquares4", blackSquares4);
        blackSquares.Add("blackSquares5", blackSquares5);
        blackSquares.Add("blackSquares6", blackSquares6);
        blackSquares.Add("blackSquares7", blackSquares7);
        blackSquares.Add("blackSquares8", blackSquares8);
        blackSquares.Add("blackSquares9", blackSquares9);
        blackSquares.Add("blackSquares10", blackSquares10);
        blackSquares.Add("blackSquares11", blackSquares11);
        blackSquares.Add("blackSquares12", blackSquares12);
        blackSquares.Add("blackSquares13", blackSquares13);
        blackSquares.Add("blackSquares14", blackSquares14);
        blackSquares.Add("blackSquares15", blackSquares15);
        blackSquares.Add("blackSquares16", blackSquares16);
        blackSquares.Add("blackSquares17", blackSquares17);
        blackSquares.Add("blackSquares18", blackSquares18);
        blackSquares.Add("blackSquares19", blackSquares19);
        blackSquares.Add("blackSquares20", blackSquares20);
        blackSquares.Add("blackSquares21", blackSquares21);
        blackSquares.Add("blackSquares22", blackSquares22);
        blackSquares.Add("blackSquares23", blackSquares23);
        blackSquares.Add("blackSquares24", blackSquares24);
        blackSquares.Add("blackSquares25", blackSquares25);
        blackSquares.Add("blackSquares26", blackSquares26);
        blackSquares.Add("blackSquares27", blackSquares27);
        blackSquares.Add("blackSquares28", blackSquares28);
        blackSquares.Add("blackSquares29", blackSquares29);
        blackSquares.Add("blackSquares30", blackSquares30);
        blackSquares.Add("blackSquares31", blackSquares31);
        blackSquares.Add("blackSquares32", blackSquares32);

        whiteSquares.Add("whiteSquares1",  whiteSquares1);
        whiteSquares.Add("whiteSquares2",  whiteSquares2);
        whiteSquares.Add("whiteSquares3",  whiteSquares3);
        whiteSquares.Add("whiteSquares4",  whiteSquares4);
        whiteSquares.Add("whiteSquares5",  whiteSquares5);
        whiteSquares.Add("whiteSquares6",  whiteSquares6);
        whiteSquares.Add("whiteSquares7",  whiteSquares7);
        whiteSquares.Add("whiteSquares8",  whiteSquares8);
        whiteSquares.Add("whiteSquares9",  whiteSquares9);
        whiteSquares.Add("whiteSquares10", whiteSquares10);
        whiteSquares.Add("whiteSquares11", whiteSquares11);
        whiteSquares.Add("whiteSquares12", whiteSquares12);
        whiteSquares.Add("whiteSquares13", whiteSquares13);
        whiteSquares.Add("whiteSquares14", whiteSquares14);
        whiteSquares.Add("whiteSquares15", whiteSquares15);
        whiteSquares.Add("whiteSquares16", whiteSquares16);
        whiteSquares.Add("whiteSquares17", whiteSquares17);
        whiteSquares.Add("whiteSquares18", whiteSquares18);
        whiteSquares.Add("whiteSquares19", whiteSquares19);
        whiteSquares.Add("whiteSquares20", whiteSquares20);
        whiteSquares.Add("whiteSquares21", whiteSquares21);
        whiteSquares.Add("whiteSquares22", whiteSquares22);
        whiteSquares.Add("whiteSquares23", whiteSquares23);
        whiteSquares.Add("whiteSquares24", whiteSquares24);
        whiteSquares.Add("whiteSquares25", whiteSquares25);
        whiteSquares.Add("whiteSquares26", whiteSquares26);
        whiteSquares.Add("whiteSquares27", whiteSquares27);
        whiteSquares.Add("whiteSquares28", whiteSquares28);
        whiteSquares.Add("whiteSquares29", whiteSquares29);
        whiteSquares.Add("whiteSquares30", whiteSquares30);
        whiteSquares.Add("whiteSquares31", whiteSquares31);
        whiteSquares.Add("whiteSquares32", whiteSquares32);
    }

    public void resartPieces()
    {
        queen.transform.position = new Vector3(-8.38f, 12.78f, 10.0f);
        pawn.transform.position = new Vector3(-7.54f, 8.47f, 10.0f);
        tower.transform.position = new Vector3(8.47f, 12.08f, 10.0f);
        bishop.transform.position = new Vector3(8.39f, 7.37f, 10.0f);
        knight.transform.position = new Vector3(-9.41f, 6.72f, 10.0f);
    }

    public void clearBoard()
    {
        int i = 0;
        while (i < 32)
        {
            i++;
            blackSquares["blackSquares" + i].GetComponent<Renderer>().material.color = Color.black;
            whiteSquares["whiteSquares" + i].GetComponent<Renderer>().material.color = Color.white;
        }
    }
}
