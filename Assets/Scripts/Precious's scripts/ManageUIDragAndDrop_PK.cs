
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;
using static UnityEngine.GraphicsBuffer;

public class ManageUIDragAndDrop_PK : MonoBehaviour
{
    private Vector3 delta;

    private Vector3 initPosition;

    [SerializeField]
    public GameObject targetObj;
    public GameObject currentObj;
    Collider2D myCol;
    Collider2D targetCol; //referencing the colliders we are going to be using

    // Start is called before the first frame update
    void Start()
    {
        initPosition = transform.position;
        //getting the collider of currentobj
        myCol = GetComponent<Collider2D>();
        targetCol = targetObj.GetComponent<Collider2D>();
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
        if (myCol.IsTouching(targetCol)) //(currentObj == targetObj) wasnt working
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
    public void SnapToTarget()
    {
       
        
        currentObj.transform.position = targetObj.transform.position;// added this line myself because i was struggling to have the words move
    }

}
