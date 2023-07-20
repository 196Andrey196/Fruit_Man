using UnityEngine.SceneManagement;
using UnityEngine;

public class WinMenu : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
