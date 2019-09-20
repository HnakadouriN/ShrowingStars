using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyurikenGrabber :OVRGrabber
{
    [SerializeField] private GameObject Obj;
    [SerializeField] private GameObject posi;
    protected override void GrabBegin(){
        base.GrabBegin();
    }
}