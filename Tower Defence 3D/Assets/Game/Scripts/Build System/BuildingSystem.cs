using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSystem : MonoBehaviour
{
    [SerializeField]
    private Color hoverColor;
    [SerializeField]
    private Material mainMaterial,borderMaterial,cornerMaterial;
    private Renderer[] children;
    private GameObject turret;
    public GameObject bottomUI;
    private bool times = false,oneTime =false;
    private GameObject selectedBottomGameObject;
    public GameObject[] Turrets;
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
        if(BuildManager.BuildManagerInstance.selectedTurret == "Delete" && !bottomUI.active && selectedBottomGameObject !=null && !oneTime && selectedBottomGameObject.transform.parent.name != "Placement")
        {
            oneTime = true;
            GameObject tempGameObject=selectedBottomGameObject.transform.parent.gameObject;
            selectedBottomGameObject.transform.parent = GameObject.Find("Placements").transform;
            Destroy(tempGameObject);
            return;
        }
        if(!bottomUI.active && selectedBottomGameObject !=null && !oneTime)
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