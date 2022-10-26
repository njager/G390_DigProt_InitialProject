using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : MonoBehaviour
{
    public float cooldown = 10f;
    public int health = 10;
    public abstract void Consume();

}

public class Potion : Item
{

}

