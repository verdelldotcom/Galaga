using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
public class EnemyShips : MonoBehaviour
{
  [SerializeField] private float speed;
  private Sprite[] sprites;
  public GameObject enemyShips;
  private Vector3 movePosition = new Vector3(1,1,0);
  private Vector2 movement = new Vector2(1,0);
  
  [SerializeField] int columns = 5;
  [SerializeField] int rows = 5;
  [SerializeField] private int spaceBetweenShips;
  
  private void Start()
  {
      for (int row = 0; row < rows; row++)
      {
          for (int column = 0; column < columns; column++)
          {
              movePosition = new Vector3(1 * row + spaceBetweenShips, 1 * column + spaceBetweenShips, 0);
              Instantiate(enemyShips,movePosition,quaternion.identity,this.transform);
          }
      }
  }

  private void Update()
  {
      transform.Translate(movement * speed * Time.deltaTime);
  }

  private void OnTriggerEnter2D(Collider2D other)
  {
      if (other.gameObject.tag == "Collider")
      {
          speed = speed * -1;
      }
  }
}
