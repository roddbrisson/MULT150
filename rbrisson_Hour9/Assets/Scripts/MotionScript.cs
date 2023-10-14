using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		float hVal = Input.GetAxis ("Horizontal") * Time.deltaTime;
		float vVal = Input.GetAxis ("Vertical") * Time.deltaTime;
		transform.Translate (hVal, vVal , 0);
    }
}
