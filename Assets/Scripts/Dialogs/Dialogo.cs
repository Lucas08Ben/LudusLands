﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Dialogo
{
    [SerializeField]
    private TextoDialogo[] _falas;


    public TextoDialogo[] GetFalas()
    {
        return _falas;
    }
}
