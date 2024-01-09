using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activity2TimeBifurcation : MonoBehaviour
{
    private int time;
    public bool isGorboDead = false;

    public GameObject NoChoicePath;
    public GameObject ChoicePath;
    public GameObject ChoiceButtons;
    public GameObject Navigation;
    
    public void Next()
    {
        var quiz1 = gameObject.GetComponent<Quiz1Checker>();
        if (quiz1.q1 && quiz1.q2 && quiz1.q3 && quiz1.q4 && quiz1.q5)
        {
            print("The quiz was answered correctly");
            ChoicePath.SetActive(true);
            ChoiceButtons.SetActive(true);
            NoChoicePath.SetActive(false);
            Navigation.SetActive(false);
        }
        else
        {
            print("The quiz was answered incorrectly, F Gorbo");
            NoChoicePath.SetActive(true);
            ChoicePath.SetActive(false);
            ChoiceButtons.SetActive(false);
            Navigation.SetActive(true);
        }
    }

    public void Choose2()
    {
        time = 2;
    }
    
    public void Choose5()
    {
        time = 5;
    }
    
    public void Choose8()
    {
        time = 8;
    }

    public int GetTime()
    {
        return time;
    }
}
