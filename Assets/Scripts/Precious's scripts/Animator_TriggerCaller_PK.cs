
using UnityEngine;

public class Animator_TriggerCaller_PK : MonoBehaviour
{
    private Animator mAnimator;

    void Start()
    {
        mAnimator = GetComponent<Animator>();
    }

    // use the gameobject this script is attached to and call Trigger start from the onclick () section 
    public void TriggerStart()
    {
        if (mAnimator != null)
        {
            mAnimator.SetTrigger("TrStart");
        }
    }
}
