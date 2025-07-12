using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEditor;

namespace UI.EditorTest
{
    public class TagTests
    {
        private string relativePath = "Packages/com.bayernmaik.uisystem/Tests/Editor";
        private Texture2D GetTexture2D(string name)
        {
            return (Texture2D)AssetDatabase.LoadAssetAtPath(
                this.relativePath + "/" + name,
                typeof(Texture2D)
            );
        }

        [Test]
        public void TestIconAdd()
        {
            /*
            // Arrange
            GameObject gameObjectAdd = new GameObject("Add");
            GameObject gameObjectCheck = new GameObject("Check");
            GameObject gameObjectClose = new GameObject("Close");
            GameObject gameObjectFavorite = new GameObject("Favorite");
            GameObject gameObjectHome = new GameObject("Home");
            GameObject gameObjectMenu = new GameObject("Menu");
            GameObject gameObjectSearch = new GameObject("Search");
            GameObject gameObjectSettings = new GameObject("Settings");

            Texture2D texture2DAdd = this.GetTexture2D("add_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24");
            Texture2D texture2DCheck = this.GetTexture2D("check_circle_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24");
            Texture2D texture2DClose = this.GetTexture2D("close_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24");
            Texture2D texture2DFavorite = this.GetTexture2D("favorite_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24");
            Texture2D texture2DHome = this.GetTexture2D("home_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24");
            Texture2D texture2DMenu = this.GetTexture2D("menu_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24");
            Texture2D texture2DSearch = this.GetTexture2D("search_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24");
            Texture2D texture2DSettings = this.GetTexture2D("settings_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24");
            
            Config<GameObject, Texture2D>[] data = new Config<GameObject, Texture2D>[]{
                Utility.CreateInstance<GameObject, Texture2D>(gameObjectAdd, texture2DAdd),
                Utility.CreateInstance<GameObject, Texture2D>(gameObjectCheck, texture2DCheck),
                Utility.CreateInstance<GameObject, Texture2D>(gameObjectClose, texture2DClose),
                Utility.CreateInstance<GameObject, Texture2D>(gameObjectFavorite, texture2DFavorite),
                Utility.CreateInstance<GameObject, Texture2D>(gameObjectHome, texture2DHome),
                Utility.CreateInstance<GameObject, Texture2D>(gameObjectMenu, texture2DMenu),
                Utility.CreateInstance<GameObject, Texture2D>(gameObjectSearch, texture2DSearch),
                Utility.CreateInstance<GameObject, Texture2D>(gameObjectSettings, texture2DSettings)
            };
            
            // Configs<GameObject, Texture2D> configs = Utility.CreateInstance<GameObject, Texture2D>();

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
        }
    }
}