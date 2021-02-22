using Assets.Scripts.Circle;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubesDestroyerController : MonoBehaviour
{
    [SerializeField]
    private Text _scoreText;
    private AudioSource _pointSound;

    private void Awake()
    {
        _pointSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject != null)
        {
            Object.Destroy(other.gameObject);
            Circle.Score++;
            _scoreText.text = Circle.Score.ToString();
            _pointSound.Play();
        }

    }

   
}
