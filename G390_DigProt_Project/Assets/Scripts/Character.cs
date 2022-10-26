using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    public float cooldown = 10f;
    public int health = 10;
    public virtual void Walk()
    {
        print($"the character is walking");
    }
    public virtual void Speak() => print($"Character is speaking");
    public void Punch() { }

}

public class Human : Character
{
    public override void Speak()
    {
       
    }
    public override void Walk(int distance, Vector3 direction)
    {

        transform.position += distance * direction;
    }

}
