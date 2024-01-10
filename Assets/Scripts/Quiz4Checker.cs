using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Quiz4Checker : MonoBehaviour
{
    public bool q1;
    public bool q2;

    public TMP_Dropdown d1;
    public TMP_Dropdown d2;
    
    public void UpdateAnswers()
    {
        q1 = d1.captionText.text.StartsWith("never");
        q2 = d2.captionText.text.StartsWith("did not");
    }
}
