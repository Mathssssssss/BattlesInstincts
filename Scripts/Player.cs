using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private CombatConfig ConfigurationPlayer;
    [SerializeField] private CombatConfig ConfigurationEnemy;
    [SerializeField] private UnityEvent UpdatingEvent;
    
    void Start() 
    {
        UpdatingEvent?.Invoke();
    }

    public void Attack() 
    {
        if (!ConfigurationEnemy.isDefended) 
        {
            ConfigurationEnemy.currentHealth -= ConfigurationPlayer.damage;
        }
        else 
        {
            ConfigurationEnemy.isDefended = false;
        }
        UpdatingEvent?.Invoke();
    }
    public void Heal()
    {
        if(ConfigurationPlayer.currentHealth + ConfigurationPlayer.heal <= ConfigurationPlayer.maxHealth) 
        {
            ConfigurationPlayer.currentHealth += ConfigurationPlayer.heal;
        }
        UpdatingEvent?.Invoke();
    }
    public void Defend() 
    {
        if (!ConfigurationPlayer.isDefended) { ConfigurationPlayer.isDefended = true; }
    }
}
