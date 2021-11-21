using UnityEngine;

public class LevelExit : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }

  private void OnTriggerEnter2D(Collider2D other)
  {
    if (other.CompareTag("Player"))
    {
      LevelManager.instance.EndLevel(); // start level end coroutine
    }
  }
}
