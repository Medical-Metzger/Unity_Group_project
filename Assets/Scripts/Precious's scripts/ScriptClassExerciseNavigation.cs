using UnityEngine;


/*This script is a class exercise that we will go through together.*/
public class ScriptClassExerciseNavigation : MonoBehaviour
{

    /*
    Last week we looked at pressing a key to move something per frame rate. 
    The potential problems we had with this is that the speed of movement is determine by the frame rate. 
    In this script we are going to need to create a method to have the speed effected by real time. 

    We are going to use the same input to press a key but this time we are going to tell the code to 
    make something move, or rotate.

    To do this we need a few things:
    1. We need a public float as a variable as the value for the speed.
    2. We need to create a method that is programmed to utilize better directions and more universal rather than "hard code"
    3. We need to tell the code to reference the point from which the direction should be based (Space.World(Universal Direction - Up is always the global Up) Space.Self( Self-Referential Direction, the object has its own direction, and transform.Up, Space.Self with move up in the direction of the Game Objects Y Axis))
    4. We need to tell the the code to check for this input, apply the speed variable that we assign, multiple this by RealTime and determine the referential space this direction should be.
    5. The method is the same as before but this time we are going to put in different "arguments"

    This is the old method:

      if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0,1,0);//old way of moving - moves 1 unit per frame and this assigns the values as "arguments)
            
            ^This is "hard-coded" because the variable value is set to a constant value in the function itself.
            This is a bad way to do things, because imagine you had lots of values hard-coded, and had to change them during testing
            It is better to use variables to replace values and you can access and change them more easily

            
        }
        
      This is the new method:

    Step 1:
      We need to create a variable for the Speed

            public float mySpeed;

      or

            public float mySpeed = 100;

      Both are correct.
      You can tell me why one is used over the other.

    Step 2:
      We need to create a Method for the movement.

        void BetterMovement()
        {
        
        }

    Step 3:
        We need to update the function we have to reflect the changes we want.

        void BetterMovement()
        {
            if(Input.GetKey(KeyCode.UpArrow))
            {
                    transform.Translate(0,1,0);//we need to change the stuff inside the brackets

                    transform.Translate(transform.forward*mySpeed*Time.deltaTime, Space.World)
                    ^This is the correct way to write this (directionalinput*SpeedVariable*RealTime, GlobalReference)

                    //The instruction for the DownArrow could be:
                    transform.Translate((-1)*transform.forward*mySpeed*Time.deltaTime, Space.Self)
                    ^This instruction multiplies by the -1 to get the negative direction, and moves in real time but to the GameObjects Local Direction

                    Try both self and global to see what you like.
                    Map to other keys and try write this code for the transform.up and transform.right varibles of the transform.Translate Class
                    Try write the (-1) versions. 

                    Remember to "call" the method in the update to run it.
                    
                    
            }
        }


    */

    //Keyboard Input

    public float mySpeed;//my speed variable
    //remember to set the values in the Inspector in Unity

    void Update()
    {
        BetterMovement();//Uncomment this name by deleting the // before the namespace to call this method.
    }

    

    void BetterMovement()//this script moves GameObjects in RealTime
    {
         if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(transform.forward*mySpeed*Time.deltaTime, Space.World);//old way of moving - moves 1 unit per frame 
            Debug.Log("Up Arrow is pressed and the position is " + transform.position);
        }
        
        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate((-1)*transform.forward*mySpeed*Time.deltaTime, Space.World);//new way of moving
            Debug.Log("Down Arrow is pressed and the position is " + transform.position);
        }
           if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate((-1)*transform.right*mySpeed*Time.deltaTime, Space.World);//old way of moving - moves 1 unit per frame  
            Debug.Log("Left Arrow is pressed and the position is " + transform.position);
        }
        
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(transform.right*mySpeed*Time.deltaTime, Space.World);//old way of moving - moves 1 unit per frame  
            Debug.Log("Right Arrow is pressed and the position is " + transform.position);
        }
    }



}

 
