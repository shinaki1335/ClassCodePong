using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMove : MonoBehaviour
{
    //variable for movement
    public float speed = 10f;
    public float yBorder = 4.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.O))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + speed);
        }
    }
}
