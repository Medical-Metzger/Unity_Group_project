using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class VideoCoRoutine_PK : MonoBehaviour
{
    public GameObject myObj;
    private IEnumerator coroutine;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myObj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnClickButton(float seconds)
    {
        myObj.SetActive(true);
        coroutine = WaitForTimer(seconds);
        StartCoroutine(coroutine);
        //assign the coroutine to the variable on line 7
    }
    IEnumerator WaitForTimer(float timerDuration)
    {
        Debug.Log("Timer 0:" + Time.time);
        yield return new WaitForSeconds(timerDuration);
        Debug.Log("Timer 1:" + Time.time);
        myObj.SetActive(false); //calling the game object mentioned in the top
    }
}



