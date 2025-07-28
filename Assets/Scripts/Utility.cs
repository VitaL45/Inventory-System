using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utility : MonoBehaviour
{
    public static int health, stamina, mana;
    public static int strength, defence, agility;
    public static int maxStat = 20;

    public static void Start()
    {
        health = stamina = mana = 0;
        strength = defence = agility = 0;
    }
}
