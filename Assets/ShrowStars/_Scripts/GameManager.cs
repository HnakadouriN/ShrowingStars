using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public BalloonColor TagetColor;
    public BalloonSpawner spawner;
    public GameObject MissionUIObj;
    public GameObject CountUIObj;
    public GameObject ClearUIObj;
    private CountUI countUI;
    private void Awake()
    {
        countUI = CountUIObj.GetComponent<CountUI>();
    }
    private void Update()
    {
        int cou = BalloonCounter.Singleton.GetColorCount(TagetColor);
        countUI.SetCount(cou);
        if(cou == 1)
        {
            OnCount();
        }
        if (cou >= 5)
        {
            Clear();
        }
    }

    void OnCount()
    {
        MissionUIObj.SetActive(false);
        CountUIObj.SetActive(true);
    }
    void Clear()
    {
        spawner.Break();
        CountUIObj.SetActive(false);
        ClearUIObj.SetActive(true);
    }
}
