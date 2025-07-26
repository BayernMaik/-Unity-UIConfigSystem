using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEditor;

namespace UI.Test.Editor
{
    public class Test
    {
        private string relativePath = "Packages/com.bayernmaik.uiconfigsystem/Tests/Runtime";
        private Texture2D GetTexture2D(string name)
        {
            return (Texture2D)AssetDatabase.LoadAssetAtPath(
                this.relativePath + "/UI/" + name,
                typeof(Texture2D)
            );
        }
        [Test]
        public void TestCollections()
        {   // Arrange
            /*
            GameObject gameObjectAdd = new GameObject("Add");
            GameObject gameObjectCheck = new GameObject("Check");
            GameObject gameObjectClose = new GameObject("Close");
            GameObject gameObjectFavorite = new GameObject("Favorite");
            GameObject gameObjectHome = new GameObject("Home");
            GameObject gameObjectMenu = new GameObject("Menu");
            GameObject gameObjectSearch = new GameObject("Search");
            GameObject gameObjectSettings = new GameObject("Settings");

            Texture2D texture2DAdd = this.GetTexture2D("add_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24.png");
            Texture2D texture2DCheck = this.GetTexture2D("check_circle_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24");
            Texture2D texture2DClose = this.GetTexture2D("close_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24");
            Texture2D texture2DFavorite = this.GetTexture2D("favorite_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24");
            Texture2D texture2DHome = this.GetTexture2D("home_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24");
            Texture2D texture2DMenu = this.GetTexture2D("menu_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24");
            Texture2D texture2DSearch = this.GetTexture2D("search_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24");
            Texture2D texture2DSettings = this.GetTexture2D("settings_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24");

            // Assert.NotNull(texture2DAdd);
/*
            Config<GameObject, Texture2D>[] data = new Config<GameObject, Texture2D>[]{
                new Config<GameObject, Texture2D>(gameObjectAdd, texture2DAdd),
                new Config<GameObject, Texture2D>(gameObjectCheck, texture2DCheck),
                new Config<GameObject, Texture2D>(gameObjectClose, texture2DClose),
                new Config<GameObject, Texture2D>(gameObjectFavorite, texture2DFavorite),
                new Config<GameObject, Texture2D>(gameObjectHome, texture2DHome),
                new Config<GameObject, Texture2D>(gameObjectMenu, texture2DMenu),
                new Config<GameObject, Texture2D>(gameObjectSearch, texture2DSearch),
                new Config<GameObject, Texture2D>(gameObjectSettings, texture2DSettings)
            };
            ConfigCollection<GameObject, Texture2D> configs = new ConfigCollection<GameObject, Texture2D>(data);

                        // Act
                        Config<GameObject, Texture2D> configAdd = configs.GetConfig(gameObjectAdd);
                        Config<GameObject, Texture2D> configCheck = configs.GetConfig(gameObjectCheck);
                        Config<GameObject, Texture2D> configClose = configs.GetConfig(gameObjectClose);
                        Config<GameObject, Texture2D> configFavorite = configs.GetConfig(gameObjectFavorite);
                        Config<GameObject, Texture2D> configHome = configs.GetConfig(gameObjectHome);
                        Config<GameObject, Texture2D> configMenu = configs.GetConfig(gameObjectMenu);
                        Config<GameObject, Texture2D> configSearch = configs.GetConfig(gameObjectSearch);
                        Config<GameObject, Texture2D> configSettings = configs.GetConfig(gameObjectSettings);

                        // Assert
                        Assert.ReferenceEquals(texture2DAdd, configAdd.Data);
                        Assert.ReferenceEquals(texture2DCheck, configCheck.Data);
                        Assert.ReferenceEquals(texture2DClose, configClose.Data);
                        Assert.ReferenceEquals(texture2DFavorite, configFavorite.Data);
                        Assert.ReferenceEquals(texture2DHome, configHome.Data);
                        Assert.ReferenceEquals(texture2DMenu, configMenu.Data);
                        Assert.ReferenceEquals(texture2DSearch, configSearch.Data);
                        Assert.ReferenceEquals(texture2DSettings, configSettings.Data);
                        */












            /*
            // Arrange
            GameObject gameObjectAdd = new GameObject("Add");
            GameObject gameObjectCheck = new GameObject("Check");
            GameObject gameObjectClose = new GameObject("Close");
            GameObject gameObjectFavorite = new GameObject("Favorite");
            IConfigCollectionBase gameObjects = new ConfigCollection<GameObject, string>(
                new Config<GameObject, string>[]{
                    new Config<GameObject, string>(gameObjectAdd, "Add"),
                    new Config<GameObject, string>(gameObjectCheck, "Check"),
                    new Config<GameObject, string>(gameObjectClose, "Close"),
                    new Config<GameObject, string>(gameObjectFavorite, "Favorite"),
                }
            );
            Utility.Configs.Add(gameObjects);

            ScriptableObject scriptableObjectAdd = ScriptableObject.CreateInstance("Add");
            ScriptableObject scriptableObjectCheck = ScriptableObject.CreateInstance("Check");
            ScriptableObject scriptableObjectClose = ScriptableObject.CreateInstance("Close");
            ScriptableObject scriptableObjectFavorite = ScriptableObject.CreateInstance("Favorite");
            IConfigCollectionBase scriptableObjects = new ConfigCollection<ScriptableObject, string>(
                new Config<ScriptableObject, string>[]{
                    new Config<ScriptableObject, string>(scriptableObjectAdd, "Add"),
                    new Config<ScriptableObject, string>(scriptableObjectCheck, "Check"),
                    new Config<ScriptableObject, string>(scriptableObjectClose, "Close"),
                    new Config<ScriptableObject, string>(scriptableObjectFavorite, "Favorite"),
                }
            );
            Utility.Configs.Add(scriptableObjects);

            Texture2D texture2DAdd = this.GetTexture2D("add_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24.png");
            Texture2D texture2DCheck = this.GetTexture2D("check_circle_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24");
            Texture2D texture2DClose = this.GetTexture2D("close_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24");
            Texture2D texture2DFavorite = this.GetTexture2D("favorite_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24");
            IConfigCollectionBase textures = new ConfigCollection<Texture2D, string>(
                new Config<Texture2D, string>[]{
                    new Config<Texture2D, string>(texture2DAdd, "Add"),
                    new Config<Texture2D, string>(texture2DCheck, "Check"),
                    new Config<Texture2D, string>(texture2DClose, "Close"),
                    new Config<Texture2D, string>(texture2DFavorite, "Favorite"),
                }
            );
            Utility.Configs.Add(textures);
*/
            // Act

            // Assert

        }
    }
}