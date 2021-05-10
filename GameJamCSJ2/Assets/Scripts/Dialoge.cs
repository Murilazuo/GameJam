using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Dialoge : MonoBehaviour
{
    public string[] speech;

    Animator anim;
    Text text;
    void Start()
    {
        anim = GetComponent<Animator>();
        text = GetComponent<Text>();
    }
    public void ChangeText(int idSpeech)
    {
        text.text = speech[idSpeech];
        anim.SetTrigger("Appear");
    }
    
}
