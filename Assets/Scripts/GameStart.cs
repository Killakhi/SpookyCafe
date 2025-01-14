using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    public GameObject player, SoulImage, SoulAmount,HeartGroup;

    public GameObject Screen, StartButton,Title, InstuctionK, InstuctionC,restart;

    //public AudioSource TitleMusic;
    


    // Start is called before the first frame update
    void Start()
    {
        player.SetActive(false);
        SoulImage.SetActive(false);
        SoulAmount.SetActive(false);
        HeartGroup.SetActive(false);
        restart.SetActive(false);

        Screen.SetActive(true);
        StartButton.SetActive(true);
        Title.SetActive(true);
        InstuctionK.SetActive(true);
        InstuctionC.SetActive(true);

        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        player.SetActive(true);
        SoulImage.SetActive(true);
        SoulAmount.SetActive(true);
        HeartGroup.SetActive(true);

        Screen.SetActive(false);
        StartButton.SetActive(false);
        Title.SetActive(false);
        InstuctionK.SetActive(false);
        InstuctionC.SetActive(false);

        SceneManager.LoadScene(1);
    }
}
