using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    // hand 오브젝트의 palm에 이 스크립트가 들어가야 합니다.

    public GameObject Palm;
    public GameObject middleFinger; // middle-bone3

    public Manager gameManager;
    public GameObject shootObject;
    public Transform shootPos;
    public AudioSource ShootSound;

    bool reload = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Vector3.Distance(Palm.transform.position, middleFinger.transform.position));
        if (Vector3.Distance(Palm.transform.position, middleFinger.transform.position) < 0.05f)
        {
            if (reload)
            {
                Shoot();
                reload = false;
            }
        }
        else
        {
            reload = true;
        }
    }


    public void Shoot()
    {
        ShootSound.Play();
        Instantiate(shootObject
            , shootPos.position
            , Quaternion.LookRotation(shootPos.forward, shootPos.up)
        );
    }
}
