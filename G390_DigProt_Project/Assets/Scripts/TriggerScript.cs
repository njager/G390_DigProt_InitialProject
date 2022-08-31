using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public int cost;
    public float radius = 3f;
    public Transform player;
    public float bulletSpeed = 10;
    public Rigidbody2D bullet;
    public float fireSpeed;

    private float fireTimer = 0f;

    private void Start()
    {
        fireTimer = fireSpeed;
    }

    void Fire()
    {
        Rigidbody2D bulletClone = (Rigidbody2D)Instantiate(bullet, transform.position, transform.rotation);
        bulletClone.velocity = transform.forward * bulletSpeed;
    }

    private void Update()
    {
        fireTimer -= Time.deltaTime;
    }

    private void OnDrawGizmos()
    {
        float distanceToPlayer = (transform.position - player.position).magnitude;

        if (Mathf.Abs(distanceToPlayer) > radius)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(transform.position, radius);
        }
        else
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, radius);

            LineRenderer lr = gameObject.GetComponent<LineRenderer>();
            //lr.material = new Material(Shader.Find("Particles/Alpha Blended Premultiply"));
            lr.startColor = Color.white;
            lr.startWidth = 0.1f;
            lr.SetPosition(0, transform.position);
            lr.SetPosition(1, player.position);

            fireTimer -= Time.deltaTime;

            if(fireTimer <= 0)
            {
                Fire();
                fireTimer = fireSpeed;
            }
        }
    }
}
