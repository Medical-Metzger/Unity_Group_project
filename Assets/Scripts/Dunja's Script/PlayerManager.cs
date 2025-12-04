using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    // references the player manager as a singleton
    public static PlayerManager Instance; 
    
    // references the player object whos position will remain static even after loading other scenes
    //drag the player GameObj into this slot in the inspector; I added a public game object under the PlayerManager to keep things cleaner
    public GameObject player; 

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
            DontDestroyOnLoad(player);
        }
        else
        {
            // if there is a duplicate GameManager it gets destroyed
            Destroy(gameObject);
            Destroy(player);
        }
    }
}
