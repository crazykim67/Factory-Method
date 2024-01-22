using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public abstract class FactoryMethod
{
    public List<Monster> monsters = new List<Monster>();

    public List<Monster> getMonsters()
    {
        return monsters;
    }

    // 팩토리 메소드
    public abstract void CreateMonsters();
}
