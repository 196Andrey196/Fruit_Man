using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject _menu;

    public void Toggle()
    {
        _menu.SetActive(!_menu.activeSelf);
        if (_menu.activeSelf)

            Time.timeScale = 0f;

        else
        {
            Time.timeScale = 1f;
        }
    }
    public void Continiue()
    {
        Toggle();
    }
    public void Quit()
    {
        Application.Quit();
    }
}
