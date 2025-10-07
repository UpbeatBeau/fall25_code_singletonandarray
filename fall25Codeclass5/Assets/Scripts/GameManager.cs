using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Variables
    public int score = 0;

    public TextMeshProUGUI text;

    //Make an Array
    private string newgamename = "Metriod";

    public string[] gamelist = new string[10] {/*0*/"Fortnite",/*1*/"Street Fighter",/*2*/"Skate",/*3*/"Lethal League","Silksong","Yakuza","Blue Prince","Ghost of Yotei","God of War",/*9*/"Mario"}; 

    //Singleton
    public static GameManager instance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        gamelist[0] = newgamename;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = gamelist[score];
    }
    public void dosomething()
    {

    }
}
