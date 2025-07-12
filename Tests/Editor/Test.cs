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
        }
    }
}