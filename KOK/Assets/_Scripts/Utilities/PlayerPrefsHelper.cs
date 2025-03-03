﻿using KOK.ApiHandler.DTOModels;
using UnityEngine;
using WebSocketSharp;

namespace KOK
{
    public static class PlayerPrefsHelper
    {
        #region LoginData
        public static string[] LoginDataKeys = { Key_AccessToken, "RefreshToken", "AccountId", "UserName", "Email", "Gender", "Role", "PhoneNumber", "CharacterItemId", "RoomItemId", "AccountStatus", "CharaterItemCode", "RoomItemCode" };
        public static readonly string Key_AccessToken = "AccessToken";
        public static readonly string Key_RefreshToken = "RefreshToken";
        public static readonly string Key_AccountId = "AccountId";
        public static readonly string Key_UserName = "UserName";
        public static readonly string Key_Email = "Email";
        public static readonly string Key_Gender = "Gender";
        public static readonly string Key_Role = "Role";
        public static readonly string Key_PhoneNumber = "PhoneNumber";
        public static readonly string Key_CharacterItemId = "CharacterItemId";
        public static readonly string Key_RoomItemId = "RoomItemId";
        public static readonly string Key_AccountStatus = "AccountStatus";
        public static readonly string Key_CharaterItemCode = "CharaterItemCode";
        public static readonly string Key_RoomItemCode = "RoomItemCode";
        #endregion
        #region SetMethods

        public static void SetString(string key, string value)
        {
            PlayerPrefs.SetString(key, value);
            PlayerPrefs.Save();
        }

        public static void SetInt(string key, int value)
        {
            PlayerPrefs.SetInt(key, value);
            PlayerPrefs.Save();
        }

        public static void SetFloat(string key, float value)
        {
            PlayerPrefs.SetFloat(key, value);
            PlayerPrefs.Save();
        }

        #endregion

        #region GetMethods

        public static string GetString(string key, string defaultValue = "")
        {
            return PlayerPrefs.GetString(key, defaultValue);
        }

        public static int GetInt(string key, int defaultValue = 0)
        {
            return PlayerPrefs.GetInt(key, defaultValue);
        }

        public static float GetFloat(string key, float defaultValue = 0.0f)
        {
            return PlayerPrefs.GetFloat(key, defaultValue);
        }

        #endregion

        #region DeleteMethods

        public static void DeleteKey(string key)
        {
            if (PlayerPrefs.HasKey(key))
            {
                PlayerPrefs.DeleteKey(key);
                PlayerPrefs.Save();
            }
        }

        public static void DeleteAll()
        {
            PlayerPrefs.DeleteAll();
            PlayerPrefs.Save();
        }

        #endregion

        #region CheckKey

        public static bool HasKey(string key)
        {
            return PlayerPrefs.HasKey(key);
        }

        #endregion

        #region LoginData

        public static void SetLoginData(LoginResponse loginData)
        {
            // { "AccessToken", "RefreshToken", "AccountId", "UserName", "Email", "Gender", "Role", "PhoneNumber", "CharacterItemId", "RoomItemId", "AccountStatus" }
            PlayerPrefs.SetString(LoginDataKeys[0], loginData.AccessToken);
            PlayerPrefs.SetString(LoginDataKeys[1], loginData.RefreshToken);
            PlayerPrefs.SetString(LoginDataKeys[2], loginData.Value.AccountId.ToString());
            PlayerPrefs.SetString(LoginDataKeys[3], loginData.Value.UserName);
            PlayerPrefs.SetString(LoginDataKeys[4], loginData.Value.Email);
            PlayerPrefs.SetString(LoginDataKeys[5], loginData.Value.Gender.ToString());
            PlayerPrefs.SetString(LoginDataKeys[6], loginData.Value.Role.ToString());
            PlayerPrefs.SetString(LoginDataKeys[7], loginData.Value.PhoneNumber);
            PlayerPrefs.SetString(LoginDataKeys[8], loginData.Value.CharacterItemId.ToString());
            PlayerPrefs.SetString(LoginDataKeys[9], loginData.Value.RoomItemId.ToString());
            PlayerPrefs.SetString(LoginDataKeys[10], loginData.Value.AccountStatus.ToString());
            PlayerPrefs.SetString(LoginDataKeys[11], loginData.Value.CharaterItemCode.ToString());
            PlayerPrefs.SetString(LoginDataKeys[12], string.Empty);
            PlayerPrefs.Save();
        }

        public static void SetProfileData(Account account)
        {
            PlayerPrefs.SetString(Key_UserName, account.UserName);
            PlayerPrefs.SetString(Key_Email, account.Email);
            PlayerPrefs.SetString(Key_Gender, account.Gender.ToString());
            PlayerPrefs.SetString(Key_PhoneNumber, account.PhoneNumber);
            PlayerPrefs.SetString(Key_CharacterItemId, account.CharacterItemId.ToString());
            PlayerPrefs.SetString(Key_RoomItemId, account.RoomItemId.ToString());
            PlayerPrefs.Save();
        }

        public static void DeleteLoginData()
        {
            foreach (var key in LoginDataKeys)
            {
                DeleteKey(key);
            }
        }

        public static void SetAccountData(Account account)
        {
            // { "AccessToken", "RefreshToken", "AccountId", "UserName", "Email", "Gender", "Role", "PhoneNumber", "CharacterItemId", "RoomItemId", "AccountStatus" }
            //PlayerPrefs.SetString(LoginDataKeys[0], loginData.AccessToken);
            //PlayerPrefs.SetString(LoginDataKeys[1], loginData.RefreshToken);
            PlayerPrefs.SetString(LoginDataKeys[2], account.AccountId.ToString());
            PlayerPrefs.SetString(LoginDataKeys[3], account.UserName);
            PlayerPrefs.SetString(LoginDataKeys[4], account.Email);
            PlayerPrefs.SetString(LoginDataKeys[5], account.Gender.ToString());
            PlayerPrefs.SetString(LoginDataKeys[6], account.Role.ToString());
            PlayerPrefs.SetString(LoginDataKeys[7], account.PhoneNumber);
            PlayerPrefs.SetString(LoginDataKeys[8], account.CharacterItemId.ToString());
            PlayerPrefs.SetString(LoginDataKeys[9], account.RoomItemId.ToString());
            PlayerPrefs.SetString(LoginDataKeys[10], account.AccountStatus.ToString());
            PlayerPrefs.SetString(LoginDataKeys[11], account.CharaterItemCode.ToString());
            PlayerPrefs.SetString(LoginDataKeys[12], string.Empty);
            PlayerPrefs.Save();
        }

        #endregion  
    }
}
