using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatConfig : MonoBehaviour
{
    [SerializeField] private int MaxHealth;
    [SerializeField] private int CurrentHealth;
    [SerializeField] private int Damage;
    [SerializeField] private int Heal;

    public int MaxHealth1 { get => MaxHealth;}
    public int CurrentHealth { get => CurrentHealth; set => CurrentHealth = value; }
    public int Damage { get => Damage;}
    public int Heal { get => Heal;}


}
