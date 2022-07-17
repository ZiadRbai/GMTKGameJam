using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reset : MonoBehaviour
{
    [SerializeField] private int _scene = 0;
    void OnTriggerEnter(Collider other)
    {
            SceneManager.LoadScene(_scene);
    }

}