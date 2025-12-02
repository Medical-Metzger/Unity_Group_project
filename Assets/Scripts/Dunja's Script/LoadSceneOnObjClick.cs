using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnObjClick : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // new ray
            Debug.DrawRay(ray.origin, ray.direction * 10f, Color.blue);

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.collider.CompareTag("ClickableBt1"))
                {
                    Debug.Log("Clickable object clicked");
                    SceneManager.LoadScene("04_IntroToAnneurysm_PK");
                }

                if (hit.collider.CompareTag("ClickableBt2"))
                {
                    Debug.Log("Clickable object clicked");
                    SceneManager.LoadScene("05_AortaTerminology_DR");
                }

                if (hit.collider.CompareTag("ClickableBt3"))
                {
                    Debug.Log("Clickable object clicked");
                    SceneManager.LoadScene("06_TypesOfDissection_PK");
                }

                if (hit.collider.CompareTag("ClickableBt4"))
                {
                    Debug.Log("Clickable object clicked");
                    SceneManager.LoadScene("07_Symptoms_PK");
                }

                if (hit.collider.CompareTag("ClickableDoor"))
                {
                    Debug.Log("Clickable object clicked");
                    SceneManager.LoadScene("08_TransitionToQuiz_LH");
                }
            }
        }    
    }
}


