using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseFactoryMethod : MonoBehaviour
{
    FactoryMethod[] monsterGenerators = null;

    private void Start()
    {
        monsterGenerators = new FactoryMethod[2];
        monsterGenerators[0] = new UseFactoryCaseA();
        monsterGenerators[1] = new UseFactoryCaseB();

        MakeOrc();
    }

    public void MakeGoblin()
    {
        monsterGenerators[0].CreateMonsters();

        List<Monster> monsters = monsterGenerators[0].getMonsters();

        foreach (var monster in monsters)
            monster.Attack();
    }

    public void MakeOrc()
    {
        monsterGenerators[1].CreateMonsters();

        List<Monster> monsters = monsterGenerators[1].getMonsters();

        foreach (var monster in monsters)
            monster.Attack();

    }
}
