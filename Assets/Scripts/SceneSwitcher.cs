using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneSwitcher : MonoBehaviour
{
    public static SceneSwitcher instance;
    private void Awake()
    {
        instance = this;
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void Win()
    {
        SceneManager.LoadScene("Win");
    }
    public void Lose()
    {
        SceneManager.LoadScene("Lose");
    }
}
