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

        Debug.Log($"{name} ����");
    }

    public override void Attack()
    {
        Debug.Log($"{this.name} {this.damage}��ŭ ����");
    }
}
