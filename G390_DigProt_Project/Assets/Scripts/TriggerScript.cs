using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public float radius = 3f;

    public Transform player;

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
        }
    }

    private void Update()
    {
        
    }
}
