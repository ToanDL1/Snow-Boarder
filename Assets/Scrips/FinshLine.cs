using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinshLine : MonoBehaviour
{
    [SerializeField] ParticleSystem FinishEffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Player")){
            FinishEffect.Play();
            SoundController.instance.PlayClip("Finish+SFX");
            Invoke("Replay", 0.5f);
        }
    }
    

    private void Replay(){
        SceneManager.LoadScene(0);
    }
}
