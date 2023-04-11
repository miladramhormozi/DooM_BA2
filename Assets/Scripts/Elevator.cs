using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    private Animator _an;
    bool isUp;

    private void Start()
    {
        _an = GetComponent<Animator>();
    }

    public void MoveDown()
    {
        if (!isUp)
        {
            _an.SetBool("IsUp", true);
            isUp = true;
        }
    }
    public void MoveUp()
    {
        if (isUp)
        {
            _an.SetBool("IsUp", false);
            isUp = false;

        }
    }
}
