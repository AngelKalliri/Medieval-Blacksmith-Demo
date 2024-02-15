using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public abstract class Weapon : MonoBehaviour, UIManager.IUIInfoContent
{
    // POLYMORPHISM
    public virtual string GetName()
    {
        return "";
    }

    public virtual string GetDescription()
    {
        return "";
    }

    public virtual int GetDamage()
    {
        return 0;
    }

    public virtual float GetWeight()
    {
        return 0.0f;
    }

    public virtual int GetPrice()
    {
        return 0;
    }
}
