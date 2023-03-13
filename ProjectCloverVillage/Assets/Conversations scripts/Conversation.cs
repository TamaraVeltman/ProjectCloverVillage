using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Conversation", menuName = "Conversation", order = 1)]
public class Conversation : ScriptableObject
{
    public string[] conversation;
    public string[] answer;
}
