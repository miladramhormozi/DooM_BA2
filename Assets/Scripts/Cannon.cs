using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject Bullet;
    public GameObject InstantiatePoint;
    public void Shoot()
    {
        Instantiate(Bullet, InstantiatePoint.transform, true);
    }
}
