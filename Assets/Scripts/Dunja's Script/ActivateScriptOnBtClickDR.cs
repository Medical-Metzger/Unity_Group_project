using UnityEngine;

public class ActivateScriptOnBtClickDR : MonoBehaviour
{
    [SerializeField] private GameObject myScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void onClick() 
    {
    myScript.SetActive(true);
    }
}
