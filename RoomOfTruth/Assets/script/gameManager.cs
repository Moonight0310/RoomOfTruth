using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    
    public Text talkText;
    private talk_manager talkmanager;
    string TalkData;

    private int id = 1000;
    private int talkIndex = 0;
    private void Start()
    {
        guestAction();
        
    }
    private void guestAction()
    {
        
        talkText.text = TalkData;
    }
}
