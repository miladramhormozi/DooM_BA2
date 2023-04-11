using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

public class Switch : MonoBehaviour
{
    public GameObject[] OtheSwitches;
    bool isActive;

    MeshRenderer meshRenderer;
    public Material mActive, mInactive;
    public UnityEvent OnActivationEvents, OnDeactivationEvents;
    public float ResetTime;

    private bool IsAuto;

    public void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        SetState(false);

        if (ResetTime > 0)
        {
            IsAuto = true;

        }
    }

    public void SetState(bool newState)
    {
        isActive = newState;

        if (isActive == true)
        {
            meshRenderer.material = mActive;
            OnActivationEvents.Invoke();
        }
        else
        {
            meshRenderer.material = mInactive;
            OnDeactivationEvents.Invoke();

        }
    }


    public void OnMouseDown()
    {
        for (int i = 0; i < OtheSwitches.Length; i++)
        {
            OtheSwitches[i].GetComponent<Switch>().SetState(!isActive);
        }


        SetState(!isActive);

        if (IsAuto)
        {
            StartCoroutine(Reset());

        }
    }

    private IEnumerator Reset()
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        yield return new WaitForSeconds(ResetTime);
        SetState(!isActive);
        this.gameObject.GetComponent<BoxCollider>().enabled = true;

    }
}
