using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Axe : Weapon
{
    // POLYMORPHISM
    public override string GetName()
    {
        return $"Reaper's Battle Axe";
    }

    public override string GetDescription()
    {
        return $"A fearsome double-edged battle axe, ideal for cleaving through enemies on the battlefield.";
    }

    public override int GetDamage()
    {
        return 20;
    }

    public override float GetWeight()
    {
        return 4.2f;
    }

    public override int GetPrice()
    {
        return 80;
    }
}
