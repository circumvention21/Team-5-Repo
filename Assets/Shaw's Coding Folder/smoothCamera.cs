using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class smoothCamera : MonoBehaviour
{
    public Transform Target;
    public Vector3 Offset;
    public float SmoothSpeed = 0.125f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void LateUpdate()
    {
        Vector3 DesiredPos = Target.position + Offset;
        Vector3 SmoothPos = Vector3.Lerp(transform.position, DesiredPos, SmoothSpeed);
        transform.position = SmoothPos;
    }
}
