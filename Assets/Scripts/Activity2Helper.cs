using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Activity2Helper : MonoBehaviour
{
    public Activity2TimeBifurcation act2;
    
    public bool TellTimeInText = false;
    public bool GorboTimeResult = false;

    public GameObject GorboAlive;
    public TMP_Text GorboAliveTimeText;
    public GameObject GorboDead;

    public TMP_Text timeText;
    
    // Start is called before the first frame update
    void OnEnable()
    {
        if (TellTimeInText)
        {
            timeText.text = $"See you in {act2.GetTime()} hours.\n\nTry not to turn into a popsicle.";
            print(timeText.text);
        }

        if (GorboTimeResult)
        {
            if (act2.GetTime() == 8)
            {
                act2.isGorboDead = true;
                GorboAlive.SetActive(false);
                GorboDead.SetActive(true);
            }
            else
            {
                act2.isGorboDead = false;
                GorboAlive.SetActive(true);
                GorboDead.SetActive(false);
                GorboAliveTimeText.text = $"Acknowl-edged. I have be-en wait/ing for yo/ur arriv/al.\n\nIn the {act2.GetTime() * 4} mon-ths it took for yo/ur return, I comp/iled a compre-hensive translat/ion hand-book from the ta-blet's eng/ravings.\n\nIt sho/uld help us un-derstand the sto-ry of th/is col/ony.";
            }
        }
    }
}
