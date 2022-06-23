using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourthPaddle : MonoBehaviour
{
    //Sifatnya sama seperti pedal warna hijau
    //Pedal Warna Biru

    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;
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
        if (Input.GetKey(upKey))
        {
            return Vector3.forward * speed;
        }
        else if (Input.GetKey(downKey))
        {
            return Vector3.back * speed;
        }

        return Vector3.zero;
    }

    private void MoveObject(Vector3 movement)
    {
        //Debug.Log("Kecepatan Pedal Keempat: " + movement);
        rig.velocity = movement;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.name == "Pembatas1") || (collision.gameObject.name == "Pembatas4") || (collision.gameObject.name == "Ball"))
        {
            rig.freezeRotation = true;

        }

    }
}
