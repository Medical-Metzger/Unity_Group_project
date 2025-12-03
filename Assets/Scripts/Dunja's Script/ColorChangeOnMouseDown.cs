using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeOnMouseDown : MonoBehaviour
{
    private Renderer myRenderer;
    [SerializeField]

    private Color myInitialColor;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Store our renderer component into myRenderer
        myRenderer = transform.GetComponent<Renderer>();
        //Store the initial material color into myInitialColor
        myInitialColor = myRenderer.material.color;
    }
    

    void OnMouseDown()
    {
        // changes the initial color of the object to red
        myRenderer.material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
