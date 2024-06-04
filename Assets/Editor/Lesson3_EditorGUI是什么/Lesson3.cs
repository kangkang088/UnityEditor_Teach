using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Lesson3 : EditorWindow
{
    [MenuItem("UnityEditorExpand/Lesson3")]
    private static void OpenLesson3()
    {
        Lesson3 lesson3 = EditorWindow.GetWindow<Lesson3>();
        lesson3.titleContent = new GUIContent("EditorGUI讲解");
        lesson3.Show();
    }
    /// <summary>
    /// OnGUI is called for rendering and handling GUI events.
    /// This function can be called multiple times per frame (one call per event).
    /// </summary>
    void OnGUI()
    {
        #region Lesson4 文本控件，层级和标签控件，颜色获取控件
        EditorGUILayout.LabelField("文本控件", "内容");
        #endregion
    }
}
