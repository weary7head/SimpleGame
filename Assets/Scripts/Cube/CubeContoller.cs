using Assets.Scripts.Cube;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeContoller : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    private Cube _cube;

    void Awake()
    {
        _cube = new Cube(_speed, GetComponent<Rigidbody>(), true);
    }

    void FixedUpdate()
    {
        _cube.Movement(Vector3.down);
    }

    public void SetSpeed(float speed)
    {
        _speed += speed;
    }
}
