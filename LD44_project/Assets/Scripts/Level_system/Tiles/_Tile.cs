﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class _Tile : _GridElement
{
    public bool discovered = false;

    public abstract bool Walkable { get; }

    protected override void Awake()
    {
        base.Awake();
    }

    protected override void Start()
    {
        base.Start();
    }
}

