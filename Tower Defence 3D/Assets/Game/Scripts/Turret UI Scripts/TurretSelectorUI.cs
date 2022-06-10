using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretSelectorUI : MonoBehaviour,IPointerClickHandler,IPointerExitHandler
{
    [SerializeField]
    private GameObject CheckMark;

    [System.Obsolete]
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        if(!CheckMark.active)
        {
            CheckMark.SetActive(true);
        }
        else
        {
            BuildManager.BuildManagerInstance.SetActiveBottomUI(transform.parent.gameObject,false);
            CheckMark.SetActive(false);
            if(gameObject.name == "LeftTop")
            {
                BuildManager.BuildManagerInstance.SetSelectedTurret("Machine Turret");
            }
            if(gameObject.name == "RightTop")
            {
                BuildManager.BuildManagerInstance.SetSelectedTurret("Rocket Launcher");
            }
            if(gameObject.name == "MiddleBottom")
            {
                BuildManager.BuildManagerInstance.SetSelectedTurret("Sniper Rifle");
            }
            if(gameObject.name == "MiddleTop")
            {
                BuildManager.BuildManagerInstance.SetSelectedTurret("Delete");
            }
        }
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        CheckMark.SetActive(false);
    }
}