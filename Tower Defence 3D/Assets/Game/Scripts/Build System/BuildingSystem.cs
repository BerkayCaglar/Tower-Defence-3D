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
    private void Start() 
    {
        children = GetComponentsInChildren<Renderer>();
    }
    private void OnMouseDown() 
    {
        if(turret != null)
        {
            Debug.Log("You Cant Build!");
            return;
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
}