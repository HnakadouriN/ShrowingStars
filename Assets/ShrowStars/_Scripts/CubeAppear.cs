using UnityEngine;

namespace ShrowStars._Scripts
{
    public class CubeAppear : MonoBehaviour
    {
        [SerializeField] private GameObject _ThrowItem;

        private float BaseTime = 5;

        private float MeasurementTime;
        // Start is called before the first frame update
        void Start()
        {
            MeasurementTime = 0.0f;
        }

        // Update is called once per frame
        void Update()
        {
            MeasurementTime += Time.deltaTime;
            if (MeasurementTime > BaseTime)
            {
                Instantiate(_ThrowItem, this.transform.position, Quaternion.identity);
                MeasurementTime = 0.0f;
            }
        }
    }
}
