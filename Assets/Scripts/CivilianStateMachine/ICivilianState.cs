using UnityEngine;
using System.Collections;


public interface ICivilianState {

	void UpdateState();

	void OnTriggerEnter2D(Collider2D other);

	void OnTriggerExit2D(Collider2D other);

	void ToScatterState();

}
