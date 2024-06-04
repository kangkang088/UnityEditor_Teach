using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEditor;
using UnityEngine;

public class Lesson12 : EditorWindow
{
    private Texture image = null;

    private Texture texture;
    [MenuItem("UnityEditorExpand/EditorGUIUtility")]
    private static void OpenLesson12()
    {
        Lesson12 lesson12 = EditorWindow.GetWindow<Lesson12>();
        lesson12.Show();
    }
    void OnGUI()
    {
        #region Lesson13资源加载
        if (GUILayout.Button("资源加载"))
            image = EditorGUIUtility.Load("1.jpeg") as Texture;
        if (image != null)
        {
            GUI.DrawTexture(new Rect(0, 50, 160, 90), image);
        }
        #endregion

        #region Lesson14搜索框查询、对象选中提示
        if (GUILayout.Button("搜索框查询"))
        {
            EditorGUIUtility.ShowObjectPicker<Texture>(null, true, "", 0);
        }
        if (Event.current.commandName == "ObjectSelectorUpdated")
        {

            texture = EditorGUIUtility.GetObjectPickerObject() as Texture;
            if (texture != null)
                Debug.Log(texture.name);
        }
        if (Event.current.commandName == "ObjectSelectorClosed")
        {

            texture = EditorGUIUtility.GetObjectPickerObject() as Texture;
            if (texture != null)
                Debug.Log(texture.name);
        }
        #endregion
    }
}
