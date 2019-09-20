using UnityEngine;

namespace Assets.Moosan.Scripts.Test
{
    public class Throwable : OVRGrabbable
    {
        [SerializeField] private Needle _needle;
        [SerializeField] private Collider[] Colliders;
        //v = Ft/m
        //v_c = Ft/1 = Ft
        //v = v_c/m
        public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
        {
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();
            foreach (var collider in Colliders)
            {
                collider.isTrigger = false;
            }
            rb.isKinematic = false;
            //rb.isKinematic = m_grabbedKinematic;
            rb.velocity = linearVelocity / rb.mass;
            rb.angularVelocity = angularVelocity  * -5f;
            m_grabbedBy = null;
            m_grabbedCollider = null;
            _needle.UnLock();
        }
    }
}