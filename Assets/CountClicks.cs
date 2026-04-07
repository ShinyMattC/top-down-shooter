using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountClicks : MonoBehaviour
{
    public BasicEventSO onMouseClick;
    public BasicEventSO onCountchanged;

    public int count;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit raycastHit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out raycastHit, 100f))
            {
                if (raycastHit.transform != null)
                {
                   //Our custom method. 
                   onMouseClick.raise(this, count);
                   Debug.Log("test"); 
                   IncClick(1);
                }
            }
        }
    }
    public void IncClick(int amount)
    {
        count += amount;
    }
}
