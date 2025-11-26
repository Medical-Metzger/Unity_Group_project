
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitchscript_PK : MonoBehaviour
{
    
    public GameObject camera1;
    public GameObject camera2;
    public GameObject camera3;
    public GameObject camera4;

    private int currentTarget;

    void Start()
    {
        currentTarget = 1;
        SetCamera(currentTarget);
    }
    public void SetCamera(int num)
    {

        {
            camera1.SetActive(num == 1);
            camera2.SetActive(num == 2);
        }
        
    }

    }
 