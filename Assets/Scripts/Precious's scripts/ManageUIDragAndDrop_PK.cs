
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageUIDragAndDrop_PK : MonoBehaviour
{
    private Vector3 delta;

    private Vector3 initPosition;

    [SerializeField]
    private GameObject targetObj;
    private GameObject currentObj;

    // Start is called before the first frame update
    void Start()
    {
        initPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnStartCliking()
    {
        delta = Input.mousePosition - transform.position;
        transform.position = Input.mousePosition - delta;
    }

    public void OnDragObj()
    {
        transform.position = Input.mousePosition - delta;
    }

    public void OnDropObj()
    {
        if (currentObj == targetObj)
        {
            transform.position = currentObj.transform.position;
        }
        else
        {
            transform.position = initPosition;
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        //Debug.Log("Enter " + collider.name);
        currentObj = collider.gameObject;
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        currentObj = null;
        //Debug.Log("Exit " + collider.name);
    }

}
