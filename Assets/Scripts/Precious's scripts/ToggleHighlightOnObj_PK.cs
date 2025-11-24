
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleHighlightOnObj_PK : MonoBehaviour
{
    public bool isClicked = false;
 

   
    // Start is called before the first frame update
    void Start()
    {
        transform.GetComponent<Outline>().enabled = false;

      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Debug.Log("Click On Object " + transform.name);

        isClicked = !isClicked;

        if (isClicked)
        {
            transform.GetComponent<Outline>().enabled = true;
           
        }
        else
        {
            transform.GetComponent<Outline>().enabled = false;
            
        }


    }
}
