using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGema : MonoBehaviour
{
   
    public int vida;
    public string[] tag;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")){
            other.GetComponent<PlayerController>().Vida(vida);
            if(gameObject.CompareTag("Desaparece"))
            {
                Destroy(gameObject);
            }
        }
    }
    
}
