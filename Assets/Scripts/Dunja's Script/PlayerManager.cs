using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;



public class PlayerManager : MonoBehaviour
{
    // references the player manager as a singleton
    public static PlayerManager Instance; 
    
    // references the player object whos position will remain static even after loading other scenes
    //drag the player GameObj into this slot in the inspector; I added a public game object under the PlayerManager to keep things cleaner
    public GameObject player; 

    public List<GameObject> buttonList;


    // awake runs before start so its good for singletons
    void Awake()
    {
        if (Instance == null)
        {
            // this becomes singleton instance
            Instance = this;
            // doesn't destroy the PlayerManager game object when loading other scenes
            DontDestroyOnLoad(gameObject);
            // keeps the same player object alive with a static position even after loading another scene, so it keeps its position
            DontDestroyOnLoad(player);

            for (int i = 0; i < buttonList.Count; i++)
            {
                DontDestroyOnLoad(buttonList[i]);
                PlayerPrefs.SetInt("button" + i, 0);
                Debug.Log(buttonList[i].name + " index of "+ buttonList.IndexOf(buttonList[i]) +  " state is " + PlayerPrefs.GetInt("button" + i));
            }
        }
        else
        {
            // if there is a duplicate GameManager it gets destroyed
            Destroy(gameObject);
            Destroy(player);
        }
    }

    public int CheckPlayerPrefs(GameObject obj)
    {
        //Get from List
        int index = buttonList.IndexOf(obj);
        

        //Change PlayerPrefs
        int state = PlayerPrefs.GetInt("button" + index);
        Debug.Log("Get " + obj.name +" of index " + index + " has state  " + state);
        return state;
    }

    public void ChangePlayerPrefs (GameObject obj)
    {
        Debug.Log("Count " + buttonList.Count);
        //Get from List
        int index = buttonList.IndexOf(obj);
        Debug.Log("Set " + obj.name + " of Index " + index + " to 1");

        //Change PlayerPrefs
        PlayerPrefs.SetInt("button" + index, 1);
    }

    void OnApplicationQuit()
    {
        PlayerPrefs.DeleteAll();
    }
}
