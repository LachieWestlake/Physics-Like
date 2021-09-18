using UnityEngine;

public interface IItem {
    string Name { get; set; }
    string Description { get; set; }
    int Value { get; set; }
    int Weight { get; set; }
    ItemTypes ItemType { get; set; }
    GameObject GameObject { get; }
}