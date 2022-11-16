# 12.prosenstatter.Random

## Warum könnte man den Zufall beim Programmieren brauchen?
Für Glückspiele, Lootboxen, random generated wordls, etc...

## Was ist der Unterschied zwischen Random aus System bzw. aus UnityEngine?
## Gib jeweils ein Beispiel.
UnityEngine.Randon ist eine statische Klasse die nur ein einzelner "globaler" Fluss aus Zufälligen Werten.  System.Random ist ein unabhängiger zufallsnummern Generator.

## Warum ist es sinnvoll den seed zu setzen bei Random?
Der Seed ist ein Ausgangspunkt für eine Folge von Pseudozufallszahlen. Mit dem selben Seed erhält man die Selbe Sequenz.

Was macht 
Random.Range 
