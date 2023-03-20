using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvManeger : MonoBehaviour
{
    public Conversation currentConversation;

    // Start is called before the first frame update
    void Start()
    {
        print(currentConversation.conversation[1]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
