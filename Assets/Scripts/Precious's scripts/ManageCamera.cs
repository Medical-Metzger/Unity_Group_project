using UnityEngine;

public class ManageCamera : MonoBehaviour
{
    [SerializeField] private Transform myTransformedObj;
    public GameObject objectToLookAt;

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(1.1f, 0.0f, 0.0f, Space.Self);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-1.1f, 0.0f, 0.0f, Space.Self);
        }

        transform.LookAt(myTransformedObj);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            GetComponent<Camera>().fieldOfView += 0.05f;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            GetComponent<Camera>().fieldOfView -= 0.05f;
        }
    }
}
