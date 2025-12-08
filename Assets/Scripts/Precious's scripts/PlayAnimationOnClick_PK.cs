using UnityEngine;

public class PlayAnimationOnClick_PK : MonoBehaviour
{
    public Animator animator;

    public GameObject animatorOBJ;


    public string triggerName = "TrStart";
//same name as the condition in  the animator

    private void Start()
    {
        animator = animatorOBJ.GetComponent<Animator>();
//extract the animator from the publicgameobject 
    }
    public void PlayAnimation()
//on play animation button method 
    {
        Debug.Log("Play animation method is working");
        // animator.SetBool(triggerName,true);

        animator.SetTrigger(triggerName);

  
        //added this line because the animation would pause at random frame
//if you left the room and re-entered

    }
}