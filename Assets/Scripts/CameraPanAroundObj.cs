using UnityEngine;
using UnityEngine.Experimental.AI;

public class NewMonoBehaviourScript : MonoBehaviour
{
    //creating public game object to look at so that i can add the object i want to pan around in the inspector
    public GameObject objToLookAt;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Manage rotation on x axis by inputting the key and tweaking the translation values to adjust movement
        // Debug Log helps me know that key has been pressed and works
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Right Arrow Pressed");
            transform.Translate(2.0f, 0.0f, 0.0f, Space.Self);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Left Arrow Pressed");
            transform.Translate(-2.0f, 0.0f, 0.0f, Space.Self);
        }
        else { }

         // Manage rotation on y axis just like on x axis
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow Pressed");
            transform.Translate(0.0f, 2.0f, 0.0f, Space.Self);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow Pressed");
            transform.Translate(0.0f, -2.0f, 0.0f, Space.Self);
        }
        else { }

        // Camera is locked onto object and moves around it
        transform.LookAt(objToLookAt.transform);
    }
}

