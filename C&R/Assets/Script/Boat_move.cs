using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat_move : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 100f;
    public float turnSpeed = 840f;
    float tempDfata = 500f;
    //public Animator animator;

    // void Awake()
    // {
    //     animator = GetComponent<Animator>();
    // }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = 0;
        float v = 0;

        if(Input.GetKey(KeyCode.W))
        {
            v = 0.2f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            v = -0.2f;
        }
        else
        {
            v = 0;
        }

        if (Input.GetKey(KeyCode.A))
        {
        //    animator.SetBool("is", true);
            h = -0.2f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            h = 0.2f;
        }
        else
        {
            h = 0;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            GameObject.Find("tank").transform.position = new Vector3(0, 0, 0);
        }

        if (Input.inputString != "") Debug.Log(Input.inputString);

        transform.Translate(0f, 0f, v * moveSpeed * Time.deltaTime);

        transform.Rotate(0f, h * turnSpeed * Time.deltaTime, 0f);
    }
}
