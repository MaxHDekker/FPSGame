﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_Movement : MonoBehaviour
{

    public Transform Player;
    [SerializeField]
    private int MoveSpeed = 4;
    private int MaxDist = 10;
    [SerializeField]
    private float MinDist = 1;

    void Update()
    {
        Player = GameObject.FindWithTag("Player").transform;
        transform.LookAt(Player);

        if (Vector3.Distance(transform.position, Player.position) >= MinDist)
        {

            transform.position += transform.forward * MoveSpeed * Time.deltaTime;

        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(col.gameObject);
        }

        if (col.gameObject.tag == "Bullet")
        {
            Destroy(this.gameObject);
        }
    }
}