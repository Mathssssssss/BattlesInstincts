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

    public void SetHealthGUI() 
    {
        healthbarEnemy.value = (float)Enemy.currentHealth / Enemy.maxHealth;
        healthbarPlayer.value = (float)Player.currentHealth / Player.maxHealth;
    }
}
