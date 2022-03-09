using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{

    MeshRenderer render;
    Rigidbody rb;
    [SerializeField] float timeToWait = 2f;


    void Start()
    {
        render = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();
        render.enabled = false;
        rb.useGravity = false;
    }

    void Update()
    {
        if(Time.time > timeToWait)
        {
            render.enabled = true;
            rb.useGravity = true;
        }
    }
}
