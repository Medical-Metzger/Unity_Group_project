using UnityEngine;

// I made this script because I locked my cursor to the center for my corridor scene for better camera rotating and movement,
// but then i discovered that it stays hidden as well as locked which was a problem for the next scenes that loaded
// here are the sources I used to do research and write this script https://docs.unity3d.com/ScriptReference/Cursor-lockState.html , https://discussions.unity.com/t/locking-mouse-to-center-of-screen-but-keep-it-visible/851122

public class CursorManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.None; // the mouse's state isnt being locked to the center of the screen
        Cursor.visible = true; // cursor becomes visible
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

