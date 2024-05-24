using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

/// <summary>
/// To add a level, just look for the bits that say "MAKE A CHANGE" by pressing CTRL + F
/// </summary>
/// 
public class LevelLoader : EditorWindow
{
    // MAKE A CHANGE - copy and paste any of these lines for any additional scripts
    //public string StartScreenScene = "Assets/Scenes/Sarah/StartScreen.unity";
    //public string cameraLightsScene = "Assets/Scenes/Sarah/Camera.unity";
    //public string environmentScene = "Assets/Scenes/Sarah/Environment.unity";
    public string vivScene = "Assets/Scenes/Viv.unity";
    public string biancaScene = "Assets/Scenes/Bianca.unity";
    public string laraScene = "Assets/Scenes/Lara.unity";
    
    [MenuItem("TeamNoFliesAllowed/Level Loader")]
    public static void ShowWindow()
    {
        GetWindow<LevelLoader>("Level Loader");
    }
    
    void OnGUI()
    {
        EditorGUILayout.Space(10);
        // MAKE A CHANGE - copy and paste any of these lines for any additional scene
        //cameraLightsScene = EditorGUILayout.TextField("Path to camera/lights scene", cameraLightsScene);
        //environmentScene = EditorGUILayout.TextField("Path to env scene", environmentScene);
        vivScene = EditorGUILayout.TextField("Path to Viv's scene", vivScene);
        biancaScene = EditorGUILayout.TextField("Path to Bianca's scene", biancaScene);
        laraScene = EditorGUILayout.TextField("Path to Lara's scene", laraScene);
        
        EditorGUILayout.Space(10);
        if (GUILayout.Button("Load Scenes"))
        {
            // Check if the user wants to save any changes first
            if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
            {
                // Load the main scene
                //EditorSceneManager.OpenScene(cameraLightsScene, OpenSceneMode.Single);
            
                // Additionally load everything else 
                // MAKE A CHANGE - Add your new scene to this by copy and pasting and updating an existing one
                //EditorSceneManager.OpenScene(environmentScene, OpenSceneMode.Additive);
                EditorSceneManager.OpenScene(vivScene, OpenSceneMode.Additive);
                EditorSceneManager.OpenScene(biancaScene, OpenSceneMode.Additive);
                EditorSceneManager.OpenScene(laraScene, OpenSceneMode.Additive);
            }
        }
    }
}
