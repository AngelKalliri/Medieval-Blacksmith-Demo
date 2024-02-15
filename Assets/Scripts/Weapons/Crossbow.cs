using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Crossbow : Weapon
{
    // POLYMORPHISM
    public override string GetName()
    {
        return $"Falcon Eye Crossbow";
    }

    public override string GetDescription()
    {
        return $"A hand-crafted crossbow with exceptional accuracy, perfect for ranged combat.";
    }

    public override int GetDamage()
    {
        return 13;
    }

    public override float GetWeight()
    {
        return 3.0f;
    }

    public override int GetPrice()
    {
        return 60;
    }
}
