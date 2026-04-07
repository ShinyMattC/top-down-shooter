using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayClicks : MonoBehaviour
{
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SetCount(int count)
    {
        text.text = count.ToString();
    }
    public void UpdateCount(Component sender, object data)
    {
        SetCount((int)data);
        Debug.Log($"{sender} wants to change click count to {(int)data}");
    }
}
