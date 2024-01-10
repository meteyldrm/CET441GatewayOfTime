using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour
{
    public void Click()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    public void Quit()
    {
        Application.Quit();
    }
}
