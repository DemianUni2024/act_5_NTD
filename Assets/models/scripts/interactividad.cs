using UnityEngine;

public class MouseInteractable : MonoBehaviour
{
    public GameObject panel; // Arrastra tu panel aquí

    void Start()
    {
        panel.SetActive(false); // Ocultar el panel al inicio
    }

    void Update()
    {
        // Comprobar si se hace clic con el mouse
        if (Input.GetMouseButtonDown(0)) // 0 es el botón izquierdo del mouse
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform == transform) // Verifica si se tocó este objeto
                {
                    TogglePanel(); // Alternar el panel
                }
            }
        }
    }

    void TogglePanel()
    {
        panel.SetActive(!panel.activeSelf);
    }
}
