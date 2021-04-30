using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    private float _speed=3.0f;
    private int _direction;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.right * _speed *_direction* Time.deltaTime);
       
        if (transform.position.x <= 13)
        {
            _direction = 1;
        }
       else if(transform.position.x >= 20)
        {
            _direction = -1;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        other.transform.parent = gameObject.transform;
    }

    private void OnTriggerExit(Collider other)
    {
        other.transform.parent = null;
    }
}
