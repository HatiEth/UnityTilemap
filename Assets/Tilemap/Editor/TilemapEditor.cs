using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(Tilemap))]
public class TilemapEditor : Editor {

    Tilemap map;

    void OnEnable()
    {
        Tools.current = Tool.None;
        map = target as Tilemap;
    }

    public void OnSceneGUI()
    {
        // EventHandling
        Handles.DoPositionHandle(map.transform.position, Quaternion.identity);
    }

    [DrawGizmo(GizmoType.NonSelected|GizmoType.Active)]
    public static void OnDrawGizmo(Tilemap map, GizmoType type)
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(map.transform.position, new Vector3(10, 10, 10));

    }

}
