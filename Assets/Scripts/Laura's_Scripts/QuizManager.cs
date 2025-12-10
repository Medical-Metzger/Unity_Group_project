
/*This QuizManager script is important for the functioning of the quiz (scene 09), it manages the functionality of the quiz - handling the display of questions, tracking user rsponses, and calculating final scores.
It streamlines user engagement by managing question flow, score tracking, and UI display for a smooth and interactive learning experience*/

//This next line imports the System.Collections namespace
using System.Collections;

//This next line imports the System.Collections.Generic namespace, which provides classes for generic collections
using System.Collections.Generic;

//This next line imports the UnityEngine namespace, which contains core functions and classes vital for Unity development, including game objects and components.
using UnityEngine;

//This next line imports the UnityEngine.UI namespace, which provides classes for creating and managing user interface elements such as buttons and text.
using UnityEngine.UI;

//This next line imports the TMPro namespace, which is used for TextMeshPro, it provides enhanced text formatting and appearance options.
using TMPro;


//This next line declares a public class named QuizManager that inherits from MonoBehaviour
public class QuizManager : MonoBehaviour

//This public integer variable specifies the maximum number of questions allowed in the quiz. It is initialized to 5
{
    public int maxQuestionIndex = 5;

    //This public integer variable tracks the current question index that the user is on, starting at 0 (the first question)
    public int myQuestionIndex = 0;

    //This public list variable holds a collection of GameObjects, each representing a question in the quiz. These can be assigned in the Unity Inspector
    public List<GameObject> questionList;


    //This next private variable is serialized for visibility in the Inspector, stores a reference to the UI panel that displays results after the quiz finishes
    [SerializeField]
    private GameObject finalPanel;

    [SerializeField]
    private GameObject percentFinalPanel;
  
    //This next private variable holds a reference to a UI element used to display the user's score
    [SerializeField]
    private GameObject scoreIndicator; //the is the textbox for the score


    //This attribute creates a header in the Unity Inspector for better organization of related fields visually
    [Header("Score Panels")]

    [SerializeField]
    //This next private variable references the UI panel shown to users who pass the quiz
    private GameObject passPanel; //this is for the people who pass the quiz

    [SerializeField]
    //The following private variable references the UI panel shown to users who fail the quiz
    private GameObject retryPanel; //this is for the people who did not
    
    //The following public integer variable tracks the user's score throughout the quiz, initialized to 0
    public int score = 0; 
    

    //This next part creates a header in the Unity Inspector, for fields related to score percentage
    [Header("Score Percentage")]

    //This next public integer variable tracks the number of correct answers the user gives during the quiz
    public int correctAnswersNb;

    //The next public integer variable holds the total number of questions presented in the quiz
    public int totalQuestionsNb;

    //This public variable holds a reference to a TextMeshProUGUI component for displaying the percentage score of correct answers, which needs to be assigned in the Unity Inspector
    public TextMeshProUGUI percentageText; // assign in Inspector

    //This private float variable initializes the percentage score for correct answers to 0.0f
    float percent = 0.0f;


    

    /*This next private variable is a reference to an IEnumerator type, used for coroutines in Unity. It will manage coroutine operations for waiting before executing the next action. 
    For scene 09, I used it to pause the game and let a UI button animate a few seconds before progressing to the quiz questions
    */

    private IEnumerator myLHCoroutine;
   
    // Start is called before the first frame update
    void Start()
    {
     
    //OnClickNext();
        /*print("Starting " + Time.time);
        myLHCoroutine = LHCoroutine(2.0f);
        StartCoroutine(myLHCoroutine);*/
        totalQuestionsNb = transform.GetComponent<QuizManager>().maxQuestionIndex;
    }

    /*  5 Question Max 
    Express as fraction out of 5 
    Must get 3 to pass 

    need to use the if/else statements to check for int i>3 then SetActive a UI panel assigned in the scripts as a public GameObject passPanel / redoPanel
    */

    // Update is called once per frame
    void Update()
    {
           //CheckScore();
           //UpdateScoreBtn();
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
            percentFinalPanel.SetActive(true);

            scoreIndicator.GetComponent<TextMeshProUGUI>().text = scoreIndicator.GetComponent<TextMeshProUGUI>().text + score;
            percentageText.text = ((int)((float)score/(float)maxQuestionIndex*100.0f)).ToString() + "%";


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

    //this gives a wait/pause of 2 seconds for the animated UI button to 'do it's thing' 
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

        //the next line of script declares a public method named CheckScore. Making it public allows this method to be called from other scripts or UI elements (like buttons).
        public void CheckScore()
    {
        
        //the next line checks if the score variable (which keeps track of the user's score) is less than 1. If true, the body of this conditional statement will execute
        if(score < 1)

        //This next line outputs a message to the Unity Console using Debug.Log(). It prints "Score is " followed by the current value of score, which is useful for debugging and confirming the score has been checked
        {
            Debug.Log("Score is " + score);

            //this next line activates the retryPanel GameObject (a UI element) to become visible. This panel is shown when the user's score is less than 1, indicating they need to try the quiz again or that they did not pass
            retryPanel.SetActive(true);
        }

        //This next line checks if the score is greater than 1. If this condition is true, the code block that follows will execute, indicating the user performed well
        if(score > 1)

        //Similar to the previous Debug.Log, this line prints "Score is " followed by the current value of score to the Unity Console. It helps track the current score during execution
        {
            Debug.Log("Score is " + score);

            //This next line activates the passPanel GameObject (another UI element) to display to the user. This panel is shown when the user's score is greater than 1, indicating they have passed the quiz
            passPanel.SetActive(true);
        }
    }

    //This line declares a public method named UpdateScoreBtn. This method is likely called to update the score display shown on the UI
     public void UpdateScoreBtn()
    {
            // Display as whole number (e.g., 85%); display a percentage as a whole number; This line retrieves the score from the QuizManager component attached to the same GameObject as this script. 
            // It assigns the value of score to the correctAnswersNb variable, which tracks the number of correct answers given by the user
            //percentageText.text;
        correctAnswersNb = transform.GetComponent<QuizManager>().score;

    //This next line checks whether the totalQuestionsNb (the total number of questions in the quiz) is greater than 0. This condition ensures that there are questions to calculate the percentage from before proceeding
        if (totalQuestionsNb > 0)

        /*If the condition is met, this line calculates the percentage of correct answers:
        It divides correctAnswersNb (the number of correct answers) by totalQuestionsNb (the total questions) and multiplies by 100.0f to get the percentage score*/
        percent = correctAnswersNb / totalQuestionsNb * 100.0f;

        //This next line uses the Mathf.Clamp method to restrict the value of percent between 0.0f and `100
        percent = Mathf.Clamp(percent, 0.0f, 100.0f);

    }
}