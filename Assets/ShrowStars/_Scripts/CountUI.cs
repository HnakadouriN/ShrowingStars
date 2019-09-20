using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountUI : MonoBehaviour
{
    private TextMesh text;
    private void Awake()
    {
        text = GetComponent<TextMesh>();
        SetCount(0);
    }
    void SetCount(int count)
    {
        text.text = "現在の個数: " + count + "個";
    }
}
