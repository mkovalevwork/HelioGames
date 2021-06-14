using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void LoadSceene(string sceneName)
    {
        SceneManager.LoadScene(sceneName); 
    }
}
