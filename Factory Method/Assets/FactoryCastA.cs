using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryCastA : MonoBehaviour
{
    // �׶� ������ ���
    void Start()
    {
        FactoryMethod fm = new Hatchery();
        Unit zergling = fm.CreateUnit(UnitType.Zergling);
        Unit hydralisk = fm.CreateUnit(UnitType.Hydralisk);

        zergling.Prodction();
        hydralisk.Prodction();
    }
}
