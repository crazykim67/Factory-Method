using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MonsterType
{
    Goblin,
    Orc,
}

public abstract class Monster
{
    protected MonsterType type;
    protected string name;
    protected int hp;
    protected int damage;
    protected int armor;

    public abstract void Attack();
}
