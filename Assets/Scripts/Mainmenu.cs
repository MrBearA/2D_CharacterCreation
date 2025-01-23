using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class Mainmenu : MonoBehaviour
{
    public GameObject Mainmenu1, Gender, ash1, ash2, ash3, varus1, varus2, varus3, Costume_Male, Costume_Female, Male_1, female_2 ;
    // Start is called before the first frame update
    void Start()
    {
        Mainmenu1.SetActive(true);
        Gender.SetActive(false);
        Costume_Male.SetActive(false);
        Costume_Female.SetActive(false);
        
    }

    public void mainmenu()
    {
        Gender.SetActive(true);
        Mainmenu1.SetActive(false);
        
    }

    public void exit()
    {
        Application.Quit();
    }

    public void Male()
    {
        ash1.SetActive(false);
        varus1.SetActive(true);
        Costume_Male.SetActive(true);
        Costume_Female.SetActive(false);
        female_2.SetActive(false);
    }

    public void Female()
    {
        ash1.SetActive(true);
        varus1.SetActive(false);
        Costume_Female.SetActive(true);
        Costume_Male.SetActive(false);
        Male_1.SetActive(false);
    }

    public void costume_Male1() 
    {
        varus1.SetActive(true);
        varus2.SetActive(false);
        varus3.SetActive(false);
    }

    public void costume_Male2() 
    {
        varus2.SetActive(true);
        varus1.SetActive(false);
        varus3.SetActive(false);
    }

    public void costume_Male3() 
    {
        varus3.SetActive(true);
        varus2.SetActive(false);
        varus1.SetActive(false);
    }

    public void costume_Female1() 
    {
        ash1.SetActive(true);
        ash2.SetActive(false);
        ash3.SetActive(false);
    } 
    public void costume_Female2() 
    {
        ash2.SetActive(true);
        ash1.SetActive(false);
        ash3.SetActive(false);
    }
    public void costume_Female3() 
    {
        ash3.SetActive(true);
        ash2.SetActive(false);
        ash1.SetActive(false);
    }

    public void Reset()
    {
      Male_1.SetActive(true);
      female_2.SetActive(true);
      Costume_Male.SetActive(false);
      Costume_Female.SetActive(false);
      ash1.SetActive(false);
      ash2.SetActive(false);
      ash3.SetActive(false);
      varus1.SetActive(false);
      varus2.SetActive(false);
      varus3.SetActive(false);
    }

    public void return_mainmenu() 
    {
        Mainmenu1.SetActive(true);
        Gender.SetActive(false);
        Costume_Male.SetActive(false);
        Costume_Female.SetActive(false);
        varus1.SetActive(false);
        varus2.SetActive(false);
        varus3.SetActive(false);
        ash1.SetActive(false);
        ash2.SetActive(false);
        ash3.SetActive (false);
    }

}
