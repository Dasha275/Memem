using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.UI;

public class cliсker : MonoBehaviour
{
    public Sprite[] images;
    public AudioClip[] AudioClips;
    public int count;
    public TMP_Text text;
    public string nameBuy;
    public GameObject butStore, panelbox;
    public Camera myCamera;
    public GameObject button;
    
    public void Click()
    {
        count++;
        text.text = count.ToString();
    }
    public void buyStore()
    {
        if (nameBuy == "Betment" && count >= 5)
        {
            button.GetComponent<Image>().sprite = images[6];
            GetComponent<AudioSource>().PlayOneShot(AudioClips[0]);
            count -= 5;
        }
        if (nameBuy == "Gorin" && count >= 5)
        {
            button.GetComponent<Image>().sprite = images[5];
            count -= 5;
        }
        if (nameBuy == "Zadnica" && count >= 5)
        {
            button.GetComponent<Image>().sprite = images[4];
            GetComponent<AudioSource>().PlayOneShot(AudioClips[1]);
            count -= 5;
        }
        if (nameBuy == "Stepanov" && count >= 3)
        {
            button.GetComponent<Image>().sprite = images[3];
            count -= 3;
        }
        if (nameBuy == "Ejik" && count >= 3)
        {
            button.GetComponent<Image>().sprite = images[2];
            count -= 3;
        }
        if (nameBuy == "Klava" && count >= 3)
        {
            button.GetComponent<Image>().sprite = images[1];
            count -= 3;
        }
        
        if (nameBuy == "pink" && count >= 100)
        {
            myCamera.GetComponent<Camera>().backgroundColor = Color.magenta;
            count -= 100;
        }
        if (nameBuy == "white" && count >= 100)
        {
            myCamera.GetComponent<Camera>().backgroundColor = Color.white;
            count -= 100;
        }
        text.text = count.ToString();
    }

    public void BuyKlava()
    {
        nameBuy = "Klava";
        buyStore();
    } 
    public void BuyEjik()
    {
        nameBuy = "Ejik";
        buyStore();
    } 
    public void BuyStepanov()
    {
        nameBuy = "Stepanov";
        buyStore();
    }
    public void BuyZadnica()
    {
        nameBuy = "Zadnica";
        buyStore();
    } 
    public void BuyGorin()
    {
        nameBuy = "Gorin";
        buyStore();
    }

    public void BuyBetment()
    {
        nameBuy = "Betment";
        buyStore();
    }

    public void buyStoreBGpink()
    {
        nameBuy = "pink";
        buyStore();
    }

    public void buyStoreBGwhite()
    {
        nameBuy = "white";
        buyStore();
    }
}

