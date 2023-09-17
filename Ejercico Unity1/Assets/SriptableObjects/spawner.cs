using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public SpawnerSettings settings;
    public GameObject prefab;
    private int n_circulos;
    
    // Start is called before the first frame update
    void Start()
    {
        //n_circulos = Random.Range(1, 10);
        n_circulos =settings.numeroObjetos;
        
        for (int i = 0; i < n_circulos; i++)
        {
            GameObject circulo_actual = Instantiate(prefab, transform.position = new Vector3(Random.Range(-10,10),Random.Range(-4,5),0), Quaternion.identity);
            
        }
    }
}
