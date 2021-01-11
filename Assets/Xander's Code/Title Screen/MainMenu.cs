using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button playButton;

    public Button creditsButton;

    public Button exitGameButton;

    public string CaveLevel;

    public string Credits;

    public void PlayButton()
    {
        SceneManager.LoadScene(CaveLevel);

    }

    public void CreditsButton()
    {
        SceneManager.LoadScene(Credits);

    }

    public void ExitButton()
    {
        Application.Quit();

    }
}
