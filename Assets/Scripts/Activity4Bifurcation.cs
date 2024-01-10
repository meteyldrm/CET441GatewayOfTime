using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activity4Bifurcation : MonoBehaviour
{
    public GameObject go18;
    public GameObject go20;

    public Quiz4Checker checker;
    
    // Start is called before the first frame update
    public void Check()
    {
        if (checker.q1 && checker.q2)
        {
            go20.SetActive(true);
            gameObject.SetActive(false);
        }
        else
        {
            go18.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
