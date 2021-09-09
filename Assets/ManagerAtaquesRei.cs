using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerAtaquesRei : MonoBehaviour
{
    public XequeScript xequeScript;
    public SaidaXequeScript saidaXequeScript;
    public XequeMateScript xequeMateScript;
    public ReiAfogadoScript reiAfogadoScript;

    public void initiateXeque()
    {
        xequeScript.showLevels_xeque();
    }

    public void initiateSaidaXeque()
    {
        saidaXequeScript.showLevels_saidaxeque();
    }

    public void initiateXequeMate()
    {
        xequeMateScript.showLevels_xequemate();
    }

    public void initiateReiAfogado()
    {
        reiAfogadoScript.showLevels_reiafogado();
    }
}
