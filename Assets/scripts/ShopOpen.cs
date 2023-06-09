using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopOpen : MonoBehaviour
{
    public GameObject mainPanel, panelGB, panelChar, panel2021, panel2022, panel2023;
    public void Start()
    {
        panel2023.SetActive(false);
        panel2022.SetActive(false);
        panel2021.SetActive(false);
        mainPanel.SetActive(false);
        panelGB.SetActive(false);
        panelChar.SetActive(false);
    }

    public void CloseStoreBG()
    {
        panelGB.SetActive(false);
        mainPanel.SetActive(true);
    }

    public void OpenStoreBG()
    {
        panelGB.SetActive(true);
        mainPanel.SetActive(false);
    }
    public void openMainStore()
    {
       mainPanel.SetActive(true);
    }

    public void closeMainStore()
    {
       mainPanel.SetActive(false);
    }

    public void CloseChar()
    {
        panelChar.SetActive(false);
        mainPanel.SetActive(true);
    }
    public void OpenStoreChar()
    {
        panelChar.SetActive(true);
        mainPanel.SetActive(false);
    }

    public void openStore2021()
    {
        panel2021.SetActive(true);
        panelChar.SetActive(false);
    }

    public void openStore2022()
    {
        panel2022.SetActive(true);
        panelChar.SetActive(false);
    }

    public void openStore2023()
    {
        panel2023.SetActive(true);
        panelChar.SetActive(false);
    }

    public void closeStore2021()
    {
        panel2021.SetActive(false);
        panelChar.SetActive(true);
    }
    public void closeStore2022()
    {
        panel2022.SetActive(false);
        panelChar.SetActive(true);
    }
    public void closeStore2023()
    {
        panel2023.SetActive(false);
        panelChar.SetActive(true);
    }
}
