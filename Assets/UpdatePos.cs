using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdatePos : MonoBehaviour
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
    private void SetPos(Vector3 pos)
    {
        text.text = $"Player pos: {pos.x}, {pos.y}, {pos.z}";
    }
    public void UpdateCount(Component sender, object data)
    {
        SetPos((Vector3)data);
        Debug.Log($"{sender} wants to change pos to {(Vector3)data}");
    }
}
