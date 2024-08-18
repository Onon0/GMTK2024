using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageLogic : MonoBehaviour
{
    private GameObject GameManager;
    private void Start()
    {
        GameManager = GameObject.Find("GameManager");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision == null) return;

        GameManager.GetComponent<GameManagerScript>().setRestart();
    }
}
