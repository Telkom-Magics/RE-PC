using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class mbscript : MonoBehaviour
{
    public Animation Animasi;
    // Start is called before the first frame update
    void start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Animasi = GetComponent<Animation>();
    }

    public void mbtocase()
    {
        Animasi.Play("mbtocase");
    }
}