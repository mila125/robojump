﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LSUIManager : MonoBehaviour
{
    public static LSUIManager instance;

    public Text lNameText;

    public GameObject lNamePanel;

    public Text coinsText;


    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        
    }
}
