using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseFactoryCaseA : FactoryMethod
{
    public override void CreateMonsters()
    {
        monsters.Add(new Goblin());
        monsters.Add(new Goblin());
        monsters.Add(new Goblin());
    }
}

public class UseFactoryCaseB : FactoryMethod
{
    public override void CreateMonsters()
    {
        monsters.Add(new Orc());
        monsters.Add(new Orc());
        monsters.Add(new Orc());
    }
}
