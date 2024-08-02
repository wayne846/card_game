using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/******************************
放在Main Camera上，用來檢測滑鼠的動作
*******************************/

public class MouseDetect : MonoBehaviour
{
    private GameObject lastHoveredCard = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);  
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit)) {  
            //Select stage   

            /* 
            if (hit.transform.tag == "Card") {
                if (lastHoveredCard != hit.transform.gameObject) {
                    if (lastHoveredCard != null) {
                        lastHoveredCard.GetComponent<CardDisplay>().cardData.isHovered = false;
                    }
                    lastHoveredCard = hit.transform.gameObject;
                    lastHoveredCard.GetComponent<CardDisplay>().cardData.isHovered = true;
                }
                Debug.Log("Hovered Card: " + hit.transform.name);
            }*/
        }
    }
}
