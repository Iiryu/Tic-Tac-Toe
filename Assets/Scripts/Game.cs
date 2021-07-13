using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public GameObject buttonObject;
    public Button button;
    public Text text;
    public bool Puted = false;
    public bool maru = true;
    public static bool aaaa = true;

    // Start is called before the first frame update
    void Start()
    {
        buttonObject = this.gameObject;
        button = buttonObject.GetComponent<Button>();
        text = button.GetComponentInChildren<Text>();
        
    }

    public void Put()
    {
        if(Puted == true)
        {
            return;
        }
        if (GameManager.player1Turn == true)
        {
            text.text = "ÅZ";
            maru = true;
        }
        else
        {
            text.text = "Å~";
            maru = false;
        }

        GameManager.player1Turn = !GameManager.player1Turn;
        Puted = true;
        GameManager.round += 1;
    }




}
