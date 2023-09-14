using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    
    public GameObject prefab;
    private int n_circulos;
    
    // Start is called before the first frame update
    void Start()
    {
        n_circulos = Random.Range(1, 10);
        for (int i = 0; i < n_circulos; i++)
        {
            GameObject circulo_actual = Instantiate(prefab, transform.position = new Vector3(Random.Range(-5,5),Random.Range(-2,2),0), Quaternion.identity);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
