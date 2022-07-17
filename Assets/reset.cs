using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reset : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
            SceneManager.LoadScene(0);
    }

}