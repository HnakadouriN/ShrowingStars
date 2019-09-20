using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonCounter : MonoBehaviour
{
    public static BalloonCounter Singleton;
    private void Awake()
    {
        Singleton = this;
        colorCount[BalloonColor.red] = 0;
        colorCount[BalloonColor.green] = 0;
        colorCount[BalloonColor.blue] = 0;
    }
    private Dictionary<BalloonColor, int> colorCount = new Dictionary<BalloonColor, int>();

    public void AddColor(BalloonColor color)
    {
        colorCount[color] += 1;
    }
    public int GetColorCount(BalloonColor color)
    {
        return colorCount[color];
    }
}
