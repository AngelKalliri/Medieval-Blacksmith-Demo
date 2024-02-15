using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Dagger : Weapon
{
    // POLYMORPHISM
    public override string GetName()
    {
        return $"Shadowblade Dagger";
    }

    public override string GetDescription()
    {
        return $"A lightweight and stealthy dagger, perfect for quick and silent strikes.";
    }

    public override int GetDamage()
    {
        return 5;
    }

    public override float GetWeight()
    {
        return 0.5f;
    }
    
    public override int GetPrice()
    {
        return 30;
    }

}
