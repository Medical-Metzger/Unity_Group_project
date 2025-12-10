/*The LoadScene class includes a method that allows the developer to load a specified scene by name. This script is used for transitioning between scenes within a 
game or application. By calling the LoadSceneByName method and providing a scene name as a string, the current scene can be replaced with another one defined within the Unity project.
This script is typically used with UI buttons to facilitate scene changes during gameplay or when navigating through menus*/


//the next line imports the System.Collections namespace, which provides classes and interfaces for managing collections, such as lists and arrays. This is useful when working with collections of objects.
using System.Collections;
//the next line imports the System.Collections.Generic namespace, which includes classes for generic collections, such as List<T>, Dictionary<TKey, TValue>, etc. These are often more efficient and type-safe than non-generic collections.
using System.Collections.Generic;
//the next line imports the UnityEngine namespace, which contains the core classes and functions needed for Unity development, including GameObjects, components, and fundamental game logic.
using UnityEngine;
//the next line imports the UnityEngine.SceneManagement namespace, which provides classes and functions for managing scenes within Unity, such as loading, unloading, and transitioning between scenes.
using UnityEngine.SceneManagement;


//This next line declares a public class named LoadScene that inherits from MonoBehaviour. Inheriting from MonoBehaviour allows the class to be attached to GameObjects and enables the use of Unity lifecycle methods.
public class LoadScene : MonoBehaviour


    {
        //This script will load the next scene by name which can then be edited in the inspector inUnity


/*the next line defines a public method named LoadSceneByName that takes a string parameter called sceneName. This method can be called from other scripts or linked to UI elements (like buttons) to 
initiate scene loading based on the provided name*/
        public void LoadSceneByName(string sceneName)


        //Inside the method below, this line calls the LoadScene method from the SceneManager class, passing the sceneName parameter. This action loads the specified scene, which must be defined in the project's build settings.
    {
        SceneManager.LoadScene(sceneName);
    }
    }

