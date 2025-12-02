using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager_PK : MonoBehaviour
{
    public static UIManager_PK instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); 
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    public void OnNextSceneBtClick()
    {
        if (GameManager.instance.sceneIndex >= SceneManager.sceneCountInBuildSettings)
        {
            GameManager.instance.sceneIndex = 1;
        }

        SceneManager.LoadScene(GameManager.instance.sceneIndex);
        GameManager.instance.sceneIndex += 1;
    }
}