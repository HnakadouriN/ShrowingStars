using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafetyPlane : MonoBehaviour
{
    [SerializeField] private Needle _needle;
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.GetComponent<IBreakable>() == null)return;
        _needle.Lock();
    }
}
