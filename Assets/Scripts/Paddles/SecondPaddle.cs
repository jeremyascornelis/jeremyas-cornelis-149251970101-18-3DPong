using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondPaddle : MonoBehaviour
{

    //Sifatnya sama seperti paddle pertama
    //Pedal Warna Kuning

    public int speed;
    public KeyCode rightKey;
    public KeyCode leftKey;
    private Rigidbody rig;

    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }


    void Update()
    {
        //ambil input
        Vector3 movement = GetInput();
        //gerakan object dengan input
        MoveObject(movement);
    }

    private Vector3 GetInput()
    {
        if (Input.GetKey(rightKey))
        {
            return Vector3.right * speed;
        }
        else if (Input.GetKey(leftKey))
        {
            return Vector3.left * speed;
        }

        return Vector3.zero;
    }

    private void MoveObject(Vector3 movement)
    {
        //Debug.Log("Kecepatan Pedal Kedua: " + movement);
        rig.velocity = movement;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.name == "Pembatas3") || (collision.gameObject.name == "Pembatas4") || (collision.gameObject.name == "Ball"))
        {
            rig.freezeRotation = true;

        }

    }
}
