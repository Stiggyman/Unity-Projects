using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableOrEnableObject: MonoBehaviour
{
    public GameObject første;
    public GameObject anden;
    public GameObject tredje;
    public GameObject fjerde;

   public void openPanel()
    {
        bool isActive = første.activeSelf;

        første.SetActive(!isActive); 
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
