using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    Button button;
    GameManager gameManager;
    public int dificulty;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        button.onClick.AddListener(SetDifficulty);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SetDifficulty()
    {
        gameManager.StartGame(dificulty);
        Debug.Log(gameObject.name + "was clicked");
    }
}
