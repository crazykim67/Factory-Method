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
                    Debug.Log("���۸� ������");
                    break;
                }
            case UnitType.Hydralisk:
                {
                    unit = new Hydralisk();
                    Debug.Log("����󸮽�ũ ������");
                    break;
                }
        }

        return unit;
    }
}
