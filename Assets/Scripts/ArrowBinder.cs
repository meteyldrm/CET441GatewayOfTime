using UnityEngine;
using UnityEngine.UI;

public class ArrowBinder : MonoBehaviour
{
    private Button _prev;
    private Button _next;
    
    void Awake()
    {
        foreach (Transform t in transform)
        {
            if (t.gameObject.name.Equals("Navigation Arrows"))
            {
                foreach (Transform tx in t.transform)
                {
                    if (tx.gameObject.name.Equals("Previous"))
                    {
                        _prev = tx.gameObject.GetComponent<Button>();
                    }
                    
                    if (tx.gameObject.name.Equals("Next"))
                    {
                        _next = tx.gameObject.GetComponent<Button>();
                    }
                }
            }
        }
    }

    private void OnEnable()
    {
        if(_prev != null) _prev.onClick.AddListener(PreviousClick);
        if(_next != null) _next.onClick.AddListener(NextClick);
    }

    private void OnDisable()
    {
        if(_prev != null) _prev.onClick.RemoveListener(PreviousClick);
        if(_next != null) _next.onClick.RemoveListener(NextClick);
    }

    private void PreviousClick()
    {
        var target = transform.parent.GetChild(transform.GetSiblingIndex() - 1).gameObject;
        if (target == null) return;
        target.SetActive(true);
        gameObject.SetActive(false);
    }
    
    private void NextClick()
    {
        var target = transform.parent.GetChild(transform.GetSiblingIndex() + 1).gameObject;
        if (target == null) return;
        target.SetActive(true);
        gameObject.SetActive(false);
    }
}
