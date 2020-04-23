using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class planten : MonoBehaviour
{
    public Image img1;
    public Image img2;
    public Text plant_name;

    public string[] nameById;
    public GameObject addButton;

    public Text amountOfPlants;

    public void plantInfo(int plantId) {
        plant_name.text = nameById[plantId];
        img1.sprite = fotos[plantId * 2];
        img2.sprite = fotos[plantId  * 2 + 1];

        PlayerPrefs.SetString("plantName", nameById[plantId]);

        if (PlayerPrefs.GetInt(nameById[plantId] + "Collected") == 1)
        addButton.SetActive(false);

        if (PlayerPrefs.GetInt(nameById[plantId] + "Collected") == 0)
        addButton.SetActive(true);
    }

    public Sprite[] fotos;

    public InputField adresField;
    public InputField vindplaatsField;

    private string plantName;

    private string date;
    private string adres;
    private string vindplaats;

    public void toevoegen() {
        plantName = PlayerPrefs.GetString("plantName");

        PlayerPrefs.SetInt(plantName + "Collected", 1);
        PlayerPrefs.SetInt("amountOfPlants", PlayerPrefs.GetInt("amountOfPlants") + 1);

        date = System.DateTime.Now.ToString("MM/dd");
        adres = adresField.text;
        vindplaats = vindplaatsField.text;

        PlayerPrefs.SetString("list", PlayerPrefs.GetString("list") + plantName + " - " + date + " - " + adres + " - " + vindplaats + "\n\n");
    }

    public Text list;
    public bool listGameObject = false;

    void Update() {
        if (listGameObject == true)
        list.text = PlayerPrefs.GetString("list");

        amountOfPlants.text = PlayerPrefs.GetInt("amountOfPlants") + " / 10";
    }
}
