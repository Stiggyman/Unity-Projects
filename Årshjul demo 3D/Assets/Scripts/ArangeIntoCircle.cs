
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArangeIntoCircle : MonoBehaviour
{
    public GameObject[] myArrayObjects = new GameObject[68];

    private void Start()
    {
        this.instantiateInCircle(gameObject);
    }
    public void instantiateInCircle(GameObject obj)
    {
        Vector3 targetPositoin = Vector3.zero;

        foreach (GameObject gameObject in myArrayObjects)
        {
            float angle = (2 * Mathf.PI / 68);
            float x = Mathf.Cos(angle) * 0.1f;
            float y = Mathf.Sin(angle) * 0.1f;
            targetPositoin = new Vector3(targetPositoin.x + x, targetPositoin.y + y, 0);
            gameObject.transform.position = targetPositoin;
        }
    }
}
   