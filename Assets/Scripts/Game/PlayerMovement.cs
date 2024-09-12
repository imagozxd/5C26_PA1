using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D myRB;
    private float limitSuperior;
    private float limitInferior;


    public Rect restrictedArea; // Define la zona restringida en coordenadas del mundo
    public Color gizmoColor = Color.red; // Color para dibujar el área restringida en la vista de escena

    private Color selectedColor = Color.white;

    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        SetMinMax();
    }

    void SetMinMax()
    {
        Vector3 bounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        limitInferior = -bounds.y;
        limitSuperior = bounds.y;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Candy")
        {
            
        }

        if(other.tag == "Enemy")
        {
            
        }
    }

    public void OnMovement()
    {

    }

    
}
