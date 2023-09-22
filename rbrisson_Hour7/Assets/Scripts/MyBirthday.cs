using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{

    int numberMonth = 1;
    int numberDay = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (numberMonth == 4)
        {
            Debug.Log("It's my birthday!");
            numberMonth++;
        }
        else if (numberMonth <= 12)
        {
            Debug.Log(numberMonth);
            numberMonth++;
        }

        if (numberDay == 8)
        {
            Debug.Log("It's my birthday!");
            numberDay++;
        }
        else if (numberDay <= 30)
        {
            Debug.Log(numberDay);
            numberDay++;
        }
    }
}
