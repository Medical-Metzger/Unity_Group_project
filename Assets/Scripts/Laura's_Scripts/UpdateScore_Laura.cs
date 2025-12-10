/*The UpdateScore_Laura script will update the user's score based on their performance in the quiz (scene 09) and provide the
score in the UI. It facilitates immediate feedback for users, allowing them to see how well they performed based on their answers in real-time. 
This functionality enhances user engagement and experience in the quiz application*/


//This first line of script imports the UnityEngine namespace, which contains core Unity classes and functions essential for Unity development, such as game objects, components, and basic game logic
using UnityEngine;

//This next line of script imports the UnityEngine.UI namespace, which provides classes for creating and managing user interface elements, such as buttons, sliders, and text components
using UnityEngine.UI;

//This next line imports the TMPro namespace, which is associated with TextMeshPro
using TMPro;


//This line declares a public class named UpdateScore_Laura, which inherits from MonoBehaviour. This inheritance allows the class to be attached to a GameObject in Unity and enables the use of Unity's lifecycle methods and features
public class UpdateScore_Laura : MonoBehaviour
{
    //This next line of script contains a public integer variable is used to store the number of correct answers given by the user. It is accessible from other scripts and can be assigned in the Unity Inspector (public)
    public int correctAnswersNb;

    //This public integer variable holds the total number of questions in the quiz
    public int totalQuestionsNb;

    //This public variable holds a reference to a TextMeshProUGUI component, which is a text element in the UI that will display the calculated percentage score
    public TextMeshProUGUI percentageText; // assign in Inspector


    //The next line of script is a private float variable and initializes the percent variable that will hold the calculated percentage score of correct answers. It starts at 0.0f
    float percent = 0.0f;

        //This next line of scrip defines the Start method, which is a built-in Unity method called before the first frame update
        void Start()

        /*This line retrieves the maxQuestionIndex from the QuizManager component attached to the same GameObject and assigns it to the totalQuestionsNb variable. This effectively 
        sets the total number of questions based on the quiz manager's defined maximum*/
    {
        totalQuestionsNb = transform.GetComponent<QuizManager>().maxQuestionIndex;
    }

   //This next line declares a public method named UpdateScoreBtn and is intended to be called when the score display needs to be updated in response to a user completing a question
    public void UpdateScoreBtn()

    //This line retrieves the score from the QuizManager component and assigns it to the correctAnswersNb variable, effectively keeping track of how many questions the user answered correctly
    {
        correctAnswersNb = transform.GetComponent<QuizManager>().score;

        //This next line checks whether totalQuestionsNb is greater than 0, ensuring there are questions to calculate the percentage from. If this condition is true, the code within the subsequent block will be executed
        if (totalQuestionsNb > 0)

        //Inside the 'if' block this line calculates the percentage of correct answers by dividing correctAnswersNb by totalQuestionsNb and multiplying by 100.0f to convert it into a percentage
        percent = correctAnswersNb / totalQuestionsNb * 100.0f;

        //This next line uses the Mathf.Clamp method to ensure that the value of percent is constrained between 0.0f and 100.0f. This prevents erroneous values (like a negative percentage or greater than 100) from being displayed
        percent = Mathf.Clamp(percent, 0.0f, 100.0f);

    // Display as whole number (e.g., 85%)
    //percentageText.text;
    }
}
