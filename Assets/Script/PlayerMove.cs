using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    //movespeed variables
    [SerializeField] float moveSpeed = 5f;

    void Start()
    {
        
    }

    
    void Update()
    {
        MovePlayer();

    }

    void MovePlayer()
    {
        float x = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime; //side move
        float z = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime; //forwaad move
        transform.Translate(x, 0f, z);
    }

}
