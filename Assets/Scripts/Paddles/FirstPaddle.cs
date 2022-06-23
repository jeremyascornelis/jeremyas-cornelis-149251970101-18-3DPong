using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPaddle : MonoBehaviour
{

    //Pedal Warna Merah

    public int speed;
    public KeyCode rightKey;
    public KeyCode leftKey;
    private Rigidbody rig;
    private Collider col;


    void Start()
    {
        rig = GetComponent<Rigidbody>();
        col = GetComponent<Collider>();
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
        //Debug.Log("Kecepatan Pedal Pertama: " + movement);
        rig.velocity = movement;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.name == "Pembatas") || (collision.gameObject.name == "Pembatas2"))
        {
            rig.freezeRotation = true;

        }
        
    }

}
