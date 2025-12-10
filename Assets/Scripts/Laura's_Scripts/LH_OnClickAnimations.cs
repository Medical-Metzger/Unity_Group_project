/*This script controls animation in response to button clicks. When the associated GameObject is started, it automatically retrieves its Animator component. When the ButtonClick 
method is invoked (presumably by a button click event), it sets the IsClicked parameter of the Animator to true, triggering any animations defined in the Animator Controller that respond to this parameter
This script is used to animate UI elements or objects when a button is clicked, utilizing Unity's Animator system for smoothly handling animation states*/

//the next line imports the UnityEngine namespace, which contains essential classes and functions needed to interact with Unity's core features, including game objects, components, and animations.
using UnityEngine;

//the next line declares a public class named LH_OnClickAnimations that inherits from MonoBehaviour. This inheritance allows the class to be attached to GameObjects in the Unity editor and enables the use of Unity lifecycle methods.
public class LH_OnClickAnimations : MonoBehaviour
{
    
    /*the next line This line declares a public variable of type Animator, named myAnimator. This variable will hold a reference to an Animator component that handles animation states and transitions. Making it public allows you to 
    assign an Animator component directly from the Unity Inspector*/

    public Animator myAnimator;


//This is the definition of the Start method, a built-in Unity method that is called just before any of the Update methods. It’s used for initialization tasks.
    private void Start() 
    {
        /*This next line retrieves the Animator component attached to the same GameObject as this script using GetComponent<Animator>() and assigns it to the myAnimator variable. It ensures that the Animator is correctly referenced 
        by this script, allowing it to control animations*/

        myAnimator = this.GetComponent<Animator>();

        //This next line defines a public method named ButtonClick, which can be called from other scripts or events (like UI button clicks). This method is typically linked to UI button actions to trigger animations.
    }
    public void ButtonClick() 

    /*Inside the ButtonClick method, this line sets a boolean parameter named IsClicked in the Animator to true. This parameter needs to be defined in the Animator Controller. Setting this parameter to true will trigger any 
    animation transitions that are configured to respond to changes in the IsClicked boolean state*/
    {
        myAnimator.SetBool("IsClicked", true);
    }
}
