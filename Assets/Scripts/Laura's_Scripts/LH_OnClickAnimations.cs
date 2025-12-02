using UnityEngine;

public class LH_OnClickAnimations : MonoBehaviour
{
    public Animator myAnimator;


    private void Start() 
    {
        myAnimator = this.GetComponent<Animator>();
    }
    public void ButtonClick() 
    {
        myAnimator.SetBool("IsClicked", true);
    }
}
