using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseAxis2 : MonoBehaviour
{
    public Transform shoulder;
    public float armLength = 1f;
    public Camera camera;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 ShoulderToMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition) - shoulder.position;
        ShoulderToMouse.z = 0;
        transform.position = shoulder.position + (armLength * ShoulderToMouse.normalized);
        Vector2 Mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector2 Direction = new Vector2(
            Mousepos.x - transform.position.x,
            Mousepos.y - transform.position.y
        );
        transform.up = Direction;
    }

}
