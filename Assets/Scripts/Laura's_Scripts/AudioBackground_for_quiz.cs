using UnityEngine;

//plays audio clip for background audio
public class AudioBackground_for_quiz : MonoBehaviour
{
    public AudioSource bgMusic;

    void Start()
    {
        if (bgMusic != null && !bgMusic.isPlaying)
        {
            bgMusic.Play();
        }
    }
}