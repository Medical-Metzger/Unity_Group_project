/*this script (ManageQuestion) is designed for a quiz or question-and-answer interactive system in Unity; which is scene 09 in this project. 
This script is attached to a GameObject (a panel) containing the question and the answer toggles within a quiz scene. 
It promotes an interactive experience by allowing users to engage with the quiz and receive immediate feedback based on their answers, 
helping to enhance learning. It allows users to select an answer from a group of toggle buttons representing possible responses.
Upon confirming their selection (by invoking the OnConfirmClick method), it compares the user's selected answer to the correct answer.
Based on the user's selection, the script provides visual feedback:
If the user's answer is correct, it activates a positive feedback UI element (e.g., a message or animation indicating success).
If the answer is incorrect, it activates a negative feedback UI element (e.g., a message indicating failure).
After the user has made a selection, it disables all toggle buttons, preventing further interaction until the next question is loaded.
*/

//the first line of script, below, imports the System.Collections namespace, which provides classes and interfaces used to work with collections such as lists and arrays.
using System.Collections;
//the next line imports the System.Collections.Generic namespace, which includes classes for generic collections (e.g., List<T>, Dictionary<TKey, TValue>), which are commonly used for type-safe collections.
using System.Collections.Generic;
//the next line of script imports the System.Linq namespace, which provides classes and methods for Language-Integrated Query (LINQ). LINQ is used for querying collections in a more readable and concise way.
using System.Linq;
//the next line imports the UnityEngine namespace, which contains the core Unity functionalities, including scripts, components, and basic game objects.
using UnityEngine;
//the next line imports the UnityEngine.UI namespace, which includes classes for creating and managing user interface elements, such as buttons, sliders, and toggles.
using UnityEngine.UI;


//the next line declares a public class named ManageQuestion that inherits from MonoBehaviour. This allows the class to be attached to a GameObject in Unity and utilize Unity-specific functionality.
public class ManageQuestion:MonoBehaviour


//the next line declares a public variable of type GameObject named userResponse, which will store a reference to the user's selected answer.
{
    public GameObject userResponse;

//This next line declares another public GameObject variable named correctResponse, which will store a reference to the correct answer for the current question.
    public GameObject correctResponse;



    [SerializeField]

    /*the next line declares a private variable of type GameObject named positiveFeedback, which is marked with [SerializeField], allowing it to be assigned in the Unity Inspector even 
    though it’s private. This GameObject is used to show positive feedback to the user*/
    private GameObject positiveFeedback;

    [SerializeField]

    //Similar to the previous line, this declares a private variable named negativeFeedback to show negative feedback and is also serialized for inspection and assignment in the Unity Inspector.

    private GameObject negativeFeedback;

    [SerializeField]
    //This line declares a private variable called myToggleGroup, which is a reference to a ToggleGroup. This will manage a group of toggle buttons, allowing for only one to be selected at a time.
    private ToggleGroup myToggleGroup;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    //This Update method is another built-in Unity method that is called once per frame. It is also empty in this instance, meaning no logic is executed during the update cycle.
       void Update()
    {
        
    }

    //This next line defines a public method called OnConfirmClick. This method is intended to be called when the user confirms their answer, such as by pressing a button.
    public void OnConfirmClick()
    {
        /*Compare user answer vs correct answer -- this next line retrieves the currently active toggle (the selected answer) from the myToggleGroup using LINQ. It calls ActiveToggles(), 
        which returns a collection of active toggles, and FirstOrDefault() gets the first toggle in that collection or null if none are active.()*/
        Toggle selectedToggle = myToggleGroup.ActiveToggles().FirstOrDefault();

        //Here, the script assigns the GameObject of the selected toggle (the user's response) to the userResponse variable.
        userResponse = selectedToggle.gameObject;

        //This comment indicates that the following code will make all toggle buttons non-interactive (disabled) after the user makes their selection.
        for (int i = 0; i < myToggleGroup.transform.childCount; i++)

        /*The next line of code iterates through each child toggle GameObject of the myToggleGroup. Retrieves each Toggle component. Disables all toggles in the group to prevent further user interaction after the user has made a 
        selection and confirmed their answer. This is an important part of the user interface's logic in a quiz or question-answer application, as it ensures that the user cannot change their answer after 
        making a selection, simplifying the flow for processing the result*/

        {
            myToggleGroup.transform.GetChild(i).GetComponent<Toggle>().interactable = false;
        }

        /*for the next bit of code, it handles response validation in a quiz application. When the user confirms their answer:
        If the answer is correct, positive feedback is displayed, and the score in the QuizManager is incremented.
        If the answer is incorrect, negative feedback is displayed instead.
        This logic is part of providing immediate feedback to users, enhancing their interactive experience in a quiz or learning scenario*/

        if (userResponse == correctResponse)
        {
            //Show Positive Feedback
            positiveFeedback.SetActive(true);

            transform.parent.GetComponent<QuizManager>().score += 1;
        }
        else
        {
            //Show Negative Feedback
            negativeFeedback.SetActive(true);
        }
    }
}
