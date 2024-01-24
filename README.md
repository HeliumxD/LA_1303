# Projekt-Dokumentation

Einzelarbeit, Nicola

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 17.01.24 | 0.0.1   | Erstellung der User Stories, Beschreibung der Testfäll, Planung des Ablaufes und erste Codierungen |
| 24.01.24 | 0.0.2   | Grundcode für das Programm geschrieben und die Funktionen für Prozent und Binär geschrieben |
| 14.02.24 | ...     |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

Ein Programm das Zahlen in unterschiedlichen Schreibweisen ausgeben kann.

Ich möchte ein Programm schreiben, dass man eine Zahl eingeben und danach entscheiden kann, dass man zum Beispiel sie Binär oder in römischen Zahlen haben möchte.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1.0  | Muss            | Funktional | Zahl einlesen |
| 2.0  | Muss            | Qualität   | Ungültige Eingaben abfangen |
| 3.0  | Muss            | Funktional | Entscheiden welche Schreibweise |
| 4.0  | Kann            | Funktional | In Prozent ausgeben |
| 5.0  | Kann            | Funktional | Als Binär ausgeben |
| 6.0  | Kann            | Funktional | Römisch ausgeben |

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Programm gestartet | 19      | Zahl wird eingelesen |
| 2.1  | Programm gestartet | -5      | Ungültige Eingabe. Bitte geben sie eine positive ganze Zahl ein. |
| 2.2  | Programm gestartet | 3.5     | Ungütlige Eingabe. Bitte geben sie eine positive ganze Zahl ein. |
| 3.1  | Zahl eingegeben | 3 | Wird als römische Zahl ausgegeben. |
| 4.1  | Schreibweise bestimmt | Zahl: 19, Schreibweise: 1 | 0.19% |
| 5.1  | Schreibweise bestimmt | Zahl: 19, Schreibweise: 2 | 0010011|
| 6.1  | Schreibweise bestimmt | Zahl: 19, Schreibweise: 3 | XIX |

### 1.4 Diagramme

✍️Fügen Sie hier ein Use Case-Diagramm mit mindestens 3 Anwendungsfällen ein; und eine Skizze davon, wie Ihre Netzseite aussehen sollte.

## 2 Planen

| AP-№ | Frist    | Zuständig | Beschreibung | geplante Zeit |
| ---- | -------- | --------- | ------------ | ------------- |
| 1.A  | 17.01.24 | Nicola    | Zahl einlesen               | 30min |
| 2.A  | 17.01.24 | Nicola    | Ungültige Eingaben abfangen | 60min |
| 3.A  | 24.01.24 | Nicola    | Schreibweise bestimmen      | 90min |
| 4.A  | 24.01.24 | Nicola    | In Prozent ausgeben         | 90min |
| 5.A  | 14.02.24 | Nicola    | Als Binär ausgeben          | 90min |
| 6.A  | 14.02.24 | Nicola    | Römisch ausgeben            | 90min |

## 3 Entscheiden

Es sollten nur gerade positive Zahlen eingegeben werden, da es sonst mit dem Binärsystem und vor allem bei den römischen Zahlen zu schwierig wird.
Man sollte auch mit OOP leicht weitere Schreibweisfunktionen ins Programm hinzufügen können.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  | 17.01.24 | Nicola | 30min | 20min  |
| 2.A  | 17.01.24 | Nicola | 60min | 50min  |
| 3.A  | 24.01.24 | Nicola | 90min | 30min  |
| 4.A  | 24.01.24 | Nicola | 90min | 30min  |
| 5.A  | 24.01.24 | Nicola | 90min | 120min |
| 5.A  | 14.02.24 | Nicola | 90min | --min  |
| 6.A  | 14.02.24 | Nicola | 90min | --min  |

## 5 Kontrollieren

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  | XX.XX |          | Nicola |
| 2.1  | XX.XX |          | Nicola |
| 2.2  | XX.XX |          | Nicola |
| 3.1  | XX.XX |          | Nicola |
| 4.1  | XX.XX |          | Nicola |
| 5.1  | XX.XX |          | Nicola |
| 6.1  | XX.XX |          | Nicola |

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
