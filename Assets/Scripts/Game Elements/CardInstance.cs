using UnityEngine;
using System.Collections;

public class CardInstance : MonoBehaviour, Click
{
    public void OnClick()
    {
 
    }

    public void OnDrop()
    {
        throw new System.NotImplementedException();
    }

    public void OnHighlight()
    {
        Debug.Log(this.gameObject.name);
        float distanceFromCamera = .001f;

        Vector3 temp = transform.localScale;

        temp = Vector3.one* 2;


        this.transform.localScale = temp;


    }
}
