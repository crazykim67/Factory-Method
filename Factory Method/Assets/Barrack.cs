using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrack : FactoryMethod
{
    public override Unit CreateUnit(UnitType type)
    {
        Unit unit = null;

        switch (type)
        {
            case UnitType.Marine:
                {
                    unit = new Marine();
                    Debug.Log("���� �Ʒ���");
                    break;
                }
            case UnitType.Firebat:
                {
                    unit = new Firebat();
                    Debug.Log("���̾�� �Ʒ���");
                    break;
                }
        }

        return unit;
    }
}
