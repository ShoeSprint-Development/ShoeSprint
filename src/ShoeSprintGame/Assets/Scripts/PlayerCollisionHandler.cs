using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollisionHandler: MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            Debug.Log("Player collided with obstacle");
            SceneManager.LoadScene(2);
            //Change this to a game over screen or something else
            //SceneManager.LoadScene("index game over scene");
        }
    }
}
