using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    public Vector3 speed;
    private Rigidbody rig;
    public int force;

    public BallManager manager;

    void Start()
    {
        rig = GetComponent<Rigidbody>();
        //rig.velocity = speed;
        rig.AddForce(speed * force);
    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.tag == "tembok")
        {
            manager.RemoveBall(gameObject);
        }
    }


}
