
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitchscript_PK : MonoBehaviour
{
    
    public GameObject camera1;
    public GameObject camera2;
    public GameObject camera3;


    private int currentTarget; //variable declaration
      // "currentTarget" stores the camera that is active 

    void Start()
    {//pls make camera 1 the active camera @gamestart
        currentTarget = 1;
        SetCamera(currentTarget);
    }
    public void SetCamera(int num) ////switch the camera to the number stored in current target 
    {//assigning numbers to each camera game object 

        {
            camera1.SetActive(num == 1);
            camera2.SetActive(num == 2);
            camera3.SetActive(num == 3);
           
        }
        
    }

    }
 