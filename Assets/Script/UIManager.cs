using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]List<Canvas> UIList;
    [SerializeField]
    Canvas startScreenUI;
    [SerializeField]
    Canvas MenuUI;
    [SerializeField]
    Canvas contenuFrigoUI;
    [SerializeField]
    Canvas intolerancesUI;
    [SerializeField]
    Canvas listrecettesUI;
    [SerializeField]
    Canvas listIngredietnsUI;
    [SerializeField]
    Canvas listAchatsUI;
    [SerializeField]
    Canvas filtresUI;



    void DesactivateAllUI()
    {
        foreach(Canvas UI in UIList)
        {
            UI.gameObject.SetActive(false);
        }
    }

    public void Demarrer()
    {
        DesactivateAllUI();
        MenuUI.gameObject.SetActive(true);
    }

    public void ContenuFrigo()
    {
        DesactivateAllUI();
        contenuFrigoUI.gameObject.SetActive(true);
    }

    public void Filtres()
    {
        DesactivateAllUI();
        filtresUI.gameObject.SetActive(true);
    }

    public void Intolerances()
    {
        DesactivateAllUI();
        intolerancesUI.gameObject.SetActive(true);
    }

    public void ListRecettes()
    {
        DesactivateAllUI();
        listrecettesUI.gameObject.SetActive(true);
    }

    public void ListIngredients()
    {
        DesactivateAllUI();
        listIngredietnsUI.gameObject.SetActive(true);
    }

    public void ListAchats()
    {
        DesactivateAllUI();
        listAchatsUI.gameObject.SetActive(true);
    }

    public void Retour()
    {
        DesactivateAllUI();
        MenuUI.gameObject.SetActive(true);
    }


}
