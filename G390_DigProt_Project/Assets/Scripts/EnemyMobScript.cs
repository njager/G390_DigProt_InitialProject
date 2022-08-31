using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMobScript : MonoBehaviour
{
    public int health;
    public int loot;
    [SerializeField] float movementSpeed;
    [SerializeField] BulletScript bullet;
    [SerializeField] PlayerManager manager;
    Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector3(1f, 0f, 0f);
        movement = movement * movementSpeed * Time.deltaTime;

        transform.position += movement;

        if(health <= 0)
        {
            manager.GainMoney(loot);
        }
    }

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.CompareTag(("Bullet"));
    }*/

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag(("Bullet")))
        {
            TakeDamage(bullet.damage);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Enemy health = " + health);
    }


}
