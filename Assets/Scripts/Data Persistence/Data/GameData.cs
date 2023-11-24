using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class GameData 
{
    public int enemyCount;

    //the values defined in this contructor will be the default values
    //the game starts with when there's no data to load

    public GameData()
    {
        this.enemyCount = 0;
    }
}
