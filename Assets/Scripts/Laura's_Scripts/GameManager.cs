using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public int sceneIndex = 1; //starts at 1 because im already at scene 0 

    public static GameManager instance = null; //ensures only 1game manager is being used in app

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return; // makes it stop and breaks the loop
        }


        DontDestroyOnLoad(this); //putting (gameObject) works equally
        Init();
    }

    void Init()
    {
        SceneManager.LoadScene(sceneIndex);
        sceneIndex += 1; //ensures next scene loads
    }
}