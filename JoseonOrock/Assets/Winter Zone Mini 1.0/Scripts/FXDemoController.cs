﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FXDemoController : MonoBehaviour
{

    public GameObject fx_Storm;
    public GameObject fx_Blizzard;
    public GameObject fx_Snow;
    public GameObject fx_audio;

    void Start ()
    {
    }

    void Update()
    {       
        if (Input.GetKeyUp(KeyCode.R))
            Storm();
        if (Input.GetKeyUp(KeyCode.T))
            Blizzard();
        if (Input.GetKeyUp(KeyCode.Y))
            Snow();
        if (Input.GetKeyUp(KeyCode.U))
            NoFX();
    }

    public void Storm()
    {
        turnOff_FX();
        fx_Storm.SetActive(true);
        fx_audio.SetActive(true);
        Debug.Log("Storm");
    }

    public void Blizzard()
    {
        turnOff_FX();
        fx_Blizzard.SetActive(true);
        fx_audio.SetActive(true);
        Debug.Log("Blizzard");
    }

    public void Snow()
    {
        turnOff_FX();
        fx_Snow.SetActive(true);
        Debug.Log("Snow");
    }

    public void NoFX()
    {
        turnOff_FX();
        Debug.Log("NoFX");
    }

    void turnOff_FX()
    {
        fx_Storm.SetActive(false);
        fx_Blizzard.SetActive(false);
        fx_Snow.SetActive(false);
        fx_audio.SetActive(false);
    }
}
