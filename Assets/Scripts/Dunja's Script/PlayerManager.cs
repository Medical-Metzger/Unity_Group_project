using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;


// I made this script because I wanted the player to not respawn at the egining of the corridor everytime they loaded a new scene
// I named it player manager because we already have a main game manager, this one was meant t only manage the player position using the Singleton function
// A singleton enforces the existence of only 1 object of a specific type at any given moment and destroys duplicates which is why i decided to go with it
// I tried to create a script following Matt’s game manager video 6 week 9 and decided to make an empty game object PlayerManager as a sub game manager
// Another source that helped me write my script was reddit  https://www.reddit.com/r/Unity3D/comments/133tvxw/how_to_preserve_player_position_when_changing/
public class PlayerManager : MonoBehaviour
{
    // referencing the player manager as a singleton function
    public static PlayerManager Instance; 
    
    // referencing the player object (in my case capsule named player) whos position will remain static even after loading other scenes
    // drag the player GameObj into this slot in the inspector; I added a public game object under the PlayerManager to keep things cleaner and more understandable for myself
    public GameObject player; 
    // Matt modified my script so that buttons in corridor stay red after loading another scene and returning to old scene because my ColorChangeManager script failed
    // I figured since my player manager script ended up working I'd use the simpleton function for colors as well but it wasn't that simple and I didn't know how to proceed
    public List<GameObject> buttonList; //Matt


    // awake runs before start so its good for singletons
    void Awake()
    {
        if (Instance == null)
        {   
            // this becomes singleton instance
            Instance = this;
            // doesn't destroy the PlayerManager game object when loading other scenes
            DontDestroyOnLoad(gameObject);
            // It didn't work, the camera and player gameobj returned to starting scene while the capsule remained static in front of the button detached so I tried to reference the player in as well
            //this worked
            DontDestroyOnLoad(player);

            for (int i = 0; i < buttonList.Count; i++) //Matt's script
            {
                DontDestroyOnLoad(buttonList[i]);
                PlayerPrefs.SetInt("button" + i, 0);
                //Debug.Log(buttonList[i].name + " index of "+ buttonList.IndexOf(buttonList[i]) +  " state is " + PlayerPrefs.GetInt("button" + i));
            }
        }
        else
        {
            // if there is a duplicate GameManager it gets destroyed
            Destroy(gameObject);
            Destroy(player);
        }
    }

    public int CheckPlayerPrefs(GameObject obj) // Matt's script
    {
        //Get from List
        int index = buttonList.IndexOf(obj);
        

        //Change PlayerPrefs
        int state = PlayerPrefs.GetInt("button" + index);
        //Debug.Log("Get " + obj.name +" of index " + index + " has state  " + state);
        return state;
    }

    public void ChangePlayerPrefs (GameObject obj) // Matt's script
    {
        //Debug.Log("Count " + buttonList.Count);
        //Get from List
        int index = buttonList.IndexOf(obj);
        //Debug.Log("Set " + obj.name + " of Index " + index + " to 1");

        //Change PlayerPrefs
        PlayerPrefs.SetInt("button" + index, 1);
    }

    void OnApplicationQuit() //Matt's script
    {
        PlayerPrefs.DeleteAll();
    }
}
