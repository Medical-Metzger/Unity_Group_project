using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnMouseDown.html
// I wrote this script by looking at Matt’s script intro to scripting #1 – 9.1 – changes color on mouse down
// Matt modified this script together with the PLayerManager script to keep changed color state of my buttons in the corridor static

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

        //CheckPlayerPrefs and change material accordingly
        if (PlayerManager.Instance.CheckPlayerPrefs(gameObject) == 1)  // Matt's script
        {
            //Debug.Log("Change material of " + gameObject.name);
            myRenderer.material.color = Color.red;
        }
        
    }
    
    void OnMouseDown()
    {
        // changes the initial color of the object to red
        myRenderer.material.color = Color.red;

        PlayerManager.Instance.ChangePlayerPrefs(gameObject);  // Matt's script
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
