using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverSpaceScript : MonoBehaviour
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
        if (FuelScript.fuelvalue == 0f)
        {
            GameOverText.text = "Fuel ran out \nPress R to restart";
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(0);
            }
        }

    }
}
