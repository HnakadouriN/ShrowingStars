using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Balloons;
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
        var prefab = Balloons[(int)(Mathf.Max(0,Random.Range(-1.0f, 3.0f) / 1))];
        var AppendPosi = new Vector3(Random.Range(-10, 10), Random.Range(0, 10), Random.Range(-10, 10));
        var obj = Instantiate(prefab, AppendPosi, Quaternion.identity);
        obj.transform.parent = transform;
    }

    public void BreakAll()
    {
        SpawnEnd();
        this.BroadcastMessage("Break");
    }
}