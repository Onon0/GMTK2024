using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battery_end : MonoBehaviour
{
    public bool contacted;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        contacted = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        contacted = false;
    }
}
