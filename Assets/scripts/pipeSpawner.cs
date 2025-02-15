using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawner : MonoBehaviour
{   
    public static pipeSpawner instance;
    [SerializeField] private GameObject _pipe;
    [SerializeField] private int maxTime;
    [SerializeField] private int Range;

    private void Awake() {
        if(instance==null){
            instance = this;
        }
    }
    private float timer;
    public bool spawn;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }
      void Update()
    {
        
        if(timer> maxTime ){
            spawnPipe();
            timer=0;
        }
        timer +=Time.deltaTime;
    
    }   
    private void spawnPipe(){

        if(spawn){
            Vector3 spawnpos=transform.position+new Vector3(0,Random.Range(-Range,Range));

            GameObject pipe = Instantiate(_pipe,spawnpos,Quaternion.identity);
            Destroy(pipe, 10f);

        }
        
    }
    // Update is called once per frame
  
}
