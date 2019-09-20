using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Balloons;
    private List<IBreakable> Breakables = new List<IBreakable>();
    private bool isEnd = false;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCoroutine());
    }
    private void SpawnEnd()
    {
        isEnd = true;
    }
    IEnumerator SpawnCoroutine()
    {
        while (!isEnd)
        {
            Spawn();
            yield return new WaitForSeconds(1f);
        }
    }
    void Spawn()
    {
        var prefab = Balloons[(int)(Random.Range(0.0f, 3.0f) / 1)];
        var AppendPosi = new Vector3(Random.Range(-10, 10), Random.Range(0, 20), Random.Range(-10, 10));
        Breakables.Add(Instantiate(prefab, AppendPosi, Quaternion.identity).GetComponent<IBreakable>());
    }

    public void Break()
    {

    }
    public IEnumerator BreakCoroutine()
    {
        SpawnEnd();
        foreach (var breakable in Breakables)
        {
            breakable?.Break();
            yield return null;
        }
    }
}