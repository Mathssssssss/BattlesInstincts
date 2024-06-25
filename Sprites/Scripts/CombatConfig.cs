using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatConfig : MonoBehaviour
{
    [SerializeField] private int MaxHealth;
    [SerializeField] private int CurrentHealth;
    [SerializeField] private int Damage;
    [SerializeField] private int Heal;

    public int maxHealth { get => MaxHealth;}
    public int currentHealth { get => CurrentHealth; set => CurrentHealth = value; }
    public int damage { get => Damage;}
    public int heal { get => Heal;}


}
