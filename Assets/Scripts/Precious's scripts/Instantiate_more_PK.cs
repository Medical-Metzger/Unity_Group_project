using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiate_more_PK : MonoBehaviour
{
    public GameObject Capsule;
    public float spawnRate = 0.2f;   // starting spawn rate

    private bool spawning = false;
    private Coroutine spawnRoutine; //stores reference to the coroutine 
    private static List<GameObject> spawnedClones = new List<GameObject>();
    // track clones made by all instances of this script 

    public void ToggleSpawn()
    {
        // DOUBLE THE SPAWN RATE EVERY TIME YOU PRESS THE BUTTON
        spawnRate *= 2f;

        Debug.Log("New spawn rate: " + spawnRate);

        if (!spawning) 
//if not currently spawning, if spawning=false
        { //make spawning true
            spawning = true;
            spawnRoutine = StartCoroutine(SpawnLoop()); //start spawnloop
        }
//if spawning = true 
        else //stop currrent loop and start new loop at double speed 
        {
            StopSpawning();//stop old spawner
            spawning = true; //start new spawner 
            spawnRoutine = StartCoroutine(SpawnLoop()); 
        }

        
    }

    IEnumerator SpawnLoop()
    {
        spawning = true;

        while (spawning)
            {
            //make sure the spawn position is close to the capsule
//without this offset there was a large gap between 
            Vector3 offset = transform.forward * 0.001f;
            //make clone of obj at spawner position +offset

    GameObject clone = Instantiate(Capsule, transform.position+offset, Quaternion.identity);
    spawnedClones.Add(clone); // add to list when new clone spawned

            //extract rigidbody component from clone to apply physics
            Rigidbody rb = clone.GetComponent<Rigidbody>();

            {
//returns random point inside a sphere 
//*0.2f multiply to make the clone slightly smaller
                Vector3 randomDirection = (transform.forward + Random.insideUnitSphere * 0.2f);
                rb.linearVelocity = randomDirection* 30f; 
            }//apply velocity 

            yield return new WaitForSeconds(0.4f / spawnRate);
//wait for x before next update, x = 0.4 divided by number of red blood cells 
        }
    }

    //manual stop spawn method 
    public void StopSpawning()
    {//if spawnroutine is running and stop spawning is called
        if (spawnRoutine != null)   
        {                              
            StopCoroutine(spawnRoutine);//stop  spawn loop
            spawnRoutine = null; //reset reference to spawn routine
            spawning = false; // reset the spawn state 

        }
    }


    public void DestroyThemAll()
    {
      
        StopSpawning();
//for every clone in  my defined list spawnedclones
        foreach (GameObject clone in spawnedClones)
        {//check if clone false = untrue, if clone false is untrue and
         //the existence of the clone is actually true
            if (clone != null) 
                Destroy(clone);     //destroy the clone
        }
        
        spawnedClones.Clear(); // reset the list
      
    }
}


