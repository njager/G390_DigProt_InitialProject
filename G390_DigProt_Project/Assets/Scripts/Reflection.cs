using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reflection : MonoBehaviour
{
    public Vector3 velocity;
    public GameObject paddle;
    public float raycastLength = 10f;


    private void OnDrawGizmos()
    {
        DrawVelocityLine();
    }
    
    public void DrawVelocityLine()
    {

    }

    private void FixedUpdate()
    {
        RaycastHit hit;
        Physics.Raycast(transform.position, velocity.normalized, raycastLength);

        if(Physics.Raycast(transform.position, velocity.normalized, out hit, Mathf.Infinity))
        {
            Debug.DrawLine(transform.position, transform.position + velocity.normalized, Color.yellow);
            Vector3 normal = hit.normal;

            Vector3 reflectionVector = velocity - 2 * Vector3.Dot(normal, velocity) * normal;

            Debug.DrawLine(hit.point, hit.point + reflectionVector, Color.red);
        }
    }
}
