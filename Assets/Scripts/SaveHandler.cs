using UnityEngine;
using System.IO;

public class SaveHandler : MonoBehaviour
{
    private float actMinSpeed, actMaxSpeed, actSpawnRadius, actMinWhaitTime, actMaxWhaitTime;
    private int actMinLuck, actMaxLuck;

    //I did public copy of private variables, to save from change variable by cheats
    public float actminSpeed, actmaxSpeed, actspawnRadius, actminWhaitTime, actmaxWhaitTime;
    public int actminLuck, actmaxLuck;


    void Start()
    {
        //used to create json file
        /*PlayerData playerData = new PlayerData();
        string json = JsonUtility.ToJson(playerData);
        Debug.Log(json);

        File.WriteAllText(Application.dataPath + "/saveFile.json", json);*/


        // takes info from json file
        string json = File.ReadAllText(Application.dataPath + "/saveFile.json");
        PlayerData loadedPlayerData = JsonUtility.FromJson<PlayerData>(json);
        actMinSpeed = loadedPlayerData.minSpeed;
        actMaxSpeed = loadedPlayerData.maxSpeed;
        actSpawnRadius = loadedPlayerData.spawnRadius;
        actMinWhaitTime = loadedPlayerData.minWhaitTime;
        actMaxWhaitTime = loadedPlayerData.maxWhaitTime;
        actMinLuck = loadedPlayerData.minLuck;
        actMaxLuck = loadedPlayerData.maxLuck;



        actminSpeed = actMinSpeed;
        actmaxSpeed = actMaxSpeed;
        actspawnRadius = actSpawnRadius;
        actminWhaitTime = actMinWhaitTime;
        actmaxWhaitTime = actMaxWhaitTime;
        actminLuck = actMinLuck;
        actmaxLuck = actMaxLuck;

        

    }


    private class PlayerData
    {
        //used to create jsonFile
        public float minSpeed = 2.5f;
        public float maxSpeed = 4;
        public float spawnRadius = 4;
        public float minWhaitTime = 2;
        public float maxWhaitTime = 3.5f;
        public int minLuck = 1;
        public int maxLuck = 7;
    }
}
