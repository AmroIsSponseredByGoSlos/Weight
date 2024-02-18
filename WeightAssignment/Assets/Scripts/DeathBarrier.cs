using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DeathBarrier : MonoBehaviour
{
    private float Seconds;
    private float interval;
    public TextMeshProUGUI TimeText;
    public GameObject DeathCanvas;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Player.transform.position.x, -5, Player.transform.position.z);
        if (interval < 1)
        {
            interval = interval + Time.deltaTime;
        }
        else
        {
            Seconds++;
            interval = 0;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Player")
        {
            Time.timeScale = 0f; 
            DeathCanvas.SetActive(true);
            TimeText.text = $"You survived for {Seconds} seconds";
        }
    }

    public void PlayAgainClick()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1f;
    }
}
