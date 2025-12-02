
using UnityEngine;

public class Animator_TriggerCaller_PK : MonoBehaviour
{
    public Animator mAnimator;

    void Start()
    {
        mAnimator = GetComponent<Animator>();
    }

    // use the gameobject this script is attached to and call Trigger start from the onclick () section 
    public void TriggerStart()
    {
        if (mAnimator != null)
        {
            Debug.LogWarning("TriggerStart method is not working");
            mAnimator.SetTrigger("TrStart");
        }
    }
}
