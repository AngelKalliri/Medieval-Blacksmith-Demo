using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Warhammer : Weapon
{
    // POLYMORPHISM
    public override string GetName()
    {
        return $"Thunderstrike Warhammer";
    }

    public override string GetDescription()
    {
        return $"A powerful two-handed hammer designed for crushing armor and bones alike.";
    }

    public override int GetDamage()
    {
        return 18;
    }

    public override float GetWeight()
    {
        return 3.8f;
    }

    public override int GetPrice()
    {
        return 70;
    }
}
