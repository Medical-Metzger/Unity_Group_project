using UnityEngine;

public class ActivateObject_PK : MonoBehaviour
{

    public GameObject targetObject;
    private bool isClicked = false; //declares the native clickstate to be off (not clicked initially)

    void Start()
    {
       targetObject.SetActive(false);
    }


    void OnMouseDown() //only works on objects with colliders
    {

            isClicked = !isClicked; //toggles variable, if isclicked is true becomes false vice versa
            if (targetObject != null) //checks if the target object has been selected
            {
                targetObject.SetActive(isClicked); //turns targetobject on or off based on the isclicked variable 
            }

        }
    }
