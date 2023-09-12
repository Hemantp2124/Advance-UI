using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
[RequireComponent(typeof(Image))]
public class TabButtons : MonoBehaviour, IPointerEnterHandler,IPointerClickHandler,IPointerExitHandler
{
    public TabGroups tabGroups;
    public Image background;

    public void OnPointerClick(PointerEventData eventData)
    {
        tabGroups.OnTabSelected(this);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        tabGroups.OnTabEnter(this);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        tabGroups.OnTabExit(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        background = GetComponent<Image>();
        tabGroups.Subscribe(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
