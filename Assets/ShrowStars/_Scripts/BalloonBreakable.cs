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

    public void Break()
    {
        BalloonCounter.Singleton.AddColor(Color);
        if (HaretuPrefab != null)
        {
            Instantiate(HaretuPrefab, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
    }
}
