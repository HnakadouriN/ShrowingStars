using UnityEngine;

namespace ShrowStars._Scripts
{
    public class BalloonMove : MonoBehaviour
    {
        private Rigidbody rb;

        private float DestroyTime = 10f;

        private float MeasurementTime;
        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
            rb.AddForce(Vector3.up * 0.079f,ForceMode.Force);
            MeasurementTime += Time.deltaTime;
            if (MeasurementTime > DestroyTime)
            {
                Destroy(this.gameObject);
                MeasurementTime = 0;
            }
        }
    }
}
