using UnityEngine;

public class ActivateObject_PK : MonoBehaviour
{

    public GameObject targetObject;
    private bool isClicked = false; //declares the native clickstate to be off (not clicked initially)

  
    void OnMouseDown()
    {

            isClicked = !isClicked;
            if (targetObject != null)
            {
                targetObject.SetActive(isClicked); //turns targetobject on or off based on the isclicked variable 
            }

        }
    }
