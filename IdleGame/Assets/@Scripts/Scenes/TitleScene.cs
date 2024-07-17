using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TitleScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Managers.Resource.LoadAllAsync<Object>("PreLoad",(key, count, totalCount)=>{
            Debug.Log($"{key} {count}/{totalCount}");

            if(count == totalCount){
                // Managers.Data.Init();
            }
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
