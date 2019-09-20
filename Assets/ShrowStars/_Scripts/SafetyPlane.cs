using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafetyPlane : MonoBehaviour
{
    [SerializeField] private Needle _needle;
    private void OnCollisionEnter(Collision other) {
        _needle.Lock();
    }
}
