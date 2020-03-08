using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day : MonoBehaviour
{
    public int numAlive = 0;
    public int numSick = 0;
    public int numCorona = 0;
    public int numCoronaPositive = 0;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void nextDay(){

    }

    void calculatePersonStates(){
        numAlive = Statistics.arr_people.Count;
        numSick = 0;
        numCorona = 0;
        numCoronaPositive = 0;

        for (int i = 0; i < Statistics.arr_people.Count; i++ ){
            if (Statistics.arr_people[i].isDead){
                numAlive--;
            }
            else{
                if (Statistics.arr_people[i].visibleSymptoms){
                    numSick++;
                }

                if (Statistics.arr_people[i].hasVirus){
                    numCorona++;
                    if (Statistics.arr_people[i].tested){
                        numCoronaPositive++;
                    }
                }
            }
        }
        
    }

}
