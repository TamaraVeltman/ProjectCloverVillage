using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ConvManeger : MonoBehaviour
{
    public Conversation currentConversation;
    public TMP_Text textOnScreen;

    // Start is called before the first frame update
    void Start()
    {
        

        textOnScreen.text = currentConversation.conversation[1];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
