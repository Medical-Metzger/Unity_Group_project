using UnityEngine;

public class ExitGameScript : MonoBehaviour
{
    public void QuitGame()
    {
        // Exits the application
        Application.Quit();

        // For testing in the Unity Editor
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}