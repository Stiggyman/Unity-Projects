using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableOrEnableObject: MonoBehaviour
{
    public GameObject f�rste;
    public GameObject anden;
    public GameObject tredje;
    public GameObject fjerde;

   public void openPanel()
    {
        bool isActive = f�rste.activeSelf;

        f�rste.SetActive(!isActive); 
    }
    public void openPanel1()
    {
        bool isActive = anden.activeSelf;
        anden.SetActive(!isActive);
    }
    public void openPanel2()
    {
        bool isActive = tredje.activeSelf;
        tredje.SetActive(!isActive);
    }
    public void openPanel3()
    {
        bool isActive = fjerde.activeSelf;
         fjerde.SetActive(!isActive);
    }
}
