using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBall : MonoBehaviour
{

    private Light m_Light;
    bool isOn;

    private void Start()
    {
        m_Light = GetComponent<Light>();
    }

    public void TurnOn()
    {
        if (!isOn)
        {
            m_Light.enabled = true;
            isOn = true;
        }
    }
    public void TurnOf()
    {
        if (isOn)
        {
            m_Light.enabled = false;
            isOn = false;

        }
    }
}
