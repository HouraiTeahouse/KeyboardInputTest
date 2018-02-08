using System; 
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class KeyInputDump : MonoBehaviour {

  public Text Text;
  KeyCode[] KeyCodes;

  /// <summary>
  /// Awake is called when the script instance is being loaded.
  /// </summary>
  void Awake() {
     KeyCodes = (KeyCode[])Enum.GetValues(typeof(KeyCode));
  }

  /// <summary>
  /// Update is called every frame, if the MonoBehaviour is enabled.
  /// </summary>
  void Update() {
    Text.text = string.Join(" ", (from keycode in KeyCodes
                                  where Input.GetKey(keycode)
                                  select keycode.ToString()).ToArray());
  }

}
