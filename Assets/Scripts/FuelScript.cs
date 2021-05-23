using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelScript : MonoBehaviour
{
    public static float fuelvalue = 99f;
    Text Fuel;
    // Start is called before the first frame update
    void Start()
    {
        Fuel = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Fuel.text = "FUEL : " + fuelvalue;
    }
}
