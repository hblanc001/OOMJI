using UnityEngine.SceneManagement;
using UnityEngine;

public class loadScene : MonoBehaviour
{
    public void nextScene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }
}