using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 3.0f;
    public bool vertical;
    public float changeTime = 3.0f;

    Rigidbody rigidbody2d;

    float timer;
    int direction = 1;

    // Start is called before the first frame update
    void Start()
    { 
         rigidbody2d = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position;
        if(vertical)
        {
            position.y = position.y + Time.deltaTime * speed;
        }
        else
        {
            position.x = position.x + Time.deltaTime * speed;
        }
        

        rigidbody2d.MovePosition(position);
    }
}
