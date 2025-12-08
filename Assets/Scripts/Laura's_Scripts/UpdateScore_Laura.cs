using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpdateScore_Laura : MonoBehaviour
{
    public int correctAnswersNb;
    public int totalQuestionsNb;
    public TextMeshProUGUI percentageText; // assign in Inspector


    float percent = 0.0f;

    void Start()
    {
        totalQuestionsNb = transform.GetComponent<QuizManager>().maxQuestionIndex;
    }

   
    public void UpdateScoreBtn()
    {
        correctAnswersNb = transform.GetComponent<QuizManager>().score;

        if (totalQuestionsNb > 0)
        percent = correctAnswersNb / totalQuestionsNb * 100.0f;

        percent = Mathf.Clamp(percent, 0.0f, 100.0f);

    // Display as whole number (e.g., 85%)
    //percentageText.text;
    }
}
