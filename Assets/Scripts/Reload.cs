using UnityEngine;
using UnityEngine.SceneManagement;
public class Reload : MonoBehaviour
{
    public void ReloadGame()
    {
        SceneManager.LoadScene("MainScene");
    }
}
