﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CardViz : MonoBehaviour
{
    public Card card;
    public CardVizProperties[] properties;


    private void Start()
    {
        LoadCard(card);
    }

    public void LoadCard(Card c)
    {
        if (c == null)
            return;

        card = c;

        for (int i = 0; i < c.properties.Length; i++)
        {
            CardProperties cp = c.properties[i];

            CardVizProperties p = GetProperty(cp.element);
            if (p == null)
            {
                continue;
            }

            if (cp.element is ElementInt)
            {
                p.text.text = cp.intValue.ToString();

            }
            else
            if (cp.element is ElementText)
            {
                p.text.text = cp.stringValue;
            }
            else
            if(cp.element is ElementImage)
            {
                p.img.sprite = cp.sprite;
            }
        }
    }

    public CardVizProperties GetProperty(Element e)
    {
        CardVizProperties result = null;

        for(int i=0; i<properties.Length;i++)
        {
            if(properties[i].element == e)
            {
                result = properties[i];
                break;
            }
        }
        return result;
    }
}
