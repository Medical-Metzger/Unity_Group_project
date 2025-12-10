using System.Collections.Generic;
using UnityEngine;

public class GameAudioManager_PK : MonoBehaviour
{
    [SerializeField]
    AudioSource musicSource;
    AudioSource SFXsource;

    //creating audiosource reference using code from AudioBackground_for_quiz

    public AudioClip Hallwayclip;
    public bool MusicOn = true;
    public static GameAudioManager_PK instance;
    //static reference so all instances of the script communicate
    void Awake()
    {
        if (instance == null)
        {//if there is no instance of game manager make this instance the game manager
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            //if there is an instance of game manager currently on destroy it
            //(might be a duplicate)
            Destroy(gameObject);
           
        } 
    }
    private void Start()
    {
        musicSource.clip = Hallwayclip;
        musicSource.Play();
        MusicOn = true;
    }


    public void TurnOffMusic()
    {
        if (MusicOn)
        {//check if bool is true
            musicSource.Stop();
            MusicOn = false;
        }//reset the flag

    }

    public void TurnONMusic()
    {
        if (!MusicOn)
        {//check if bool is fake
            musicSource.Play();
            MusicOn = true;
        }//reset the flag

    }

}
        
    

