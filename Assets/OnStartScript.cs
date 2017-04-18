using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnStartScript : MonoBehaviour
{
    string[] tiedot;
    public Transform Button;
    public Transform Elokuvateatteri;

    // Use this for initialization
    void Start()
    {
        tiedot = System.IO.File.ReadAllLines("movies.txt");

        for (int i = 0; i < tiedot.Length; i++) {
            //    Debug.Log(tiedot[i]);
            Instantiate(Button);
        }
    }
}
