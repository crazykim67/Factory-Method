using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UnitType
{
    Marine,
    Firebat,
    Zergling,
    Hydralisk,
}

public abstract class Unit
{
    public abstract void Prodction();
}
