using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject Altin;
    public GameObject Tas;
    public Transform Char;
    // Start is called before the first frame update
    void Start()
    {

        
        
            InvokeRepeating("SpawnGold", 0, 0.5f);
            InvokeRepeating("SpawnEngel", 0, 1.5f);

        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnGold()
    {
        int rasgele = Random.Range(0, 100);
        if (rasgele < 50)
        {
            GameObject Yeni_klon = Instantiate(Altin);
            Yeni_klon.transform.position = new Vector3(498, 1, Char.position.z + 70f);
        }
        if (rasgele >= 50)
        {
            GameObject Yeni_klon = Instantiate(Altin);
            Yeni_klon.transform.position = new Vector3(502, 1, Char.position.z + 70f);
        }
    }
    /////////////// Taþ Engeli
    void SpawnEngel()
    { 
        
        int Rasgele_2 = Random.Range(0, 100);
        int RasTas = Random.Range(495,505);
        if (Rasgele_2>=50)
        {
            GameObject Yeni_klon1 = Instantiate(Tas);
            Yeni_klon1.transform.position = new Vector3(RasTas, 0.4f, Char.position.z + 70f);
        }
        //if (Rasgele_2<50)
        //{

        //    GameObject Yeni_klon2 = Instantiate(Agac);
        //    Yeni_klon2.transform.position = new Vector3(507, 1, Char.position.z + 70f);
        //}
    }



}
