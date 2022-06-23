using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pembatas : MonoBehaviour
{

    private Rigidbody rig;

    void Start()
    {
        rig.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        rig.velocity = Vector3.zero;
    }

    private void OnCollisionEnter(Collision collision)
    {
        rig.velocity = Vector3.zero;
    }
}
