using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{

    public void LoadSCene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}