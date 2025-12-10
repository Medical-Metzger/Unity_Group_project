/*This script (GameManager class) serves as a singleton that manages the game's scenes. It ensures that only one instance exists regardless of how many times it tries to create a new one and keeps the game manager alive across scene transitions. When initialized, 
it loads the first scene defined by sceneIndex, incrementing the index ready to load subsequent scenes in future calls*/

using UnityEngine;
using UnityEngine.SceneManagement;
//the first line, above, imports the UnityEngine namespace, which contains essential classes and functions that are required to work with Unity's core functionality, including game objects, components, and general game logic.
//the line below the top one, above, imports the SceneManagement namespace, which provides classes and functions specifically for managing scenes within the Unity game. It includes methods to load, unload, and manage different scenes in the game.

//the next line declares a public class named GameManager that inherits from MonoBehaviour. By inheriting from MonoBehaviour, this class can be attached to a GameObject in Unity and can use Unity's event functions.
public class GameManager : MonoBehaviour
{
    /*the next line declares a public integer variable called sceneIndex, initializing it to 1. It is used to keep track of the current scene to load next. It starts at 1 because the initial scene (typically 
    the first scene loaded) is assumed to be indexed as 0*/
    public int sceneIndex = 1; //starts at 1 because im already at scene 0 

    //for the next line, a static variable named instance of type GameManager is declared and initialized to null. This variable serves as a singleton, ensuring that only one instance of the GameManager exists throughout the application.
    public static GameManager instance = null; //ensures only 1game manager is being used in app

    //The next line is the definition of the Awake method, a built-in method called when the script instance is being loaded. It is useful for initialization before any Start methods are called.
    void Awake()

        //This next line checks if the instance variable is null, which means no GameManager instance has been created yet.
    {
        if (instance == null)

        //the next line reads "if instance is null", the current instance of GameManager (referenced by this) is assigned to the instance variable, marking it as the active game manager.
        {
            instance = this;
        }

        /*for the next part, If instance is not null, it means a GameManager instance already exists. In that case, the current instance (the duplicated one) is destroyed using Destroy(gameObject), and the return statement exits 
        // the Awake method, preventing further execution*/
        else
        {
            Destroy(gameObject);
            return; // makes it stop and breaks the loop
        }

        /*the next line prevents the GameManager instance from being destroyed when loading new scenes. It allows the game manager to persist across different scenes in the game. You could also use 
        DontDestroyOnLoad(gameObject) to achieve the same effect*/
        DontDestroyOnLoad(this); //putting (gameObject) works equally

        //the next line calls the Init method, executing any initialization code defined in that method immediately after the GameManager has been set up.
        Init();
    }

        //the next line defines the Init method, which is called to perform additional initialization tasks for the GameManager.
        void Init()
    {
        //the next line uses the SceneManager to load the scene specified by sceneIndex. This will transition the game to the scene indicated by the current value of sceneIndex.
        SceneManager.LoadScene(sceneIndex);

        //After loading the current scene, this next line increments sceneIndex by 1, it makes sure that the next time Init() is called, it will load the next scene in the sequence.
        sceneIndex += 1; //ensures next scene loads
    }
}