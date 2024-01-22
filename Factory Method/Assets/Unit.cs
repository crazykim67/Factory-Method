using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UnitType
{
    Marine,
    Zergling,
}

public abstract class Unit
{
    public abstract void Prodction();
}
