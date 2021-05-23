using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDestroyScript : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //print("GameOver" + gameObject.tag);
            Destroy(collision.gameObject);
            SceneManager.LoadScene(2);
        }
    }
}
