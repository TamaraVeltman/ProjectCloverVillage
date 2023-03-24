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
        print(currentConversation.conversation[0]);

        textOnScreen.text = currentConversation.conversation[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
