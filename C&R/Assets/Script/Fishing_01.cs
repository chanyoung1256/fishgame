using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fishing_01 : MonoBehaviour
{
    public Animator Fishing;
  
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            Fishing.SetBool("Fishing", true);
            Invoke("SwitchScene", 2.5f);
        }
        else
        {
            Fishing.SetBool("Fishing", false);
        }
    }
    
    void SwitchScene()
    {
        SceneManager.LoadScene("Fishzone");
    }
}
