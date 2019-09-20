using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyurikenSpawner : MonoBehaviour
{
    [SerializeField] private GameObject Obj;
    private GameObject pos;
    private bool isSpawning = false;
    private OVRGrabbable grabbable;

    private void Start() {
        Spawn();
    }
    private void Update() {
        if(grabbable.isGrabbed){
            if(isSpawning)return;
            grabbable = null;
            isSpawning = true;
            Invoke("Spawn",1.0f);
        }else
        {
            if(isSpawning||grabbable == null)return;
            grabbable.transform.position = transform.position;
            grabbable.transform.rotation = transform.rotation;
        }
    }
    private void Spawn(){
        pos = Instantiate(Obj,this.transform.position,this.transform.rotation);
        grabbable = pos.GetComponent<OVRGrabbable>();
        isSpawning = false;
    }
}
