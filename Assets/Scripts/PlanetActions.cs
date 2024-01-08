using UnityEngine;
using UnityEngine.UI;

public class PlanetActions : MonoBehaviour
{
    public GameObject returnToShipButton;

    public bool tabletButtonPressed = false;
    public bool blackHoleButtonPressed = false;

    private bool doOnce = false;

    void Update()
    {
        if (doOnce) return;
        if (tabletButtonPressed && blackHoleButtonPressed)
        {
            returnToShipButton.SetActive(true);
        }
    }

    public void SetDistance()
    {
        blackHoleButtonPressed = true;
    }
    
    public void SetTablet()
    {
        tabletButtonPressed = true;
    }
}