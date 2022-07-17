using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reset : MonoBehaviour
{
    private bool canTrigger = true;
    

    void OnTriggerExit(Collider other)
    {
        if (canTrigger)
        {
            StartCoroutine(Timer());
            GameObject.FindGameObjectWithTag("Spawner").GetComponent<Spawner>().Reset();
        }
    }

    private IEnumerator Timer()
    {
        canTrigger = false;
        yield return new WaitForSeconds(1f);
        canTrigger = true;
    }

}