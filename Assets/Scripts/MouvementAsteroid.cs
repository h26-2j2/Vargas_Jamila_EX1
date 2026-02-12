using UnityEngine;

public class MouvementAsteroid : MonoBehaviour
{

    public float limiteYDebut = 12f;
    public float limiteY = -12f;
    public float vitesseY = -1f;

    public float vitesseRotation = 5f;

    
    void GenererTaille()
    {
        float tailleAleatoire = Random.Range(2.5f, 3.5f);
        transform.localScale = new Vector2(tailleAleatoire, tailleAleatoire);
    }
    void Generervitesse()
    {
        vitesseY = Random.Range(-5f, -2.5f);
    }

    void Start()
    {
        GenererTaille();
        Generervitesse();
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.0f, 0.0f, vitesseRotation * Time.deltaTime);

        float deplacementY = transform.position.y + vitesseY * Time.deltaTime;
        float deplacementX = transform.position.x;

        if (deplacementY < limiteY)
        {
            deplacementY = limiteYDebut;
            GenererTaille();
            Generervitesse();
            

        }
        transform.position = new Vector2(deplacementX, deplacementY);

    }
}
