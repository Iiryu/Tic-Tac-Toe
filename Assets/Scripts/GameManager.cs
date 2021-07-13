using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static bool player1Turn = true;
    public static bool end = false;
    public static bool player1Win;
    public List<GameObject> buttonGameObjects = new List<GameObject>();
    public List<Button> buttons = new List<Button>();
    public List<Text> texts;
    public Text text;
    public List<bool> marus = new List<bool>();
    public List<Game> games = new List<Game>();
    public static int round;
    public int test = 5;

    

    public void Restart()
    {
        player1Turn = true;
        end = false;
        for(int i = 0; i <= buttonGameObjects.Count; i++)
        {
            
        }
    }

    private void Awake()
    {
        Debug.Log(buttonGameObjects.Count);
        GetVariable();

    }


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        SetText();

        if(round <= 9)
        {
            Restart();
        }
    }

    public void GetVariable()
    {
        for (int i = 0; i <= buttonGameObjects.Count; i++)
        {
            buttons[i] = buttonGameObjects[i].GetComponent<Button>();
        }
    }

    public void Test123()
    {
        for(int i = 0; i<= test; i++)
        {
            Debug.Log(i.ToString());
            buttons[i] = buttonGameObjects[i].GetComponent<Button>();
        }

    }



    public void Test()
    {
        Debug.Log(buttonGameObjects.Count);
        Debug.Log(buttons.Count);
        Debug.Log(marus.Count);
        Debug.Log(texts.Count);
    }

    public void SetText()
    {
        if (player1Turn)
        {
            text.text = "ÅZ Trun";
        }
        else
        {
            text.text = "Å~ Trun";
        }
    }

    public void GetIF()
    {
        Game game = buttons[0].GetComponent<Game>();
        marus[0] = game.maru;
    }

    public void Test2()
    {
        buttons[5] = buttonGameObjects[5].GetComponent<Button>();
        Debug.Log(buttons[5]);
    }
}
