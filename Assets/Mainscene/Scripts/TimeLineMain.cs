using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeLineMain : MonoBehaviour
{
    [SerializeField] private GameObject pannel;
    // Start is called before the first frame update
    void Start()
    {
        pannel.SetActive(false);
        Invoke("TurnPannelOn",2.5f);
    }

    void TurnPannelOn()
    {
        pannel.SetActive(true);
    }
}
