using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public BalloonColor TagetColor;
    public BalloonSpawner spawner;
    private void Update()
    {
        if(BalloonCounter.Singleton.GetColorCount(TagetColor) >= 5)
        {
            Clear();
        }
    }

    void Clear()
    {
        spawner.Break();
    }
}
