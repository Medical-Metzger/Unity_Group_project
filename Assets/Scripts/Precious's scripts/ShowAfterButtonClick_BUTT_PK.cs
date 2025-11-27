using UnityEngine;

public class ShowAfterButtonClick_BUTT_PK : MonoBehaviour//onclick button method
{
    public GameObject myObj1;   // Object that becomes active
    public int requiredClicks = 5;

    private static int clickCount = 0;
    // static = shared between all copies of the script

    void Start()
    {
        myObj1.SetActive(false);
    }

   public void OnClickButton()
    {
        clickCount++;

        Debug.Log("Clicked! Total clicks = " + clickCount);

        if (clickCount >= requiredClicks)
        {
            myObj1.SetActive(true);
        }
    }
}