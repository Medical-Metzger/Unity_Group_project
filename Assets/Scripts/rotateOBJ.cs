using UnityEngine;

public class r : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("A");
            transform.Rotate(0.0f, -1.1f, 0.0f, Space.Self);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("D");
            transform.Rotate(0.0f, 1.1f, 0.0f, Space.Self);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("W");
            transform.Rotate(1.1f, 0.0f, 0.0f, Space.Self);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("S");
            transform.Rotate(-1.1f, 0.0f, 0.0f, Space.Self);
        }
    }
}

