using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasController : MonoBehaviour
{
    [SerializeField] private GameObject startMenu;

    private void Update()
    {
    }


    public void StartBtn()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Config()
    {
        SceneManager.LoadScene("MenuInicial");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
