using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
    {
        //This script will load the next scene by name which can then be edited in the inspector inUnity

        public void LoadSceneByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    }

