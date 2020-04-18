using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject GameOverUI;
    public static GameManager Instance;
    public Text endMassage;
    private EnemySpawner enemySpawner;
    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
        enemySpawner = GetComponent<EnemySpawner>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Win()
    {
        GameOverUI.SetActive(true);
        endMassage.text = "胜 利";
    }
    public void Faild()
    {
        enemySpawner.Stop();
        GameOverUI.SetActive(true);
        endMassage.text = "失 败";
    }
    public void OnButtonRetry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void OnButtonMenu()
    {
        SceneManager.LoadScene(0);
    }
}
