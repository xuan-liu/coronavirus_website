using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Statistics
{

    public static float contagiousness = 0;

    public static float deathRate = 0;
    public static float washHandsReduction = 0;
    public static float wearMasksReduction = 0;
    public static float coronaRecoveryRate = 0;

    public static float fluRecoveryRate = 0;

    public static float globalChanceOfGoingToTest = 0;
    public static int numPeople = 0;
    public static List<Person> arr_people = new List<Person>();

    public static List<Day> arr_day = new List<Day>();
    public static int curDay = 0;


    //If we have time, false negative and positive testing
    public static float falseNegativeChance = 0;
    public static float falsePositiveChance = 0;

    //If we have time, separate by household
    public static int maxNumPeoplePerHousehold = 6;
    public static int maxNumHouseholds = 20;
    public static int numHouseholds = 0;
    public static List<Household> arr_households = new List<Household>();
    static Statistics(){

    }
}
