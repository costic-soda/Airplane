using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
    public float speed = 0.0f;
    private Vector3 camPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        speed += Input.GetAxisRaw("Jump") * 1f;
        if (speed >= 100.0f)
        {
            speed = 100.0f;
        }
        if (speed < 10.0f)
        {
            speed = 10.0f;
        }

        transform.position += transform.forward * Time.deltaTime * speed;
        transform.Rotate(Input.GetAxis("Vertical"),0.0f, -Input.GetAxis("Horizontal"));  
    }
}
