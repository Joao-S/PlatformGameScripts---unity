using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text _scoretxt;
    public Text _livestxt;
    // Start is called before the first frame update
    void Start()
    {
        _scoretxt = GameObject.Find("Score").GetComponent<Text>();
        _scoretxt = GameObject.Find("Lives").GetComponent<Text>();
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore(int _score)
    {
        _scoretxt.text = "Coins:  " + _score;
    }

    public void UpdateLives(int _lives)
    {
        _livestxt.text = "Lives:  " + _lives;
    }
}
