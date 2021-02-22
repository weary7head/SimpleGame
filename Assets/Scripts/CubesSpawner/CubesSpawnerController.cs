using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Circle;
using Assets.Scripts.Cube;
using Assets.Scripts.CubesSpawner;

public class CubesSpawnerController : MonoBehaviour
{
    [SerializeField] private GameObject _circleGameObject;
    [SerializeField] private float _speedIncreaser;
    [SerializeField] private GameObject _cubePrefab;

    void Start()
    {
        StartCoroutine(IncreaseSpeed());
        StartCoroutine(CreateCubes());
    }

    IEnumerator IncreaseSpeed()
    {
       
        while (_circleGameObject.GetComponent<CircleController>().GetIsAlive())
        {
            yield return new WaitForSeconds(5f);
            _cubePrefab.GetComponent<CubeContoller>().SetSpeed(_speedIncreaser);
        }

    }
    IEnumerator CreateCubes()
    {
        while (_circleGameObject.GetComponent<CircleController>().GetIsAlive())
        {
            yield return new WaitForSeconds(1f);
            Position position = new Position();
            position = (Position)Random.Range(0, 8);
            Vector3 vectorSpawn = GetVector3(position);
            Instantiate(_cubePrefab, vectorSpawn, Quaternion.identity);
        }
    }

    public Vector3 GetVector3(Position position)
    {
        Vector3 vectorSpawn = new Vector3(0,10,0);
        switch (position)
        {
            case Position.First:
                vectorSpawn.x = -2.5f;
                break;
            case Position.Second:
                vectorSpawn.x = -1.9f;
                break;
            case Position.Third:
                vectorSpawn.x = -1.3f;
                break;
            case Position.Fourth:
                vectorSpawn.x = -0.7f;
                break;
            case Position.Fifth:
                vectorSpawn.x = -0.1f;
                break;
            case Position.Sixth:
                vectorSpawn.x = 0.5f;
                break;
            case Position.Seventh:
                vectorSpawn.x = 1.1f;
                break;
            case Position.Eighth:
                vectorSpawn.x = 1.7f;
                break;
            case Position.Ninth:
                vectorSpawn.x = 2.3f;
                break;
            default:
                break;
        }
        return vectorSpawn;
    }


}
