using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController _controller;
    private float _speed = 10.0f;
    private float _gravity = 1.0f;
    private float _jumpHeight = 30.0f;
    private float _yVelocity;
    private bool _enableDoubleJump;
    private int _score=0;
    private UIManager _uiManager;
    private int _lives=3;

    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<CharacterController>();
        _uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 _velocity = Vector3.right * Input.GetAxis("Horizontal") * _speed;

        if (_controller.isGrounded)
        {
            _enableDoubleJump = true;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _yVelocity = _jumpHeight;
            }
            
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space) && _enableDoubleJump)
            {
                _yVelocity = _jumpHeight;
                _enableDoubleJump = false;
            }
            _yVelocity -= _gravity;
        }

        _velocity.y = _yVelocity;

        _controller.Move( _velocity * Time.deltaTime);

        if (transform.position.y <= -7)
        {
            _lives--;
            _uiManager.UpdateScore(_score);
            if (_lives == 0)
            {
                Debug.Log("You Dead");
            }
            else
            {
                transform.position = new Vector3(0, 2, 0);
            }
            
        }
    }

    public void Score()
    {
        _score++;
        _uiManager.UpdateScore(_score); 
    }

}
