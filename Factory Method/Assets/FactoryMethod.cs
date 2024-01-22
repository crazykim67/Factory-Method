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

    // ���丮 �޼ҵ�
    public abstract void CreateMonsters();
}
