using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditScroll : MonoBehaviour
{
    public Transform[] views;
    public float transitionSpeed;
    public Transform CurrentView;
    public int viewNumber;

    // Start is called before the first frame update
    void Start()
    {
        CurrentView = views[0];

    }
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, CurrentView.position, Time.deltaTime * transitionSpeed);
    }


    void Update()
    {
        CurrentView = views[viewNumber];
        Debug.Log(CurrentView);
    }

    public void PressButtonRight()
    {

        viewNumber += 1;

    }

    public void PressButtonLeft()
    {

        viewNumber -= 1;

    }


}
