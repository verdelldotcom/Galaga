using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  [SerializeField] private float speed;
  private float horizontal;
  [SerializeField] private GameObject missile;
  
  private void Awake()
  {
  }
  private void Update()
  {
    horizontal = Input.GetAxisRaw("Horizontal");
    transform.Translate( horizontal * speed * Time.deltaTime,0,0);

    if (Input.GetKeyDown("space"))
    {
      Instantiate(missile, this.transform.position,Quaternion.identity);
    }
    
  }

  
}
