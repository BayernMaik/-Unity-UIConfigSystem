using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace UI.Test.Runtime
{
    public class TestRuntime
    {
        private string relativePath = "Packages/com.bayernmaik.uiconfigsystem/Tests/Runtime";
        private Texture2D GetTexture2D(string name)
        {
            return (Texture2D)UnityEditor.AssetDatabase.LoadAssetAtPath(
                this.relativePath + "/UI/" + name,
                typeof(Texture2D)
            );
        }
        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator TestCollection()
        {
            // Arrange
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
            ConfigList<GameObject, Texture2D> configs = new ConfigList<GameObject, Texture2D>(data);

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
            Assert.IsTrue(texture2DAdd == configAdd.Value);
            Assert.IsTrue(texture2DCheck == configCheck.Value);
            Assert.IsTrue(texture2DClose == configClose.Value);
            Assert.IsTrue(texture2DFavorite == configFavorite.Value);
            Assert.IsTrue(texture2DHome == configHome.Value);
            Assert.IsTrue(texture2DMenu == configMenu.Value);
            Assert.IsTrue(texture2DSearch == configSearch.Value);
            Assert.IsTrue(texture2DSettings == configSettings.Value);
            
            yield return null;
        }

        [UnityTest]
        public IEnumerator TestCollectionContainers()
        {
            // Arrange
            GameObject gameObjectAdd = new GameObject("Add");
            GameObject gameObjectCheck = new GameObject("Check");
            GameObject gameObjectClose = new GameObject("Close");
            GameObject gameObjectFavorite = new GameObject("Favorite");
            ConfigCollectionBase gameObjects = new ConfigList<GameObject, string>(
                new Config<GameObject, string>[]{
                    new Config<GameObject, string>(gameObjectAdd, "Add"),
                    new Config<GameObject, string>(gameObjectCheck, "Check"),
                    new Config<GameObject, string>(gameObjectClose, "Close"),
                    new Config<GameObject, string>(gameObjectFavorite, "Favorite")
                }
            );
            
            Texture2D texture2DAdd = this.GetTexture2D("add_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24.png");
            Texture2D texture2DCheck = this.GetTexture2D("check_circle_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24");
            Texture2D texture2DClose = this.GetTexture2D("close_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24");
            Texture2D texture2DFavorite = this.GetTexture2D("favorite_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24");
            ConfigCollectionBase textures = new ConfigList<Texture2D, string>(
                new Config<Texture2D, string>[]{
                    new Config<Texture2D, string>(texture2DAdd, "Add"),
                    new Config<Texture2D, string>(texture2DCheck, "Check"),
                    new Config<Texture2D, string>(texture2DClose, "Close"),
                    new Config<Texture2D, string>(texture2DFavorite, "Favorite")
                }
            );

            ConfigContainer container = new ConfigContainer(
                gameObjects,
                textures
            );
            
            // Act
            Config<GameObject, string> configGameObjectAdd = container.GetConfig<GameObject, string>(gameObjectAdd);
            Config<GameObject, string> configGameObjectCheck = container.GetConfig<GameObject, string>(gameObjectCheck);
            Config<GameObject, string> configGameObjectClose = container.GetConfig<GameObject, string>(gameObjectClose);
            Config<GameObject, string> configGameObjectFavorite = container.GetConfig<GameObject, string>(gameObjectFavorite);
            
            Config<Texture2D, string> configTexture2DAdd = container.GetConfig<Texture2D, string>(texture2DAdd);
            Config<Texture2D, string> configTexture2DCheck = container.GetConfig<Texture2D, string>(texture2DCheck);
            Config<Texture2D, string> configTexture2DClose = container.GetConfig<Texture2D, string>(texture2DClose);
            Config<Texture2D, string> configTexture2DFavorite = container.GetConfig<Texture2D, string>(texture2DFavorite);

            // Assert            
            Assert.IsTrue(gameObjectAdd == configGameObjectAdd.Key);
            Assert.IsTrue("Add" == configGameObjectAdd.Value);
            Assert.IsTrue(gameObjectCheck == configGameObjectCheck.Key);
            Assert.IsTrue("Check" == configGameObjectCheck.Value);
            Assert.IsTrue(gameObjectClose == configGameObjectClose.Key);
            Assert.IsTrue("Close" == configGameObjectClose.Value);
            Assert.IsTrue(gameObjectFavorite == configGameObjectFavorite.Key);
            Assert.IsTrue("Favorite" == configGameObjectFavorite.Value);       
            
            Assert.IsTrue(texture2DAdd == configTexture2DAdd.Key);
            Assert.IsTrue("Add" == configTexture2DAdd.Value);
            Assert.IsTrue(texture2DCheck == configTexture2DCheck.Key);
            Assert.IsTrue("Check" == configTexture2DCheck.Value);
            Assert.IsTrue(texture2DClose == configTexture2DClose.Key);
            Assert.IsTrue("Close" == configTexture2DClose.Value);            
            Assert.IsTrue(texture2DFavorite == configTexture2DFavorite.Key);
            Assert.IsTrue("Favorite" == configTexture2DFavorite.Value);     

            yield return null;
        }
    }
}