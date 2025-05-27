using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject authorPanel;

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void ShowAuthorInfo()
    {
        authorPanel.SetActive(true);
    }

    public void CloseAuthorInfo()
    {
        authorPanel.SetActive(false);
    }

    public void LoadTrainingScene()
    {
        SceneManager.LoadScene("Training");
    }
}
