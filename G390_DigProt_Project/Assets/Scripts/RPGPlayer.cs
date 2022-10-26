using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPGPlayer : MonoBehaviour
{
    public RPGElements attackElements = RPGElements.None;
    public RPGEnemy enemyRef;
    public int damageValue = 2;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Attack()
    {
        if(RPGElements.HasSameElements(attackElements, defenderElements))
        {
            //take no damage
        }
        else if 
    }
}
