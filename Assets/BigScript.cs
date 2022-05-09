using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BigScript : MonoBehaviour
{
    [SerializeField] private Text myText;
    int myfirstint = 0;
    void Start()
    {
        myText.text=myfirstint.ToString();
        
    }
    void Update()
    {
        
    }
    public void ButtonPress()
    {
        myfirstint++;
        myText.text=myfirstint.ToString();
    }
}
