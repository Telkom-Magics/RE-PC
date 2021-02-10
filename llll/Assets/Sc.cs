using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc : MonoBehaviour
{
    public Animator Animasi;
    // Start is called before the first frame update
    public void OnGazeEnter()
    {
        if (Input.GetKeyDown("1"))
        {
            Debug.Log("You are entering the box");
            Animasi.Play("mbtocase");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}