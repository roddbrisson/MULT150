using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    public Light onOff;
    Light lightcomponent;

    // Start is called before the first frame update
    void Start()
    {
        onOff.enabled = true;
        lightcomponent = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.L))
            onOff.enabled = !onOff.enabled;
    }
}
