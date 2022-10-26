using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RPGElements : MonoBehaviour
{
    [Flags]
    public enum Elements
    {
        None,
        Fire = 1,
        Water = 1 << 1,
        Ice = 1 << 2,
        Lightning = 1 << 3,
    }

    public static class RPGElements
    {
        public static Elements FireWeakness = Elements.Ice; // and etc
        public static bool HasSameElements(Elements attackerElements, Elements defeenderElements)
        {
            return false;
        }

        public static bool HasWeaknessElements(Elements attackerElements, Elements defenderElements)
        {
            
            Elements combinedElements = attackerElements | defenderElements;

            if(HasSameElements(combinedElements, FireWeakness) && attackerElements.HasFlag(Elements.Fire))
            {

            }
            return false;
        }
    }
}
