using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleDrawing : MonoBehaviour
{
    private void Start()
    {
        //VectorDrawer.DrawBasisVectors
    }

    // Update is called once per frame
    void Update()
    {
        VectorDrawer.DrawVector(Vector3.zero, Vector3.one);
        VectorDrawer.DrawVector(Vector3.zero, Vector3.one, Color.red);
        VectorDrawer.DrawBasisVectors(transform.position, transform.right, transform.up, transform.forward);
    }

    
}
