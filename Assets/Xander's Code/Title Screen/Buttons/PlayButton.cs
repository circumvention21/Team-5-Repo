﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public AudioSource Click;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGameButton()
    {
        Click.Play();

        Debug.Log("Button Worked");

        SceneManager.LoadScene("lvl2");

    }



}
