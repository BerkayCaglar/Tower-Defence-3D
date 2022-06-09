using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager BuildManagerInstance;

    private void Awake() 
    {
        if(BuildManagerInstance != null)
        {
            Debug.LogError("Another Build Manager On This Scene");
            return;
        }
        BuildManagerInstance = this;
    }
}