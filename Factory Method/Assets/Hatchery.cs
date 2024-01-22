using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hatchery : FactoryMethod
{
    public override Unit CreateUnit(UnitType type)
    {
        Unit unit = null;

        switch (type)
        {
            case UnitType.Zergling:
                {
                    unit = new Zergling();
                    Debug.Log("저글링 변태중");
                    break;
                }
            case UnitType.Hydralisk:
                {
                    unit = new Hydralisk();
                    Debug.Log("히드라리스크 변태중");
                    break;
                }
        }

        return unit;
    }
}
