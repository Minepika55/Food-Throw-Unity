using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private GameManager gameManager;
    private Rigidbody targetRb;
    // Start is called before the first frame update
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();
        targetRb.AddForce(Vector3.up * Random.Range(12, 16), ForceMode.Impulse);
        targetRb.AddTorque(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10), ForceMode.Impulse);
        transform.position = new Vector3(Random.Range(-4,4), -6);
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnMouseDown()
    {
        gameManager.UpdateScore(gameManager.pointValue);

        if (gameObject.CompareTag("Bad"))
        {
            gameManager.UpdateVida(1);
            PlayerData.scoreIncorrect++;
            int newScoreCorrect = 1 + PlayerPrefs.GetInt("scoreIncorrect");
            PlayerPrefs.SetInt("scoreIncorrect", newScoreCorrect);
        }
        if (gameObject.CompareTag("good"))
        {
            int newScoreCorrect = 1 + PlayerPrefs.GetInt("scoreCorrect");
            PlayerPrefs.SetInt("scoreCorrect", newScoreCorrect);
        }

        Destroy(gameObject);

    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
