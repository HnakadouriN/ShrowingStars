using System.Collections;
using UnityEngine;

namespace ShrowStars._Scripts
{
    public class BalloonController: MonoBehaviour
    {
        [SerializeField] private GameObject _B_object;

        private Vector3 AppendPosi;
        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(Waves());
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        private IEnumerator Waves()
        {
            for (int i = 0; i < 100; i++)
            {
                SpawnWaves();
                yield return new WaitForSeconds(1f);
            }
            yield return null;
        }

        private void SpawnWaves()
        {
        
            AppendPosi = new Vector3(Random.Range(-10,10),Random.Range(0,20),Random.Range(-10,10));
            Instantiate(_B_object, AppendPosi, Quaternion.identity);
        }
    }
}
