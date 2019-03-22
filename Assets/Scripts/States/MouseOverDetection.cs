using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


[CreateAssetMenu(menuName ="Actions/MouseOverDetection")]
public class MouseOverDetection : Action
{
    public override void Execute(float d)
    {
        PointerEventData pointer = new PointerEventData(EventSystem.current)
        {
            position = Input.mousePosition
        };

        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(pointer,results);


        foreach(RaycastResult r in results)
        {
            Click c = r.gameObject.GetComponentInParent<Click>();

            if(c!=null)
            {
                c.OnHighlight();
            }
        }
    }

}
