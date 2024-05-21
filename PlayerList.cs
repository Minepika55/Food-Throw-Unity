using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerList : MonoBehaviour
{
    public TextMeshProUGUI _playerListText;
    List<Player> players = new List<Player>();

    void Start()
    {
        // Jugadors
        players.Add(new Player("Tomaz91 ", 10));
        players.Add(new Player("Frost ", 50));
        players.Add(new Player("Ritz", 90));
        players.Add(new Player("LuckHax", 120));

        
        players.Sort();// Ordenar els jugadors

        
        Player TOP = players[players.Count - 1];// Seleccionar el millor

        
        PlayerPrefs.SetString("TOPName", TOP.name);// Guardar el millor
        PlayerPrefs.SetInt("TOPScore", TOP.click);

        
        MostrarLista();// Mostrar la lllista

        
        players.Add(new Player("Ultima Partida " + players.Count, -1));// Guardar l'ultima partida
    }

    void Update()
    {
        MostrarLista();
        GuardarJugadores();
    }

    void GuardarJugadores()
    {
        players[players.Count - 1].click = PlayerPrefs.GetInt("ScoreCorrect");
        for (int i = 0; i < players.Count; i++)
        {
            PlayerPrefs.SetString("Player" + i + "_Name", players[i].name);
            PlayerPrefs.SetInt("Player" + i + "_Click", players[i].click);
        }
        PlayerPrefs.SetInt("NumberOfPlayers", players.Count);
    }

    void CargarJugadores()
    {
        int numberOfPlayers = PlayerPrefs.GetInt("NumberOfPlayers", 0);
        if (numberOfPlayers > 0)
        {
            for (int i = 0; i < numberOfPlayers; i++)
            {
                string playerName = PlayerPrefs.GetString("Player" + i + "_Name");
                int playerClick = PlayerPrefs.GetInt("Player" + i + "_Click");
                players.Add(new Player(playerName, playerClick));
            }
        }
    }

    void MostrarLista()
    {
        string playerList = "";
        foreach (Player player in players)
        {
            playerList += player.name + " " + player.click + "\n";
        }
        _playerListText.text = playerList;

        Player TOP = players[players.Count - 1];
        string TOPMessage = "TOP: " + TOP.name + "/" + TOP.click;
        _playerListText.text += "\n" + TOPMessage;
    }
}
