using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private float initialSpeed = 200;
    void Start()
    {

        GetComponent<Rigidbody>().velocity = transform.forward * initialSpeed;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
