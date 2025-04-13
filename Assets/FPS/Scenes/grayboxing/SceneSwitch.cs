using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("IntroTB");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void Credits()
    {
        SceneManager.LoadScene("CreditsMenu");
    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Replay()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Tutorial()
    {
        SceneManager.LoadScene("TutorialMenu");
    }

    public void SkipIntro()
    {
        SceneManager.LoadScene("Level1");
    }

    public void SkipMotive()
    {
        SceneManager.LoadScene("TwistTB");
    }

    public void SkipTwist()
    {
        SceneManager.LoadScene("Level2");
    }

    public void SkipConclusion()
    {
        SceneManager.LoadScene("WinScene");
    }
}