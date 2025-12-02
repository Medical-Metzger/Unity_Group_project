using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager instance = null;


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
    }

    void Update()
    {
      
    }

    public void OnNextSceneBtClick()
    {
        if(GameManager.instance.sceneIndex >= SceneManager.sceneCountInBuildSettings)
        {
            GameManager.instance.sceneIndex = 1;
        }

        SceneManager.LoadScene(GameManager.instance.sceneIndex);
        GameManager.instance.sceneIndex += 1;
    }
}