using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{
    [SerializeField] private string _dicen = "d1";
    [SerializeField] private int _scene = 1;
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == _dicen)
        {
            SceneManager.LoadScene(_scene);
        }
        /*else
        {
            SceneManager.LoadScene(0);
        }*/
            
    }

}
