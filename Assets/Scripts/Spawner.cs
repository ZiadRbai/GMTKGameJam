using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform spawner;
    [SerializeField] private GameObject Dice;

    private GameObject mainDice;

    void Start()
    {
        mainDice = Instantiate(Dice, spawner);
    }



    public void Reset()
    {
        mainDice.GetComponent<RollCube>().enabled = false;
        mainDice = Instantiate(Dice, spawner);
    }
}
