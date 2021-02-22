using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadScene(string scenee2)
    {
       SceneManager.LoadScene(scenee2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
