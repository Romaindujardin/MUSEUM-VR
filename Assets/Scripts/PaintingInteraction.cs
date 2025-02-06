using UnityEngine;
using UnityEngine.UI;

public class PaintingInteraction : MonoBehaviour
{
    public GameObject[] imagesToDisplay; // Tableau contenant les images
    public Button actionButton; // Le bouton pour changer l'image

    private int currentImageIndex = 0;

    private void Start()
    {
        // Masque toutes les images au d�but
        foreach (GameObject image in imagesToDisplay)
        {
            image.SetActive(false);
        }

        // V�rifie si un bouton est configur� et ajoute l'�couteur
        if (actionButton != null)
        {
            actionButton.onClick.AddListener(ChangeImage);
        }
        else
        {
            Debug.LogError("Aucun bouton n'est attach� !");
        }
    }

    private void ChangeImage()
    {
        // Masque l'image actuelle
        if (imagesToDisplay[currentImageIndex] != null)
        {
            imagesToDisplay[currentImageIndex].SetActive(false);
        }

        // Passe � l'image suivante
        currentImageIndex = (currentImageIndex + 1) % imagesToDisplay.Length;

        // Affiche la nouvelle image
        if (imagesToDisplay[currentImageIndex] != null)
        {
            imagesToDisplay[currentImageIndex].SetActive(true);
            Debug.Log($"Image affich�e : {imagesToDisplay[currentImageIndex].name}");
        }
    }
}
