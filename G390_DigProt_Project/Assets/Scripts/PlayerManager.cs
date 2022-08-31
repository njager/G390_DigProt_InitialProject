using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int money;
    public int xp;
    public int lives;
    
    public void GainMoney(int loot)
    {
        money += loot;
    }

}
