using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinishGame : MonoBehaviour
{
    [SerializeField] private TMP_Text player1Text;
    [SerializeField] private TMP_Text player2Text;
    [SerializeField] private TMP_Text FinishText;

    void Update()
    {
        DetermineWinner();
    }

    void DetermineWinner()
    {
        if (player1Text.text == player2Text.text)
        {
            FinishText.text = "Empate!";
        }
        if(player1Text.text == "Tesoura" && player2Text.text == "Papel" ||
        player1Text.text == "Pedra" && player2Text.text == "Tesoura" ||
        player1Text.text == "Papel" && player2Text.text == "Pedra")
        {
            FinishText.text = "Jogador 1 ganhou!";
        }
        if(player2Text.text == "Tesoura" && player1Text.text == "Papel" ||
        player2Text.text == "Pedra" && player1Text.text == "Tesoura" ||
        player2Text.text == "Papel" && player1Text.text == "Pedra")
        {
            FinishText.text = "Jogador 2 ganhou!";
        }
    }
}
