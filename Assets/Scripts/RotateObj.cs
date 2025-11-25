using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ProjectPosition : MonoBehaviour
{
    private float xRot = 0.0f;
    private float yRot = 0.0f;

    private Vector3 eulerRot;

    private Quaternion myInitialRotation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //assign the original object orientation to the initial rotation variable
        myInitialRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        // Manage rotation on Y axis
        if (Input.GetKey(KeyCode.UpArrow))
        {
            xRot = 0.5f;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            xRot = -0.5f;
        }
        else 
        {
            xRot = 0.0f;
        }

        // Manage rotation on X axis
        if (Input.GetKey(KeyCode.RightArrow))
        {
            yRot = -0.5f;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            yRot = 0.5f;
        }
        else
        {
            yRot = 0.0f;
        }

        eulerRot = new Vector3(xRot, yRot, 0.0f);
        transform.Rotate(eulerRot, Space.Self);

        if (Input.GetKey(KeyCode.Space))
        {
            transform.rotation = myInitialRotation;
        }
    }
}

