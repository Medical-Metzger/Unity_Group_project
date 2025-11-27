
using UnityEngine;

public class Animator_TriggerCaller_PK : MonoBehaviour
{
    private Animator mAnimator;

    void Start()
    {
        mAnimator = GetComponent<Animator>();
    }

    // Call this from a UI button
    public void TriggerStart()
    {
        if (mAnimator != null)
        {
            mAnimator.SetTrigger("TrStart");
        }
    }
}
