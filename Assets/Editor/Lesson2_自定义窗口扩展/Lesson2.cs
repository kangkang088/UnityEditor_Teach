using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Lesson2 : EditorWindow
{
    [MenuItem("UnityEditorExpand/CustomWindow")]
    private static void ShowWindow()
    {
        Lesson2 lesson2 = EditorWindow.GetWindow<Lesson2>();
        lesson2.Show();
    }
    void OnGUI()
    {
        GUILayout.Label("测试文本");
        if (GUILayout.Button("测试按钮"))
        {
            Debug.Log("测试");
        }
    }
}
