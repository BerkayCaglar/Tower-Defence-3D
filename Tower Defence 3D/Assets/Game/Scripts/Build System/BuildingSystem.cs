using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BuildingSystem : MonoBehaviour
{
    [SerializeField]
    private Color hoverColor;
    [SerializeField]
    private Material mainMaterial,borderMaterial,cornerMaterial;
    private Renderer[] children;
    public GameObject bottomUI;
    private bool times = false,oneTime =false;
    private GameObject selectedBottomGameObject;
    public GameObject[] Turrets;
    
    private GameObject tempGameObject;
    private void Start() 
    {
        children = GetComponentsInChildren<Renderer>();
        InvokeRepeating("SpawnTurret",0f,0.2f);
    }
    
    [System.Obsolete]
    private void OnMouseDown() 
    {
        //  Instantiate(BuildManager.BuildManagerInstance.GetTurretToBuild(),transform.position + new Vector3(0f,0.75f,0f),transform.rotation);

        if(bottomUI.active == false)
        {
            if(selectedBottomGameObject != null)
            {
                selectedBottomGameObject = null;
            }
            bottomUI.SetActive(true);
            selectedBottomGameObject=gameObject;
            oneTime = false;
            times = true;
        }
        else
        {
            bottomUI.SetActive(false);
            selectedBottomGameObject=null;
            times = false;
        }
    }
    private void OnMouseEnter() 
    {
        foreach (Renderer rend in children)
        {
            rend.material.SetColor("_BaseColor",hoverColor);
        }
    }
    private void OnMouseExit() 
    {
        foreach (Renderer rend in children)
        {
            if(rend.material.name == "TP Main (Instance)")
            {
                rend.material.SetColor("_BaseColor",mainMaterial.GetColor("_BaseColor"));
            }
            if(rend.material.name == "TP Borders (Instance)")
            {
                rend.material.SetColor("_BaseColor",borderMaterial.GetColor("_BaseColor"));
            }
            if(rend.material.name == "TP Corners (Instance)")
            {
                rend.material.SetColor("_BaseColor",cornerMaterial.GetColor("_BaseColor"));
            }
        }
    }

    [System.Obsolete]
    private void SpawnTurret()
    {
        
        if(BuildManager.BuildManagerInstance.selectedTurret == "Delete" && !bottomUI.active && selectedBottomGameObject !=null && !oneTime && selectedBottomGameObject.transform.parent.name != "Placements")
        {
            oneTime = true;
            BuildManager.BuildManagerInstance.bottomGameObject.transform.parent = GameObject.Find("Placements").transform;
            Destroy(BuildManager.BuildManagerInstance.deleteObject);
            return;
        }
        if(!bottomUI.active && selectedBottomGameObject !=null && !oneTime && selectedBottomGameObject.transform.parent.name == "Placements")
        {
            
            oneTime = true;
            foreach (GameObject i in Turrets)
            {
                if(i.name == BuildManager.BuildManagerInstance.selectedTurret)
                {
                    selectedBottomGameObject.transform.SetParent(Instantiate(i,selectedBottomGameObject.transform.position + new Vector3(0f,0.75f,0f),i.transform.rotation).transform);
                }
            }
        }
    }
}