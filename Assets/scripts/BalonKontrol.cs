using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonKontrol : MonoBehaviour
{
    public GameObject patlama;
    Oyunkontrol2 oyunkontrolscripti;
    
    void Start(){
        oyunkontrolscripti=GameObject.Find ("Scripts").GetComponent<Oyunkontrol2>();
    }
    void OnMouseDown()
    {
        GameObject go = Instantiate(patlama,transform.position,transform.rotation)as GameObject;
        Destroy(this.gameObject);
        Destroy(go,0.283f);
        oyunkontrolscripti.BalonEkle ();
    }
}

