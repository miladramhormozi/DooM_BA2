using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject DoorPrefab;
    public bool isAuto;
    bool isOpen;


    public void OpenDoor()
    {
        if (!isOpen)
        {
            DoorPrefab.SetActive(false);
            isOpen = true;
        }
    }
    public void CloseDoor()
    {
        if (isOpen)
        {
            DoorPrefab.SetActive(true);
            isOpen = false;

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (isAuto)
            {
                OpenDoor();
            }

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            if (other.tag == "Player")
            {
                if (isAuto)
                {
                    CloseDoor();
                }

            }
        }
    }
}
