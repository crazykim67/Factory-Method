using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc : Monster
{
    public Orc()
    {
        type = MonsterType.Orc;
        name = "Orc";
        hp = 150;
        damage = 20;
        armor = 2;

        Debug.Log($"{name} 생성");
    }

    public override void Attack()
    {
        Debug.Log($"{this.name} {this.damage}만큼 공격");
    }
}
