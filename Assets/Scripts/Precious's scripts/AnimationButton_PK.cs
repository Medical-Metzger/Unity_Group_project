using UnityEngine;
using UnityEngine.UI;

public class AnimationButton_PK : MonoBehaviour
{
    public Animator animator; // Drag your Animator component here in the Inspector
    public string animationName = "bursting_3D_PK"; // The name of the animation state in your Animator Controller
    public Button button; // Drag your Button here in the Inspector

    void Start()
    {
        // Ensure the button is not null
        if (button == null)
        {
            Debug.LogError("Button is not assigned! Please assign the button in the Inspector.");
            return;
        }

        // Add a listener to the button's onClick event
        button.onClick.AddListener(PlayAnimation);
    }

    // This function will be called when the button is clicked
    public void PlayAnimation()
    {
        // Ensure the animator is not null
        if (animator == null)
        {
            Debug.LogError("Animator is not assigned! Please assign the animator in the Inspector.");
            return;
        }

        // Trigger the animation
        animator.Play(animationName);
    }
}