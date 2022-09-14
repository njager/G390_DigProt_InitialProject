using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneWayTrigger : MonoBehaviour
{
    public Transform playerTransform;
    SpriteRenderer doorSprite;
    bool rightDirection;

    private void Start()
    {
        doorSprite = gameObject.GetComponent<SpriteRenderer>();
    }

    /* 
    void FixedUpdate()
    {
        float directionScalar = Vector3.Dot(transform.position.normalized, playerTransform.position.normalized);
        Debug.Log("Door direction = " + directionScalar);

        if (directionScalar >= .99 || directionScalar <= -.99)
        {
            doorSprite.color = Color.green;
        }
        else
        {
            doorSprite.color = Color.red;
        }
    }*/
    private void OnTriggerEnter(Collider other)
    {
        float directionScalar = Vector3.Dot(transform.position.normalized, other.transform.position.normalized);
        if (directionScalar >= .95)
        {
            doorSprite.color = Color.green;
        }
        else
        {
            doorSprite.color = Color.red;
        }
    }

}
