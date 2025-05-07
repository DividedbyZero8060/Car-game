using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    int coinCounter = 0, maxCoins = 5, timer = 0;

    public GameObject coinPrefab;
    GameObject player;
    GameObject pedestrian;

    [SerializeField] TextMeshProUGUI countdownText;
    [SerializeField] TextMeshProUGUI counterText;
    [SerializeField] Button startButton;
    [SerializeField] Button restartButton;

    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Car");
        
        
        pedestrian = GameObject.FindGameObjectWithTag("Human");
        
        counterText.SetText("Coins : {0}/{1}",coinCounter,maxCoins);
        
        countdownText.SetText(timer.ToString());
        restartButton.gameObject.SetActive(false);


    }

    public void CoinGenerator()
    {
        Vector3 randomPos = new Vector3(Random.Range(-15, 22), 1, Random.Range(0, 68));
        Instantiate(coinPrefab, randomPos, Quaternion.Euler(90, 0, 0));
    }

    public void StartGame()
    {
        CoinGenerator();
        StartCoroutine(CountIt());
        startButton.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
        player.GetComponent<PlayerController>().enabled = true;
        pedestrian.GetComponent<CharacterControllerScript>().Toggle();
    }

    IEnumerator CountIt()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.0f);
            timer++;
            countdownText.SetText(timer.ToString());
            if (coinCounter == maxCoins)
            {
                GameOver();
                break;
            }
            
        }

    }

    public void GameOver()
    {
        restartButton.gameObject.SetActive(true);
        player.GetComponent<PlayerController>().enabled = false;
        pedestrian.GetComponent<CharacterControllerScript>().enabled = false;
        pedestrian.GetComponent<CharacterControllerScript>().Toggle();
        StopAllCoroutines();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void onCoinCollected()
    {
        coinCounter++;
        counterText.SetText("Coins: {0}/{1}", coinCounter, maxCoins);

        
    }

    public void Restart()
    {
        timer = 0;
        coinCounter = 0;
        startButton.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
        pedestrian.GetComponent<CharacterControllerScript>().enabled = true;
        pedestrian.GetComponent<CharacterControllerScript>().Toggle();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
       
    }
}
