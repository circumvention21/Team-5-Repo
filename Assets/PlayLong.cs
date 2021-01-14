using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayLong : MonoBehaviour
{
    private void Awake()
    {
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("ClickSound");
        if(musicObj.Length > 100000)
        {

            Destroy(this.gameObject);

        }
        DontDestroyOnLoad(this.gameObject);
    }
}
