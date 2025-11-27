using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class quizManager : MonoBehaviour
{
    public int maxQuestionIndex = 5;

    public int myQuestionIndex = 0;

    public List<GameObject> questionList;

    [SerializeField]
    private GameObject finalPanel;
   
    [SerializeField]
    private GameObject scoreIndicator;
    
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
    //OnClickNext();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickNext()
    {
        if (myQuestionIndex < maxQuestionIndex)
        {
            int index = Random.Range(0,questionList.Count);

            //retrieve Question from the List& Set Question to visible
            questionList[index].SetActive(true);

            //Remove Question from List
            questionList.RemoveAt(index);

            //increase myQuestion Index value
            myQuestionIndex +=1;
        }
        else
        {
            //Show the Score panel
            finalPanel.SetActive(true);

            scoreIndicator.GetComponent<TextMeshProUGUI>().text = scoreIndicator.GetComponent<TextMeshProUGUI>().text + score;

            Debug.Log("End");
        }
    }
}