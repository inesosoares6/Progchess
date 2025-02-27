﻿using System.Collections;
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
        saidaXequeScript.showLevels_Saidaxeque();
    }

    public void initiateXequeMate()
    {
        xequeMateScript.showLevels_xequeMate();
    }

    public void initiateReiAfogado()
    {
        reiAfogadoScript.showLevels_ReiAfogado();
    }
}
