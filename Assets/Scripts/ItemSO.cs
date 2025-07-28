using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ItemSO : ScriptableObject
{
    public string itemName;
    public StatToChange statToChange = new StatToChange();
    public int amountToChangeStat;
    public AttributesToChange attributesToChange = new AttributesToChange();
    public int amountToChangeAttribute;

    public bool UseItem()
    {
        if (statToChange == StatToChange.health)
        {
            if (Utility.health >= Utility.maxStat)
            {
                return false;
            }
            Utility.health += amountToChangeStat;
            Debug.Log("Heath = " + Utility.health);
        }
        else if (statToChange == StatToChange.stamina)
        {
            Utility.stamina += amountToChangeStat;
        }
        else if (statToChange == StatToChange.mana)
        {
            Utility.mana += amountToChangeStat;
        }
        return true;
    }

    public enum StatToChange
    {
        none,
        health,
        stamina,
        mana
    };

    public enum AttributesToChange
    {
        none,
        strength,
        defense,
        agility
    };
}
