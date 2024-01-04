using UI.Choice;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UIElements;

public class SceneNavigator : MonoBehaviour
{
    public GameObject background;
    public GameObject ChoiceMenu;

    public Sprite scene1Background;

    public string activity;
    public enum Scenes
    {
        Scene1,
        Scene2,
        Scene3,
        Scene4
    }

    #region Scene Swap

    void SwapBackground(Scenes scene)
    {
        var sprite = scene switch
        {
            //Duplicate line below
            Scenes.Scene1 => scene1Background,
            _ => null
        };

        if (sprite != null)
        {
            background.GetComponent<Image>().sprite = sprite;
        }
    }

    #endregion

    #region Helpers

    public void ShowChoiceMenu(bool showOnRight = false)
    {
        Vector2 left1 = new Vector2(0, 0);
        Vector2 left2 = new Vector2(0.3f, 1);
        
        Vector2 right1 = new Vector2(0.7f, 0);
        Vector2 right2 = new Vector2(1, 1);

        ChoiceMenu.SetActive(true);
        
        ChoiceController controller = ChoiceMenu.GetComponent<ChoiceController>();
        controller.DestroyChoices();
        
        RectTransform rt = ChoiceMenu.GetComponent<RectTransform>();
        
        if (!showOnRight)
        {
            rt.anchorMin = left1;
            rt.anchorMax = left2;
        }
        else
        {
            rt.anchorMin = right1;
            rt.anchorMax = right2;
        }
    }

    public void HideChoiceMenu()
    {
        ChoiceMenu.SetActive(false);
    }

    #endregion

    public void OnUserChoice(int objIndex)
    {
        print($"Chosen number: {objIndex}");
    }
}
