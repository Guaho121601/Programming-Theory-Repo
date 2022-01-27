using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Cup : MonoBehaviour, IPointerClickHandler // INHERITANCE
{
    public string drinkName;
    public void OnPointerClick(PointerEventData eventData){
        DrinkMethod();
    }
    protected virtual void DrinkMethod(){ }// ABSTRACTION 
}
