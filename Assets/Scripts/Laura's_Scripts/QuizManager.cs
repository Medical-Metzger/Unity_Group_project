using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuizManager : MonoBehaviour
{
    public int maxQuestionIndex = 5;

    public int myQuestionIndex = 0;

    public List<GameObject> questionList;

    [SerializeField]
    private GameObject finalPanel;
  
    [SerializeField]
    private GameObject scoreIndicator; //the is the textbox for the score


    [Header("Score Panels")]

    [SerializeField]
    private GameObject passPanel; //this is for the people who pass the quiz

    [SerializeField]
    private GameObject retryPanel; //this is for the people who did not
    
    public int score = 0; 
    
    /*
    5 Question Max 
    Express as fraction out of 5 
    Must get 3 to pass 

    need to use the if/else statements to check for int i>3 then you will SetActive a UI panel you assign in the scripts as a public GameObject passPanel / redoPanel

    */

    private IEnumerator myLHCoroutine;
   
    // Start is called before the first frame update
    void Start()
    {
    //OnClickNext();
        /*print("Starting " + Time.time);
        myLHCoroutine = LHCoroutine(2.0f);
        StartCoroutine(myLHCoroutine);*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickNext()
    {
        if (myQuestionIndex < maxQuestionIndex)
        {
            int index = Random.Range(0,questionList.Count);

            //retrieve Question from the List& Set Question to visible
            questionList[index].SetActive(true);

            //Remove Question from List
            questionList.RemoveAt(index);

            //increase myQuestion Index value
            myQuestionIndex +=1;
        }
        else
        {
            /*
                we can either change the ending to only setactive the pass or fail panel 
                OR 
                calculate the score and thjen show the pass/fail panel 

            
            */
            //Show the Score panel
            
            finalPanel.SetActive(true);

            scoreIndicator.GetComponent<TextMeshProUGUI>().text = scoreIndicator.GetComponent<TextMeshProUGUI>().text + score;

            CheckScore();

            //if statement to check the score int value and if this equals =>3 show the pass panel
            // if the int score is =<3 show the fail panel 

            /*
            */

            Debug.Log("End");
        }
    }

    /*Here is the coroutine functions, add the ButtonClickStartCoroutine method to your buttons in Unity in the inspector */

    public void ButtonClickStartCoroutine()
    {
        print("Starting " + Time.time);
        myLHCoroutine = LHCoroutine(0.01f);
        StartCoroutine(myLHCoroutine);
    }

    public IEnumerator LHCoroutine(float waitTime)
    {
       waitTime = 2.0f;
            print("Waited for " + Time.time);
            yield return new WaitForSeconds(waitTime);
            OnClickNext();
            StopCoroutine(nameof(myLHCoroutine));
       
        /*for (int i = 0; i < 5; i++)
        {
            waitTime = 2.0f;
            print("Waited for " + Time.time);
            yield return new WaitForSeconds(waitTime);
            OnClickNext();
            StopCoroutine(nameof(myLHCoroutine));
            //yield return null;
        }*/
    }

    public void CheckScore()
    {
        
        if(score < 1)
        {
            Debug.Log("Score is" + score);
            retryPanel.SetActive(true);
        }

        if(score > 1)
        {
            Debug.Log("Score is" + score);
            passPanel.SetActive(true);
        }
    }
}