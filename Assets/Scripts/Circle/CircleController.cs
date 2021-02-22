using Assets.Scripts.Circle;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CircleController : MonoBehaviour
{
    [SerializeField]
    private float _speed = 2;
    private Circle _circle;
    private AudioSource _gameOverSound;
    void Awake()
    {
        _circle = new Circle(_speed, GetComponent<Rigidbody>(), true);
        _gameOverSound = GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {
        if(Input.touchCount > 0)
        {
           if(Input.GetTouch(0).phase == TouchPhase.Stationary)
           {
                if (Input.GetTouch(0).rawPosition.x > Screen.width/2)
                {
                    _circle.Movement(Vector3.right);
                }
                else
                {
                    _circle.Movement(Vector3.left);
                }
           }
        }
        if(Input.GetMouseButton(0))
        {
            if(Input.GetMouseButton(0))
            {
                if (Input.mousePosition.x > Screen.width / 2)
                {
                    _circle.Movement(Vector3.right);
                }
                else
                {
                    _circle.Movement(Vector3.left);
                }
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Cube")
        {
            _circle.IsAlive = false;
            _gameOverSound.Play();
            Time.timeScale = 0;
        }
    }

    public bool GetIsAlive()
    {
        return _circle.IsAlive;
    }
}
