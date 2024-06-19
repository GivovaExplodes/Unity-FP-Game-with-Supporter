using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerUI : MonoBehaviour
{

    public float startWaitTime = 1f; 
    [SerializeField]
    private TextMeshProUGUI promptText;
    [SerializeField]
    public ProgressBar Pb;
    public AIController controller;
    float m_WaitTime;
    int totemCounter;
    private bool invul = false;

    public bool damaged;
    // Start is called before the first frame update
    void Start()
    {
        totemCounter = 0;
        m_WaitTime = startWaitTime;
        Pb.BarValue = 100;
        damaged = false;
    }

    public void Update()
    {
        if(Pb.BarValue <= 0){
            SceneManager.LoadScene(3);
        }
        if(totemCounter >= 5){
            SceneManager.LoadScene(2);
        }
        
    }
    // Update is called once per frame
    public void UpdateText(string promptMessage)
    {
        
        promptText.text = promptMessage;
    }
    
    public void ApplyDamage(float dmg){
     if(!invul){
         Pb.BarValue -= dmg;
         StartCoroutine(JustHurt());
        }
    }

    public void TotemCounter(){
        totemCounter++;
    }
 
    IEnumerator JustHurt(){
     invul = true;
     yield return new WaitForSeconds(startWaitTime);
     invul = false;
    }
}
