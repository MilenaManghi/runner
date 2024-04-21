using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Bala : MonoBehaviour
{
    public GameObject bala;
    private float respawningTimer;
    public float timeSpawn;
    public GameObject instantiatePos;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Disparar();
        
    }

    private void Disparar()
    {
        respawningTimer -= Time.deltaTime;

        if (respawningTimer <= 0)
        {
            Instantiate(bala, instantiatePos.transform);
            respawningTimer = timeSpawn;
        }

    }


}
