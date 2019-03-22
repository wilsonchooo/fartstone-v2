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


        
        



        //Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 2, Camera.main.nearClipPlane - 5))
        Vector3 target = new Vector3(13.2f, 44.15161f, 0);
        Vector3 templocation = this.transform.position;
        Vector3 temp = transform.localScale;



        this.transform.position = Camera.main.ScreenToWorldPoint(new Vector3((Screen.width / 2) - 240f, (Screen.height / 2) + 250, Camera.main.nearClipPlane + .3f));

     

        //temp = Vector3.one * 2;
        //this.transform.position = Vector3.MoveTowards(transform.position, target, 100 *Time.deltaTime);
        this.transform.localScale = temp;
        //this.transform.position = templocation;

    }






}
