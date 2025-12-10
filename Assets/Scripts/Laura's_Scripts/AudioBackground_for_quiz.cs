/*The AudioBackground_for_quiz script plays a background music/audio track when the game (scene 09) starts. This ensures that the audio plays only once, as it checks whether the audio source 
is already playing before calling the Play method*/


using UnityEngine;
using UnityEngine.UIElements;
//the above line (using UnityEngine) imports the UnityEngine namespace, which includes essential classes and functions used in Unity, such as MonoBehaviour and AudioSource
/*the other line, above, contains "UIElements", which allows developers to create UI components (like buttons, panels, text fields) as objects in code, apply styles using, 
and handle events through C# scripts. Overall, this line of code is essential for accessing and using the features provided by UnityEngine.UIElements in Unity scripts*/

/*the script plays an audio clip for background audio for a single scene, the quiz in scene 09, to be subtle yet hopefully engaging and to set this script apart from the rest. This script ensures 
ThemeStyleSheet audio plays only once and doesn't play over itself as it checks if the audio source is already playing before calling the 'play' method. I attached an AudioSource component
to the game object and assigned the audio clip I chose to the 'bgMusic' variable with the Unity Inspector so it functions properly*/

//the next line declares a public class named AudioBackground for the quiz, which inherits from MonoBehaviour; (all scripts that need to be attached to GameObjects must inherit from MonoBehaviour)
public class AudioBackground_for_quiz : MonoBehaviour
{
//the next line defines a public variable of type AudioSource, named bgMusic. It allows you to assign an audio source component from the Unity Editor, which will play the audio clip
    public AudioSource bgMusic;

//the next line refers to the Start method, a built-in Unity method that is automatically called when the script instance is first activated. It’s used to initialize variables or perform actions before the game starts
    void Start()
    {
        /*The next line is a conditional statement that checks two things: if the bgMusic audio source is not null (meaning it has been assigned) and if the audio clip is not currently playing. 
        This prevents the script from trying to play the audio if it has not been set or is already playing*/
        if (bgMusic != null && !bgMusic.isPlaying)
        {
            //the next line is if the conditions in the previous line are met, this line plays the audio clip associated with the bgMusic audio source
            bgMusic.Play();
        }
    }
}