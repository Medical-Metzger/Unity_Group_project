using UnityEngine;


/*This script is a class exercise that we will go through together.*/
public class ScriptClassExercise : MonoBehaviour
{
    
/*
Last week we looked at pressing a key to action something. 

We are going to use the same input to press a key but this time we are going to tell the code to 
make something move, or rotate.

I will put a few methods down and you can help me work them out together in class. 


*/

//Keyboard Input
    
    void Update()
    {
        
         if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0,1,0); 
            Debug.Log("Up Arrow is pressed and the position is " + transform.position);
        }
        
        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0,-1,0); 
            Debug.Log("Down Arrow is pressed and the position is " + transform.position);
        }
           if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(1,0,0); 
            Debug.Log("Left Arrow is pressed and the position is " + transform.position);
        }
        
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(-1,0,0); 
            Debug.Log("Right Arrow is pressed and the position is " + transform.position);
        }
    }

    



/*Spot the difference between these two debug.log commands [HARD]
To test, add script to object and Active/Deactivate this and read the console error
*/
    void OnEnable()
    {
        Debug.Log("Sphere is enabled " + name);
    }

      void OnDisable()
    {
        Debug.Log("Sphere is disabled" + name);
    }


}

//btw have you noticed the different green text comment formats in this script? 
