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

    public static GameAudioManager_PK instance; //ensures only 1game manager is being used in app
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
            //return; // makes it stop and breaks the loop
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
        {//check 
            musicSource.Stop();
            MusicOn = false;
        }

        //monitoring the clickstate 

        //   public void PlaySFX(AudioClip clip)
        //  {
        //      SFXSource.PlayOneShot(clip);
        //  }

        // public void AddClickSoundToUI()
        //  {//call the private gameobject 
        //   clickButtons = GameObject.FindGameObjectsWithTag("ClickNoise");
        //   foreach (GameObject obj in clickButtons)
        //  {//ascessing each button in the array of buttens tagged ClickNoise 
        //   Button UIbutton = obj.GetComponent<Button>();
        //accessing the list of all UIbutton 
        //  if (UIbutton != null)
        //  {
        //        UIbutton.onClick.AddListener(() => //onclick run this code
        //button is listening for when 
        //
        //        {
        //           SFXSource.PlayOneShot(SFXclip);
        //     });

    }

}