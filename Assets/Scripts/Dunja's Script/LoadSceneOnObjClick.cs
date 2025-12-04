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
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //it creates new ray that starts at the camera and goes through the mouse position
            Debug.DrawRay(ray.origin, ray.direction * 10f, Color.blue); //shows blue ray in scene window and its direction (Matt unity tutorials)

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity)) //ray never stops, returns true when it hits an obj with a collider
            {   
                //if player clicks on certain button (if ray hits specific collider), it loads the next scene by specific name
                if (hit.collider.CompareTag("ClickableBt1")) //using unity's GameObject.CompareTag guidelines script https://docs.unity3d.com/2020.1/Documentation/ScriptReference/GameObject.CompareTag.html
                {
                    Debug.Log("ClickableBt1 clicked");
                    SceneManager.LoadScene("04_IntroToAnneurysm_PK"); 
                }

                if (hit.collider.CompareTag("ClickableBt2"))
                {
                    Debug.Log("ClickableBt2 clicked");
                    SceneManager.LoadScene("05_AortaTerminology_DR");
                }

                if (hit.collider.CompareTag("ClickableBt3"))
                {
                    Debug.Log("ClickableBt3 clicked");
                    SceneManager.LoadScene("06_TypesOfDissection_PK");
                }

                if (hit.collider.CompareTag("ClickableBt4"))
                {
                    Debug.Log("ClickableBt4 clicked");
                    SceneManager.LoadScene("07_Symptoms_PK");
                }

                if (hit.collider.CompareTag("ClickableDoor"))
                {
                    Debug.Log("ClickableDoor clicked");
                    SceneManager.LoadScene("08_TransitionToQuiz_LH");
                }
            }
        }    
    }
}


