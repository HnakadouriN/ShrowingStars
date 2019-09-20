using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Needle : MonoBehaviour
{
    private IBreakable iBreakable;
    private bool isLocked = false;
    public void Lock(){
        isLocked = true;
    }
    public void UnLock(){
        isLocked = false;
    }
    private void OnCollisionEnter(Collision other) {
        iBreakable = this.GetComponent<IBreakable>();
        if(!isLocked){
            iBreakable.Break();
        }
    }
}
