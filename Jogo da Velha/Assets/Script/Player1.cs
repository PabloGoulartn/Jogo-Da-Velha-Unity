using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Player1 : MonoBehaviour
{
    [SerializeField] private TMP_Text info;
    private bool canPlay = true;

    public void Rock()
    {
        Jokenpo("Pedra");
    }

    public void Paper()
    {
        Jokenpo("Papel");
    }

    public void Scissors()
    {
        Jokenpo("Tesoura");
    }

    void Jokenpo(string option)
    {

        info.text = option;
        canPlay = false;
    }
    
    public bool CanPlay
    {
        set { canPlay = value; }
        get { return canPlay; }
    }
}
