using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitApp : MonoBehaviour
{
    // this script will quit the application
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Application has Quit");
    }
}
