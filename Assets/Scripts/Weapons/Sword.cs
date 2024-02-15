using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Sword : Weapon
{
    // POLYMORPHISM
    public override string GetName()
    {
        return $"Ironclad Longsword";
    }

    public override string GetDescription()
    {
        return $"A versatile and well-balanced weapon, suitable for both cutting and thrusting.";
    }

    public override int GetDamage()
    {
        return 10;
    }

    public override float GetWeight()
    {
        return 2.5f;
    }

    public override int GetPrice()
    {
        return 50;
    }
}  
