using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activity2MicroBranch : MonoBehaviour
{
    public Activity2TimeBifurcation act2;

    public GameObject dialogueDead;
    public GameObject dialogueAlive;
    // Start is called before the first frame update
    void Start()
    {
        if (act2.isGorboDead)
        {
            dialogueDead.SetActive(true);
            dialogueAlive.SetActive(false);
        }
        else
        {
            dialogueDead.SetActive(false);
            dialogueAlive.SetActive(true);
        }
    }
}
