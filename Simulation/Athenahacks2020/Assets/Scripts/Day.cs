using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day
{
    public int numAlive = 0;
    public int numSick = 0;
    public int numCorona = 0;
    public int numCoronaPositive = 0;

    
    // Start is called before the first frame update
    public Day(){

    }
    void nextDay(){

    }

    void calculatePersonStates(){
        numAlive = CrowdController.arr_people.Count;
        numSick = 0;
        numCorona = 0;
        numCoronaPositive = 0;

        for (int i = 0; i < CrowdController.arr_people.Count; i++ ){
            if (CrowdController.arr_people[i].isDead){
                numAlive--;
            }
            else{
                if (CrowdController.arr_people[i].visibleSymptoms){
                    numSick++;
                }

                if (CrowdController.arr_people[i].hasVirus){
                    numCorona++;
                    if (CrowdController.arr_people[i].tested){
                        numCoronaPositive++;
                    }
                }
            }
        }
        
    }

}
