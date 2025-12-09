using UnityEngine;

// I wrote a script for scaling an object on mouse hover to make my terminology scene more interesting
// and to make segmented parts stand out
// I decided to use the Vector3 function for this specific instance 
// I saw a video on someone implementing it https://www.youtube.com/shorts/NRzELUrQOwU ,
// I tried to write the script in a simpler more understanding way for myself but also following this implementation
// I followed Matt's Vector3 and OnMouseDown, over and exit videos and unity's documentation for guidance

public class ScaleOnMouseHover : MonoBehaviour
{
    // referencing new vectors for initialScale and hoverScale. I used the Vector3 instead of Vector2 because I want it to scale in all 3 x,y,z axis
    private Vector3 initialScale;
    private Vector3 hoverScale;

    void Start()
    {
        // the object starts with the initial scale (local scale)
        initialScale = transform.localScale;
        // the new scale when mouse is hovering is the initial scale times 1.1f on all axis
        hoverScale = initialScale * 1.1f;
    }

    // if mouse hovers over object the new local scale is the increased one
    private void OnMouseOver()
    {
        transform.localScale = hoverScale;
    }

    // if mouse doesn't hover anymore, the localscale returns to its initial scale
    private void OnMouseExit()
    {
        transform.localScale = initialScale;
    }
}
