# System Information

## Benutzererstellung

Der Kunde kann sich einen User erstellen, dabei sind Emailadresse, Vorname, Nachname und Adresse zwingend. Bei Erstellung erhält der Kunde eine Kundennummer (Format: KNR00000).

## Reservierung eines Autos

Der Kunde kann ein Auto einer bestimmten Klasse reservieren. Er muss zudem die Anzahl der Tage oder von/bis angeben, die er das Auto gerne mieten möchte. Dabei werden die Gesamtkosten berechnet. Wird die Reservation gespeichert, so wird sie mit einer Reservationsnummer (Format: RNR00000) abgelegt.

## Fahrzeugklassen

Jedes Auto kann einer bestimmten Klasse zwischen Luxusklasse, Mittelklasse oder Einfachklasse zugeordnet werden und besitzt zudem eine Marke, einen Typ und eine eindeutige Identifikation. 

- Jede Klasse besitzt eine Tagesgebühr.

## Abholung des Autos

Bei Abholung des Autos wird die Reservation in einen Mietvertrag umgewandelt.

- Das Fahrzeug wird per ParkingUnlockProSystem (PUPS) freigeschaltet (Interface noch nicht klar).

## Rückgabe eines Autos

Bei der Rückgabe eines Autos wird ein Rückgabeprotokoll erstellt und an den Mietvertrag angehängt.

- Pro Schaden muss er eine Gebühr bezahlen bis maximal 1000.-
- Der Schadensbetrag soll an das Versicherungs-Umsystem weitergeleitet werden (Interface noch nicht klar).
