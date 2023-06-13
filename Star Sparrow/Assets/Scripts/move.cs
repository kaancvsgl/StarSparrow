using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed = 10;
    public float speedUp = 1f;

    public float speedX = 2f;
        
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        speed += speedUp * Time.deltaTime;
        speedX += speedUp*Time.deltaTime;

        gameObject.transform.Translate(new Vector3(0f, 0f, speed) * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Translate(new Vector3(speedX, 0f, 0f)*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Translate(new Vector3(-speedX, 0f, 0f)*Time.deltaTime);
        }
    }

    void Update()
    {
        
    }
}
