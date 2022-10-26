using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable
{
    public float cooldown { get; set; }
    public int health { get; set; }
    public void TakeDamage();
    public void Destroyed();
}
