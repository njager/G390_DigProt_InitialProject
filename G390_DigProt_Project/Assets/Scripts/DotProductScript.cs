using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotProductScript : MonoBehaviour
{
    public Transform playerTransform;
    SpriteRenderer buttonSprite;

    private void Start()
    {
        buttonSprite = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float directionScalar = Vector3.Dot(transform.position.normalized, playerTransform.position.normalized);
        Debug.Log("Button direction = " + directionScalar);

        if(directionScalar >= .99 || directionScalar <= -.99)
        {
            buttonSprite.color = Color.green;
        }
        else
        {
            buttonSprite.color = Color.red;
        }
    }
}
