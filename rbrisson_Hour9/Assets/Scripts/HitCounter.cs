using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitCounter : MonoBehaviour
{

    int count = 1;
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name + " has hit the cube " + count);
        count++;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
