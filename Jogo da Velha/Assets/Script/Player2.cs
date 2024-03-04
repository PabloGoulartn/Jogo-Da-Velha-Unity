using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    [SerializeField] private TMP_Text player2Text;
    
    Player1 player;

    void Start()
    {
        player = FindAnyObjectByType<Player1>();
    }

    void Update()
    {
        if(player.CanPlay == false)
        {
            MakeSelection();
        }
    }

    int RandomSelection()
    {
        return Random.Range(1, 4);
    }

    void MakeSelection()
    {
        switch(RandomSelection())
        {
            case 1:
                player2Text.text = "Pedra";
            break;
            case 2:
                player2Text.text = "Papel";
            break;
            case 3:
                player2Text.text = "Tesoura";
            break;
        }

        player.CanPlay = true;
    }
}
