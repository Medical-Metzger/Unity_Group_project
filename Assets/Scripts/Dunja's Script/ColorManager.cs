using UnityEngine;
using UnityEngine.SceneManagement;

// This script isn't in use, this was my failed attempt at using the same singleton function code i used before to keep state of color
public class ColorManager : MonoBehaviour
{
    // references the color manager as a singleton
    public static ColorManager Instance; 
    
    // references the color that will remain static even after loading other scenes
    // drag the color into this slot in the inspector 
    public Color red = Color.red; 

    // awake runs before start so its good for singletons
    void Awake()
    {
        if (Instance == null)
        {
            // this becomes singleton instance
            Instance = this;
            // doesn't destroy the PlayerManager game object when loading other scenes
            DontDestroyOnLoad(gameObject);
            // keeps the same player object alive with a static position even after loading another scene, so it keeps its position
            
        }
        else
        {
            // if there is a duplicate GameManager it gets destroyed
            Destroy(gameObject);
            
        }
    }
}
