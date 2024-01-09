using TMPro;
using UnityEngine;

public class Quiz1Checker : MonoBehaviour
{
    public bool q1;
    public bool q2;
    public bool q3;
    public bool q4;
    public bool q5;

    public TMP_Dropdown d1;
    public TMP_Dropdown d2;
    public TMP_Dropdown d3;
    public TMP_Dropdown d4;
    public TMP_Dropdown d5;

    public void UpdateAnswers()
    {
        q1 = d1.captionText.text.StartsWith("The signal");
        q2 = d2.captionText.text.StartsWith("Long exposure");
        q3 = d3.captionText.text.StartsWith("The signal");
        q4 = d4.captionText.text.StartsWith("The heaters and");
        q5 = d5.captionText.text.StartsWith("Time");
    }
}
