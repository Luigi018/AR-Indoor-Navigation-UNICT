using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropdownFunction : MonoBehaviour
{
    public GameObject Uff301;
    public GameObject Uff302;
    public GameObject Uff307;
    public GameObject Uff308;
    public GameObject Uff309;
    public GameObject Uff310;
    public GameObject Uff311;
    public GameObject Uff312;
    public GameObject Uff313;
    public GameObject Uff314;
    public GameObject Uff315;
    public GameObject Uff316;
    public GameObject Uff319;
    public GameObject Uff323;
    public GameObject Uff324;
    public GameObject Uff325;
    public GameObject Uff326;
    public GameObject Uff327;
    public GameObject Uff328;
    public GameObject Uff329;
    public GameObject Uff330;
    public GameObject Uff331;
    public GameObject Uff332;
    public GameObject Uff334;
    public GameObject Uff336;
    public GameObject Uff337;
    public GameObject Uff338;
    public GameObject Uff343;
    public GameObject Uff344;
    public GameObject Uff345;
    public GameObject Uff346;
    public GameObject Uff347;
    public GameObject Uff348;
    public GameObject Uff349;
    public GameObject Uff350;
    public GameObject Uff351;
    public GameObject Uff354;
    public GameObject Uff355;
    public GameObject Uff359;
    public GameObject Uff360;
    public GameObject Uff361;
    public GameObject Uff362;
    public GameObject Uff363;
    public GameObject Uff364;
    public GameObject Uff365;
    public GameObject Uff366;
    public GameObject Uff368;
    public GameObject Uff369;

    public void resetOption()
    {
        Uff301.SetActive(false);
        Uff302.SetActive(false);
        Uff307.SetActive(false);
        Uff308.SetActive(false);
        Uff309.SetActive(false);
        Uff310.SetActive(false);
        Uff311.SetActive(false);
        Uff312.SetActive(false);
        Uff313.SetActive(false);
        Uff314.SetActive(false);
        Uff315.SetActive(false);
        Uff316.SetActive(false);
        Uff319.SetActive(false);
        Uff323.SetActive(false);
        Uff324.SetActive(false);
        Uff325.SetActive(false);
        Uff326.SetActive(false);
        Uff327.SetActive(false);
        Uff328.SetActive(false);
        Uff329.SetActive(false);
        Uff330.SetActive(false);
        Uff331.SetActive(false);
        Uff332.SetActive(false);
        Uff334.SetActive(false);
        Uff336.SetActive(false);
        Uff337.SetActive(false);
        Uff338.SetActive(false);
        Uff343.SetActive(false);
        Uff344.SetActive(false);
        Uff345.SetActive(false);
        Uff346.SetActive(false);
        Uff347.SetActive(false);
        Uff348.SetActive(false);
        Uff349.SetActive(false);
        Uff350.SetActive(false);
        Uff351.SetActive(false);
        Uff354.SetActive(false);
        Uff355.SetActive(false);
        Uff359.SetActive(false);
        Uff360.SetActive(false);
        Uff361.SetActive(false);
        Uff362.SetActive(false);
        Uff363.SetActive(false);
        Uff364.SetActive(false);
        Uff365.SetActive(false);
        Uff366.SetActive(false);
        Uff368.SetActive(false);
        Uff369.SetActive(false);
    }

    public void DropdownFunctioning(int value)
    {
        resetOption();
        switch(value){
            case 0:
                break;
            case 1:
                Uff368.SetActive(true);//Allegra
                break;
            case 2:
                Uff364.SetActive(true);//Battiato
                break;
            case 3:
                Uff326.SetActive(true);//Bella A
                break;
            case 4:
                Uff323.SetActive(true);//Bella G
                break;
            case 5:
                Uff313.SetActive(true);//Boscarino
                break;
            case 6:
                Uff327.SetActive(true);//Camiola
                break;
            case 7:
                Uff363.SetActive(true);//Cantone
                break;
            case 8:
                Uff309.SetActive(true);//Catalano
                break;  
            case 9:
                Uff332.SetActive(true);//Causa
                break;
            case 10:
                Uff343.SetActive(true);//Cavallaro
                break;  
            case 11:
                Uff347.SetActive(true);//Cilia
                break;
            case 12:
                Uff310.SetActive(true);//Coco
                break;  
            case 13:
                Uff331.SetActive(true);//Colajanni
                break;
            case 14:
                Uff308.SetActive(true);//Cutello
                break; 
            case 15:
                Uff334.SetActive(true);//D'anna
                break;
            case 16:
                Uff365.SetActive(true);//D'asero
                break;  
            case 17:
                Uff337.SetActive(true);//Daniele
                break;
            case 18:
                Uff355.SetActive(true);//Di Raimondo
                break;  
            case 19:
                Uff346.SetActive(true);//Emmanuele
                break;
            case 20:
                Uff360.SetActive(true);//Fanciullo
                break;   
            case 21:
                Uff338.SetActive(true);//Faraci
                break;
            case 22:
                Uff362.SetActive(true);//Farinella
                break;   
            case 23:
                Uff366.SetActive(true);//Faro
                break;
            case 24:
                Uff328.SetActive(true);//Finocchiaro
                break;  
            case 25:
                Uff325.SetActive(true);//Furnari
                break;
            case 26:
                Uff301.SetActive(true);//Gallo
                break;  
            case 27:
                Uff344.SetActive(true);//Gionfriddo
                break;
            case 28:
                Uff330.SetActive(true);//Guardo
                break; 
            case 29:
                Uff311.SetActive(true);//Guarnera
                break;
            case 30:
                Uff336.SetActive(true);//Mammana
                break;
            case 31:
                Uff354.SetActive(true);//Marano
                break;
            case 32:
                Uff302.SetActive(true);//Messina
                break;  
            case 33:
                Uff343.SetActive(true);//Micale
                break;
            case 34:
                Uff359.SetActive(true);//Mosconi
                break;
            case 35:
                Uff315.SetActive(true);//Muscato
                break;
            case 36:
                Uff345.SetActive(true);//Naselli
                break;     
            case 37:
                Uff327.SetActive(true);//Nastasi
                break;
            case 38:
                Uff329.SetActive(true);//Nicolosi
                break;   
            case 39:
                Uff311.SetActive(true);//Ortis
                break;
            case 40:
                Uff316.SetActive(true);//Pavone
                break;
            case 41:
                Uff361.SetActive(true);//Pidatella
                break;
            case 42:
                Uff319.SetActive(true);//Puglisi
                break;  
            case 43:
                Uff348.SetActive(true);//Ragusa
                break;
            case 44:
                Uff350.SetActive(true);//Ricceri
                break;       
            case 45:
                Uff324.SetActive(true);//Riccobene
                break;
            case 46:
                Uff314.SetActive(true);//Romano
                break;     
            case 47:
                Uff307.SetActive(true);//Russo
                break;
            case 48:
                Uff344.SetActive(true);//Scapellato
                break;    
            case 49:
                Uff349.SetActive(true);//Scrimali
                break;
            case 50:
                Uff325.SetActive(true);//Spata
                break;  
            case 51:
                Uff369.SetActive(true);//Stanco
                break;
            case 52:
                Uff331.SetActive(true);//Stiglianò
                break;  
            case 53:
                Uff312.SetActive(true);//Tracinà
                break;
            case 54:
                Uff351.SetActive(true);//Zamboni
                break;  
        }
    }
}
