using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Death")
        {
            //Invoke("ReloadScene", 1f);
            SceneManager.LoadScene(0);
        }
    }
   /* void RealoadScene()
    {
        SceneManager.LoadScene(1);
    }*/

}
