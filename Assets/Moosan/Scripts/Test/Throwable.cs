using UnityEngine;

namespace Assets.Moosan.Scripts.Test
{
    public class Throwable : OVRGrabbable
    {
        //v = Ft/m
        //v_c = Ft/1 = Ft
        //v = v_c/m
        public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
        { 
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();
            rb.isKinematic = m_grabbedKinematic;
            rb.velocity = linearVelocity / rb.mass;
            rb.angularVelocity = angularVelocity;
            m_grabbedBy = null;
            m_grabbedCollider = null;
        }
    }
}