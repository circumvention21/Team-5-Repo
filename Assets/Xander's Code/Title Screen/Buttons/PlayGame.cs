using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
    private void OnMouseDown()
    {

        Debug.Log("Test");

    }






  
  private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Switch Scene");
            SceneManager.LoadScene("CaveLevel");

        }



    }
}
