using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{

    [SerializeField] GameObject mainPanel;

    public void TogglePanelVisibility()
    {
        mainPanel.SetActive(!mainPanel.activeSelf);
    }
}
