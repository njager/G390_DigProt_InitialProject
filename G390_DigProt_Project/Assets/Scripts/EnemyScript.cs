using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    int health = 10;
    int currencyLoot = 5;
    float movespeed = 1f;
    public GameObject targetGoal;
    Vector3 targetLocation;
    PlayerManager playerRef;

    public enum EnemyTypes
    {
        Normal,
        Armored,
        Invisible,
        Regenerating
    }

    public EnemyTypes enemyType;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
