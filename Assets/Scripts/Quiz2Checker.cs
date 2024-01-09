using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Quiz2Checker : MonoBehaviour
{
    public TMP_InputField f1;
    public TMP_InputField f2;

    private bool q1;
    private bool q2;

    public void UpdateAnswers()
    {
        if (f1.text != null && f1.text.StartsWith("4"))
        {
            q1 = true;
        }
        
        if (f2.text != null && f2.text.StartsWith("16"))
        {
            q2 = true;
        }
    }
}
