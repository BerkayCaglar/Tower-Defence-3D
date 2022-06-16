using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager BuildManagerInstance;
    [HideInInspector]
    public string selectedTurret;
    [HideInInspector]
    public GameObject deleteObject,bottomGameObject;
    private void Awake() 
    {
        if(BuildManagerInstance != null)
        {
            Debug.LogError("Another Build Manager On This Scene");
            return;
        }
        BuildManagerInstance = this;
    }
    public void SetActiveBottomUI(GameObject UI,bool ActiveOrPass)
    {
        UI.SetActive(ActiveOrPass);
    }
    public void SetSelectedTurret(string turret,GameObject deletingObject = null,GameObject bottomObject=null)
    {
        selectedTurret = turret;
        if(deletingObject != null && bottomObject != null)
        {
            deleteObject = deletingObject.transform.parent.gameObject.transform.parent.gameObject;
            bottomGameObject = bottomObject;
        }
    }
}