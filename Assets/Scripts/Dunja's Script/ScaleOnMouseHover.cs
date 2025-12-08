using UnityEngine;

public class ScaleOnMouseHover : MonoBehaviour
{
    private Vector3 originalScale;
    public Vector3 hoverScale = new Vector3(5f, 5f, 5f);

    void Start()
    {
        originalScale = transform.localScale;
    }

    void OnMouseOver()
    {
        Debug.Log("Hovering");
        transform.localScale = hoverScale;
    }

    void OnMouseExit()
    {
        Debug.Log("Exit");
        transform.localScale = originalScale;
    }
}
