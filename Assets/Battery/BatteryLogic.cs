using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryLogic : MonoBehaviour
{
    public battery_end south;
    public battery_end north;
    public GameObject obstacle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!south.contacted) return;
        if(!north.contacted) return;
        obstacle.SetActive(false);

    }
}
