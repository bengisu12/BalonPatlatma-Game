using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonOlusturucu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject balon;
    float balonOlusturmaSuresi = 1f;
    float zamanSayaci=0f;
    Oyunkontrol2 okScripti;
    void Start()

    {
        okScripti = this.gameObject.GetComponent<Oyunkontrol2>();
        
    }

    // Update is called once per frame
    void Update()
    {
        zamanSayaci-= Time.deltaTime;
        if (zamanSayaci < 0 && okScripti.zamanSayaci>0){
            GameObject go = Instantiate (balon,new Vector3 (Random.Range(-2.50f,2.50f),-6f,0),Quaternion.Euler(0,0,0)) as GameObject;
            go.GetComponent<Rigidbody2D> ().AddForce(new Vector3(0,Random.Range(30f,80f),0));
            zamanSayaci = balonOlusturmaSuresi;
        }
        
    }
}

