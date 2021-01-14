using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public AudioSource Click;
    public Button playButton;

    public Button creditsButton;

    public Button exitGameButton;

    public string CaveLevel;

    public string Credits;

    public string lvl2;

    public void PlayButton()
    {
        SceneManager.LoadScene(lvl2);

    }

    public void CreditsButton()
    {
        Click.Play();
        SceneManager.LoadScene("Credits");

    }

    public void ExitButton()
    {
        Application.Quit();

    }
}
