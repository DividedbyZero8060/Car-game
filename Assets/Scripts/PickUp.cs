using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    GameObject gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("gameManager");
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
        gameManager.GetComponent<GameManager>().onCoinCollected();
        gameManager.GetComponent<GameManager>().CoinGenerator();

    }
}
