using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollCube : MonoBehaviour
{
    [SerializeField] private float _rollSpeed = 5;
    private Rigidbody rb;
    private bool _isMoving = true;

    float pitch;
    [SerializeField] private AudioClip SFXClip;
    [SerializeField] private AudioSource SFXSource;

    private void Start()
    {
        rb = transform.GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
        randomizePitch();
        SFXSource.PlayOneShot(SFXClip);
        _isMoving = false;
    }
    //void OnCollisionExit(Collision collision)
    //{
    //    _isMoving = true;
    //}


    private void Update()
    {
        if (_isMoving) return;

        if (Input.GetKey(KeyCode.LeftArrow)) Assemble(Vector3.left);
        else if (Input.GetKey(KeyCode.RightArrow)) Assemble(Vector3.right);
        else if (Input.GetKey(KeyCode.UpArrow)) Assemble(Vector3.forward);
        else if (Input.GetKey(KeyCode.DownArrow)) Assemble(Vector3.back);

        void Assemble(Vector3 dir)
        {
            var anchor = transform.position + (Vector3.down + dir) * 0.5f;
            var axis = Vector3.Cross(Vector3.up, dir);
            StartCoroutine(Roll(anchor, axis));
        }

        //_isMoving = true;
    }

    private IEnumerator Roll(Vector3 anchor, Vector3 axis)
    {
        rb.isKinematic = true;
        _isMoving = true;
        for (var i = 0; i < 90 / _rollSpeed; i++)
        {
            transform.RotateAround(anchor, axis, _rollSpeed);
            yield return new WaitForSeconds(0.01f);
        }
        randomizePitch();
        SFXSource.PlayOneShot(SFXClip);
        _isMoving = false;
        rb.isKinematic = false;
    }

    private void randomizePitch()
    { 
        SFXSource.pitch = Random.Range(0.8f, 1.2f);
    }
   

    
}

