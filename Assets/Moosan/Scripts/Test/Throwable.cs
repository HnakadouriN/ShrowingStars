using UnityEngine;

namespace Assets.Moosan.Scripts.Test
{
    public class Throwable : OVRGrabbable
    {
        //引数の速度を、質量1の時に与えられた速度と仮定し、力に戻している
        public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
        { 
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();
            var F = linearVelocity / Time.deltaTime;
            rb.isKinematic = m_grabbedKinematic;
            rb.AddForce(F, ForceMode.Force);
            rb.angularVelocity = angularVelocity;
            m_grabbedBy = null;
            m_grabbedCollider = null;
        }
    }
}