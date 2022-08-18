using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenResize : MonoBehaviour
{
    private void Awake()
    {
        Screen.SetResolution(480, 720, false);
        Screen.fullScreen = false;
    }
}
