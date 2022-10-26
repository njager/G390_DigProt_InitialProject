using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour, IDamageable
{
    public float cooldown { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public int health { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public abstract string Inspect();

    public abstract void Attack();

    public void TakeDamage(int damageValue)
    {
        throw new System.NotImplementedException();
    }

    public void Destroyed()
    {
        throw new System.NotImplementedException();
    }
}

public class Mace : Weapon
{
    public override void Attack()
    {

    }

    public override string Inspect()
    {
        return "";
    }

    public override void TakeDamage(int damageValue)
    {

    }
}
