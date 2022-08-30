using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed;
    Vector3 movement;
    public float sprintSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        movement = new Vector3(moveHorizontal, moveVertical, 0f);


        if (Input.GetKey(KeyCode.LeftShift))
        {
            movement = movement * sprintSpeed * Time.deltaTime;

            transform.position += movement;
        }
        else
        {
            movement = movement * speed * Time.deltaTime;

            transform.position += movement;
        }
    }
}
