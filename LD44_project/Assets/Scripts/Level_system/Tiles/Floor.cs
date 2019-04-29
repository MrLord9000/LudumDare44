﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : _Tile
{
    public override bool Walkable => true;
    // Three main reference fields for storing information about contents of current floor tile
    public _Agent agent;
    public Thing thing;
    public int coins;
    protected override void Awake()
    {
        base.Awake();
    }

    protected override void Start()
    {
        base.Start();
    }
}
