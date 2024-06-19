using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Totem : Interactable
{
    public PlayerUI playerUI;
    [SerializeField]
    private GameObject totem;
    [SerializeField]
    private TextMeshProUGUI totemText;
    
    // Start is called before the first frame update
    void Start()
    {
        
        totemText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    protected override void Interact(){
        totemText.gameObject.SetActive(true);
        Destroy(totem);
        playerUI.TotemCounter();
    }
}