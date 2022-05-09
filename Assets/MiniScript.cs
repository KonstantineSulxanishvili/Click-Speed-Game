using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiniScript : MonoBehaviour
{
    [SerializeField] private Text myText;
    int mySecondint = 0;
    void Start()
    {
        myText.text=mySecondint.ToString();
        
    }
    void Update()
    {
        
    }
    public void ButtonPress()
    {
        mySecondint--;
        myText.text=mySecondint.ToString();
    }
}
