using UnityEngine;

public class ActivateObject_DissappearOtherObjectPK : MonoBehaviour
{

    public GameObject targetObject;
    private bool isClicked = false; //declares the native clickstate to be off (not clicked initially)
    private static ActivateObject_DissappearOtherObjectPK currentlyActive; //static reference shared by all instances of the script 

    void Start()
    {
       targetObject.SetActive(false);
    }


    void OnMouseDown() 
    {
        // If this object is not the currently active one
        if (currentlyActive != null && currentlyActive != this)
        {
            // Turn off the previously active object
            currentlyActive.isClicked = false;
            currentlyActive.targetObject.SetActive(false);
        }


        //applies the active state 
        isClicked = !isClicked; //toggles variable, if isclicked is true becomes false vice versa
              
        if (isClicked) // If turning on, set this as the active one
        {
            currentlyActive = this;
        }
        else
        {
            // If turning off, clear static reference
            if (currentlyActive == this)
                currentlyActive = null;
        }

        if (targetObject != null) //checks if the target object has been selected
            {
                targetObject.SetActive(isClicked); //turns targetobject on or off based on the isclicked variable 
            }

        }
    }
