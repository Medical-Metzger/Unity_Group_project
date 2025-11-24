using UnityEngine;

public class SpacebarToDestroy : MonoBehaviour
{
      
    // This method will destroy any object that has this script attached when spacebar is hit
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject.Destroy(gameObject);
        }

        
        
    }

    
}
