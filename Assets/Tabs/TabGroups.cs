using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabGroups : MonoBehaviour
{
    public List<TabButtons> tabButtons;
    public Sprite tableIdle;
    public Sprite tabHover;
    public Sprite tabActive;
    public TabButtons selectedTab;

    public void Subscribe (TabButtons buttons)
    {
        if(tabButtons == null)
        {
            tabButtons = new List<TabButtons>();
        }
        tabButtons.Add(buttons);
    }
    public void OnTabEnter(TabButtons buttons)
    {
        ResetTabs();
        if(selectedTab == null || buttons != selectedTab)
        {
            buttons.background.sprite = tabHover;
        }
        
    }
    public void OnTabExit(TabButtons buttons)
    {
        ResetTabs();
    }
    public void OnTabSelected(TabButtons buttons)
    {
        selectedTab = buttons;
        ResetTabs();
        buttons.background.sprite = tabActive;
    }

    public void ResetTabs()
    {
        foreach(TabButtons button in tabButtons)
        {
            if(selectedTab!=null && button == selectedTab) { continue; }
            button.background.sprite = tableIdle;
        }
    }
}
