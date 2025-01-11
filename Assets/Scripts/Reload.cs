using UnityEngine;
using UnityEngine.SceneManagement;
public class Reload : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("space"))
            SceneManager.LoadScene("MainScene");
    }
}
