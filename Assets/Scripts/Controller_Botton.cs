using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Botton : MonoBehaviour
{
    public GameObject enemy;
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(enemy);
        }
    }
}
