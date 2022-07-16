using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public GameObject Cube;



    // Start is called before the first frame update
    void Start()
    {
        Cube = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            moveCube(1, 1);
            return;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            moveCube(1, -1);
            return;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            moveCube(2, 1);
            return;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            moveCube(2, -1);
            return;
        }
    }

    private void moveCube(int direction, int isForward)
    {
        switch (direction)
        {
            case 2:
                transform.position = new Vector3(transform.position.x + 1 * isForward, transform.position.y, transform.position.z);
                
                break;

            case 1:
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1 * isForward);
                break;
            default:
                break;
        }
    }
}
