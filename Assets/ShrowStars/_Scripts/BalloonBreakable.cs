using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class BalloonBreakable : MonoBehaviour, IBreakable
{
    [SerializeField]
    private BalloonColor Color;
    [SerializeField]
    private GameObject HaretuPrefab;
    private bool isEnd = false;
    public void Break()
    {
        if(isEnd)return;
        isEnd = true;
        if(Color == BalloonColor.blue){
            BalloonCounter.blueCount++;
        }
        if (HaretuPrefab != null)
        {
            Instantiate(HaretuPrefab, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
    }

}
