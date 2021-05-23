using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    Text GameOverText;
    // Start is called before the first frame update
    void Start()
    {
        GameOverText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(FuelScript.fuelvalue == 0f)
        {
            GameOverText.text = "Game Over";
        }
        
    }
}
