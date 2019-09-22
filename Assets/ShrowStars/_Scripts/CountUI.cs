﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountUI : MonoBehaviour
{
    public TextMesh text;
    private void Awake()
    {
        text = GetComponent<TextMesh>();
        SetCount(0);
    }
    public void SetCount(int count)
    {
        text.text = "現在の個数: " + count + "個";
    }
}
