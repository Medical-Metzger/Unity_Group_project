using UnityEngine;

public class PlayAnimationOnClick_PK : MonoBehaviour
{
    public Animator animator;
    public string triggerName = "Play";

    public void PlayAnimation()
    {
        animator.ResetTrigger("TrStart");   // clear any previous trigger
        animator.SetTrigger(triggerName);
    
        
    }
}