using System.Collections;
using System.Collections.Generic;
using System.Text;
using Codice.CM.Client.Gui;
using UnityEditor;
using UnityEngine;

public class Lesson18 : EditorWindow
{
    [MenuItem("UnityEditorExpand/Selection")]
    private static void CustomWindow()
    {
        Lesson18 lesson18 = EditorWindow.GetWindow<Lesson18>();
        lesson18.Show();
    }
    private StringBuilder sb = new StringBuilder("没有选择");
    void OnGUI()
    {
        #region Lesson19常用静态成员
        if (GUILayout.Button("获取当前选择的Transform"))
        {
            if (Selection.activeTransform != null)
            {
                sb.Clear();
                sb.Append(Selection.activeTransform.name);
            }
            else
            {
                sb.Clear();
                sb.Append("没有选择");
            }
        }
        EditorGUILayout.LabelField("当前选择的对象的名字", sb.ToString());
        #endregion
    }

}
