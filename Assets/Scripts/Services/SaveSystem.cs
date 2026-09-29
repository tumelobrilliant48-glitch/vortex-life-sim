using System;
using UnityEngine;

namespace VortexLifeSim.Services
{
    public class SaveSystem : MonoBehaviour
    {
        public void SavePlayerData(string saveName, string jsonData)
        {
            PlayerPrefs.SetString(saveName, jsonData);
            PlayerPrefs.Save();
        }

        public string LoadPlayerData(string saveName)
        {
            if (PlayerPrefs.HasKey(saveName))
            {
                return PlayerPrefs.GetString(saveName);
            }

            return string.Empty;
        }

        public void DeleteSave(string saveName)
        {
            PlayerPrefs.DeleteKey(saveName);
        }
    }
}
