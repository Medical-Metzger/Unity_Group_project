using UnityEngine;

public class PlayAnimationOnClick_PK : MonoBehaviour
{
    public Animator animator;

    public GameObject animatorOBJ;


    public string triggerName = "TrStart";

    private void Start()
    {
        animator = animatorOBJ.GetComponent<Animator>();
    }
    public void PlayAnimation()
    {
        Debug.LogWarning("Play animation method is not working"); 
        animator.ResetTrigger("TrStart");   // clear any previous trigger
        animator.SetTrigger(triggerName);
    
        
    }
}