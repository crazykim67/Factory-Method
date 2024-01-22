using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Goblin : Monster
{
    public Goblin()
    {
        type = MonsterType.Goblin;
        name = "Goblin";
        hp = 100;
        damage = 10;
        armor = 1;

        Debug.Log($"{name} 생성");
    }

    public override void Attack()
    {
        Debug.Log($"{this.name} {this.damage}만큼 공격");
    }
}
