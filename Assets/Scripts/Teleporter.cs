using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Transform TargetLocation;

    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = TargetLocation.transform.position;
        Debug.Log("here");
    }

}
