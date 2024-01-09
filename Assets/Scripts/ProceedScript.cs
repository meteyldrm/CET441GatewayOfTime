using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceedScript : MonoBehaviour
{
    public GameObject go14;
    public GameObject go15;
    
    public GameObject go2_11;
    public GameObject go2_12;
    
    
    public GameObject go3_11;
    public GameObject go3_12;

    public GameObject quiz1button;
    public GameObject quiz2button;
    public GameObject quiz3button;

    public void Trigger()
    {
        if (go14.gameObject.activeSelf)
        {
            go15.SetActive(true);
            quiz1button.SetActive(true);
        }
        
        if (go2_11.gameObject.activeSelf)
        {
            go2_12.SetActive(true);
            quiz2button.SetActive(true);
        }
    }
}
