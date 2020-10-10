using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MaterialSwitch : MonoBehaviour
{
    public Material[] mat;
    //public MeshRenderer ChildMesh;
    public MeshRenderer rend;
    public TMP_Dropdown dropdown;
    public Image img;
    public Sprite[] spritelegends;
    Material selectedMat;
    
    // Start is called before the first frame update
    void Start()
    {
        rend = gameObject.GetComponent<MeshRenderer>();
        //ChildMesh = GetComponent<MeshRenderer>();
        rend.enabled = true;
        rend.materials[1] = mat[0];
        //ChildMesh.materials[0] = mat[0];
        img.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void ChangeOption(int index)
    {
        Debug.Log(dropdown.value);
        selectedMat = mat[dropdown.value];
        //rend.materials[1] = mat[dropdown.value];
        //ChildMesh.materials[0] = mat[dropdown.value];
        StartCoroutine(toChange());
        
        if (dropdown.value == 0 || dropdown.value == 1 || dropdown.value == 3)
        {
            img.enabled = false;
        }
        else
        {
            img.enabled = true;
            img.sprite = spritelegends[dropdown.value];
        }
        
    }

    IEnumerator toChange()
    {
        Material[] materials = rend.materials;
        materials[1] = selectedMat;
        
        materials[1].color = Color.white;
        rend.materials = materials;
        Debug.Log("Name: " + rend.materials[1].name);
        yield return new WaitForSeconds(0.1f);
        //materials[1] = m;
        //materials[1].color = c;
        //rend.materials = materials;
    }
}
