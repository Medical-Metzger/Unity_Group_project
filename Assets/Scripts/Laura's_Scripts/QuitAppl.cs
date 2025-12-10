/*The QuitApp script provides a simple way to close an application when the Quit method is called. 
This method is linked to a UI button within the application ("Quit"/"Exit" button) 
so that users can easily exit the application*/

/*This first line imports the System.Collections namespace, which provides classes and interfaces used to 
work with collections such as arrays, lists, and other types of data collections*/
using System.Collections;

/*This next line imports the System.Collections.Generic namespace*/
using System.Collections.Generic;

//This line imports the UnityEngine namespace, which contains the core classes and functionalities required for Unity development, such as GameObjects, components, and basic game logic
using UnityEngine;

/*This next line imports the UnityEngine.SceneManagement namespace, which is responsible for handling scene operations in Unity*/
using UnityEngine.SceneManagement;

//This next line declares a public class named QuitApp, which inherits from MonoBehaviour. Inheriting from MonoBehaviour allows this class to be attached to GameObjects 
public class QuitApp : MonoBehaviour
{
    // this next line of script will quit the application
    public void Quit()
    {

        //This line calls the static Quit() method 
        Application.Quit();

        //This line is useful for debugging or confirming that the quit command was triggered
        Debug.Log("Application has Quit");
    }
}
