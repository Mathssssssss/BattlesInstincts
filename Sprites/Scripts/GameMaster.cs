using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    [SerializeField] private Slider healthbarEnemy;
    [SerializeField] private Slider healthbarPlayer;
    [SerializeField] private CombatConfig Enemy;
    [SerializeField] private CombatConfig Player;


    void Start()
    {
        healthbarEnemy.value = 1;
        healthbarPlayer.value = 1;
    }

    void SetHealthGUI() 
    {
        healthbarEnemy.value = Enemy.currentHealth / Enemy.maxHealth;
        healthbarPlayer.value = Player.currentHealth / Player.maxHealth;
    }
}
