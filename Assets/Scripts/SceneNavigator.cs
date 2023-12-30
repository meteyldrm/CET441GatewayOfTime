using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UIElements;

public class SceneNavigator : MonoBehaviour
{
    public GameObject background;

    public Sprite scene1Background;
    
    public enum Scenes
    {
        Scene1,
        Scene2,
        Scene3,
        Scene4
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SwapBackground(Scenes scene)
    {
        switch (scene)
        {
            case Scenes.Scene1:
                background.GetComponent<Image>().sprite = scene1Background;
                break;
        }
    }
}
